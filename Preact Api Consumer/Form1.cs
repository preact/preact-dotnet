using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            Preact.Api api = new Preact.Api(Properties.Settings.Default.ProjectCode,
                                            Properties.Settings.Default.SecretKey);
            api.LogEvent(
                new Preact.ActionEventCreateRequest()
                {
                    Event = new Preact.ActionEvent()
                    {
                        Name = "registered",
                        Note = "iPhone",
                        Revenue = 99
                    },
                    Person = new Preact.Person()
                    {
                        Email = "terence.joubert@techida.biz",
                        Name = "Terence Joubert",
                        Uid = Guid.NewGuid().ToString(),
                        CreatedAt = DateTime.Now,
                        Properties = new Dictionary<string, object>() 
                        {
                           {"created_at", (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds},
                           {"is_paying", true},
                           {"account_level", 2},
                           {"account_level_name", "Pro"}
                        }
                    }
                }
            );
        }

        #endregion

        private void btnLogBackgroundSignal_Click(object sender, EventArgs e)
        {
            Preact.Api api = new Preact.Api(Properties.Settings.Default.ProjectCode,
                                            Properties.Settings.Default.SecretKey);
            api.LogBackgroundSignal(
                       new Preact.BackgroundSignalRequest()
                       {
                           AccountId = "593929",
                           Name = "emails-sent",
                           Value = 500
                       });

         //   MessageBox.Show(res);
        }

    }
}
