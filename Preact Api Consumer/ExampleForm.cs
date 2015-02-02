using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Preact_Api_Consumer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Log Event
        
        private void btnLogEvent_Click(object sender, EventArgs e)
        {
            CreateLogEvent();
        }

        private void CreateLogEvent()
        {
            outputTextbox.AppendText("Logging event\n");
            Preact.Api api = new Preact.Api(codeTextbox.Text, secretTextbox.Text);
            try
            {
                Preact.ActionEventCreateRequest request = new Preact.ActionEventCreateRequest()
                    {
                        Account = new Preact.Account()
                        {
                            Name = accountNameTextbox.Text,
                            Id = accountIdTextbox.Text,
                            LicenseType = "paying",
                            LicenseRenewal = DateTime.UtcNow
                        },
                        Event = new Preact.ActionEvent()
                        {
                            Name = eventNameTextbox.Text,
                            Revenue = 99
                        },
                        Person = new Preact.Person()
                        {
                            Email = emailTextbox.Text,
                            Name = personNameTextbox.Text,
                            Uid = uidTextbox.Text,
                            CreatedAt = DateTime.Now,
                            Properties = new Dictionary<string, object>() 
                                {
                                   {"created_at", (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds},
                                   {"is_paying", true},
                                   {"account_level", 2},
                                   {"account_level_name", "Pro"}
                                }
                        }
                    };
                outputTextbox.AppendText(JsonConvert.SerializeObject(request,Formatting.Indented) + "\n");
                api.LogEvent(request);
            }
            catch (Exception ex)
            {
                outputTextbox.AppendText("Log failure:" + ex.Message);
                outputTextbox.AppendText(ex.StackTrace);
            }
        }

        #endregion

        private void btnLogBackgroundSignal_Click(object sender, EventArgs e)
        {
            outputTextbox.AppendText("Logging signal\n");
            Preact.Api api = new Preact.Api(codeTextbox.Text, secretTextbox.Text);

            try {
                Preact.BackgroundSignalRequest request = new Preact.BackgroundSignalRequest()
                    {
                        AccountId = accountIdTextbox.Text,
                        Name = signalNameTextbox.Text,
                        Value = int.Parse(signalValueTextbox.Text),
                        Timestamp = (DateTime.UtcNow - new DateTime(1970, new Random().Next(1, 3), new Random().Next(1, 30))).TotalSeconds
                    };
                outputTextbox.AppendText(JsonConvert.SerializeObject(request, Formatting.Indented) + "\n");
                api.LogBackgroundSignal(request);
            } 
            catch (Exception ex)
            {
                outputTextbox.AppendText("Log failure:" + ex.Message);
                outputTextbox.AppendText(ex.StackTrace);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
