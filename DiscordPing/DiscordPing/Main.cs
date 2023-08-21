using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordPing
{
    public partial class Main : Form
    {
        private bool sendingEnabled = false;
        private int sendDelay = 1000;

        public Main()
        {
            InitializeComponent();
            this.textWebHook.TextChanged += new System.EventHandler(this.textWebHook_TextChanged);
            
        }
        public void Alert(string msg, Notification.enmType type)
        {
            //ALERT MESSAGE

            Notification frm = new Notification();
            frm.showAlert(msg, type);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sendButton.BorderRadius = 6;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //SEND A MESSAGE ON THE WEBHOOK


            string message = textMessage.Text.Trim();
            string webhookUrl = textWebHook.Text.Trim();

            if (string.IsNullOrEmpty(webhookUrl) || webhookUrl.ToLower() == "false")
            {
                //INCORRECT OR NON-FUNCTIONAL WEBHOOK

                this.Alert("WebHook invalida", Notification.enmType.Error);
                return;
            }

            HttpClient client = new HttpClient();

            StringContent content = new StringContent("{\"content\":\"" + message + "\"}", Encoding.UTF8, "application/json");
            content.Headers.ContentType.CharSet = "utf-8";


            try
            {
                HttpResponseMessage response = client.PostAsync(webhookUrl, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    //SUCCESS IN SEND THE MESSAGE

                    this.Alert("Sucesso ao enviar a mensagem.", Notification.enmType.Error);
                }
                else
                {
                    //ERROR SEND MESSAGE

                    this.Alert("Erro ao enviar a mensagem", Notification.enmType.Error);
                }
            }
            catch (Exception ex)
            {
                //ERROR LOG

                AddLogMessage("Erro ao enviar mensagem: " + ex.Message);
            }
        }


        private void AddLogMessage(string message)
        {
            
        }


        private void webhookUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textWebHook.Text.Trim()) || textMessage.Text.Trim().ToLower() == "false")
            {
                sendButton.Enabled = false;
            }
            else
            {
                sendButton.Enabled = true;
            }
        }



        private void SendingThreadFunction()
        {
            while (sendingEnabled)
            {
                sendButton_Click(this, EventArgs.Empty);

                Thread.Sleep(sendDelay);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            //CLOSE THE PROGRAM

            Application.Exit();
        }

        

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void webhookUrlTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textMessage_TextChanged(object sender, EventArgs e)
        {
            //BUTTON COLOR

            if (textMessage.Text.Length > 0)
            {
                textMessage.BorderColor = ColorTranslator.FromHtml("#a8e0f5");
            }
            else
            {
                textMessage.BorderColor = ColorTranslator.FromHtml("#1c1c1c");
            }
        }

        private void textWebHook2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textWebHook_TextChanged(object sender, EventArgs e)
        {
            //BUTTON COLOR

            if (textWebHook.Text.Length > 0)
            {
                textWebHook.BorderColor = ColorTranslator.FromHtml("#ec92a5");
            }
            else
            {
                textWebHook.BorderColor = ColorTranslator.FromHtml("#1c1c1c");
            }
        }

        private void sendButton_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void logTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void logTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }
    }
}