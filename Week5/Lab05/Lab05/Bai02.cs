﻿using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit;
using System;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
            listViewMess.View=View.Details;
        }

        private void SetupListView()
        {
            listViewMess.Clear();
            listViewMess.Columns.Add("Email", 300);
            listViewMess.Columns.Add("From", 200);
            listViewMess.Columns.Add("Date", 100);
        }

        private void buttonIMAP_Click(object sender, EventArgs e)
        {
            try
            {
                SetupListView();
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(textBoxEmail.Text.Trim(), textBoxPass.Text.Trim());

                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);


                    labelTotal_2.Text = inbox.Count.ToString();
                    labelRecent_2.Text = inbox.Recent.ToString();

                    int limit=Math.Min(10, inbox.Count);
                    for (int i = 0; i < limit; i++)
                    {
                        var message = inbox.GetMessage(i);
                        var item = new ListViewItem(new[]
                        {
                        message.Subject,
                        message.From.ToString(),
                        message.Date.ToString()
                    });
                    listViewMess.Items.Add(item);
                    }// Add thông tin lên bảng
                    client.Disconnect(true);
                }

                MessageBox.Show("IMAP read successfully!", "Notification");
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error!");
            }
            
        }

        private void buttonPop3_Click(object sender, EventArgs e)
        {
            SetupListView();
            try
            {
                using (var client = new Pop3Client())
                {
                    client.Connect("pop.gmail.com", 995, true);
                    client.Authenticate(textBoxEmail.Text.Trim(), textBoxPass.Text.Trim());

                    labelTotal_2.Text = client.Count.ToString();

                    for (int i = 0; i < Math.Min(10, client.Count); i++)
                    {
                        var message = client.GetMessage(i);
                        var item = new ListViewItem(new[]
                        {
                            message.Subject,
                            message.From.ToString(),
                            message.Date.ToString()
                        });
                        listViewMess.Items.Add(item);
                    }

                    client.Disconnect(true);

                    MessageBox.Show("POP3 collected messages successfully!", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
