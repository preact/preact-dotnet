namespace Preact_Api_Consumer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogEvent = new System.Windows.Forms.Button();
            this.btnLogBackgroundSignal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.personNameTextbox = new System.Windows.Forms.TextBox();
            this.uidTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.accountNameTextbox = new System.Windows.Forms.TextBox();
            this.accountIdTextbox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.eventNameTextbox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.signalValueTextbox = new System.Windows.Forms.TextBox();
            this.signalNameTextbox = new System.Windows.Forms.TextBox();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.secretTextbox = new System.Windows.Forms.TextBox();
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogEvent
            // 
            this.btnLogEvent.Location = new System.Drawing.Point(151, 69);
            this.btnLogEvent.Name = "btnLogEvent";
            this.btnLogEvent.Size = new System.Drawing.Size(103, 25);
            this.btnLogEvent.TabIndex = 0;
            this.btnLogEvent.Text = "Log Event";
            this.btnLogEvent.UseVisualStyleBackColor = true;
            this.btnLogEvent.Click += new System.EventHandler(this.btnLogEvent_Click);
            // 
            // btnLogBackgroundSignal
            // 
            this.btnLogBackgroundSignal.Location = new System.Drawing.Point(165, 69);
            this.btnLogBackgroundSignal.Name = "btnLogBackgroundSignal";
            this.btnLogBackgroundSignal.Size = new System.Drawing.Size(89, 26);
            this.btnLogBackgroundSignal.TabIndex = 1;
            this.btnLogBackgroundSignal.Text = "Log Signal";
            this.btnLogBackgroundSignal.UseVisualStyleBackColor = true;
            this.btnLogBackgroundSignal.Click += new System.EventHandler(this.btnLogBackgroundSignal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secretTextbox);
            this.groupBox1.Controls.Add(this.codeTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.personNameTextbox);
            this.groupBox2.Controls.Add(this.uidTextbox);
            this.groupBox2.Controls.Add(this.emailTextbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 69);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person";
            // 
            // personNameTextbox
            // 
            this.personNameTextbox.Location = new System.Drawing.Point(353, 31);
            this.personNameTextbox.Name = "personNameTextbox";
            this.personNameTextbox.Size = new System.Drawing.Size(159, 21);
            this.personNameTextbox.TabIndex = 2;
            this.personNameTextbox.Text = "Boba Fett";
            // 
            // uidTextbox
            // 
            this.uidTextbox.Location = new System.Drawing.Point(188, 31);
            this.uidTextbox.Name = "uidTextbox";
            this.uidTextbox.Size = new System.Drawing.Size(159, 21);
            this.uidTextbox.TabIndex = 1;
            this.uidTextbox.Text = "B28A950EF92B";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(23, 31);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(159, 21);
            this.emailTextbox.TabIndex = 0;
            this.emailTextbox.Text = "bountyhunter@mandalorian.io";
            this.emailTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.accountNameTextbox);
            this.groupBox3.Controls.Add(this.accountIdTextbox);
            this.groupBox3.Location = new System.Drawing.Point(12, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 69);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account";
            // 
            // accountNameTextbox
            // 
            this.accountNameTextbox.Location = new System.Drawing.Point(188, 30);
            this.accountNameTextbox.Name = "accountNameTextbox";
            this.accountNameTextbox.Size = new System.Drawing.Size(159, 21);
            this.accountNameTextbox.TabIndex = 1;
            this.accountNameTextbox.Text = "Corner Coffee Shop";
            // 
            // accountIdTextbox
            // 
            this.accountIdTextbox.Location = new System.Drawing.Point(23, 30);
            this.accountIdTextbox.Name = "accountIdTextbox";
            this.accountIdTextbox.Size = new System.Drawing.Size(159, 21);
            this.accountIdTextbox.TabIndex = 0;
            this.accountIdTextbox.Text = "54321";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.eventNameTextbox);
            this.groupBox4.Controls.Add(this.btnLogEvent);
            this.groupBox4.Location = new System.Drawing.Point(12, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Events";
            // 
            // eventNameTextbox
            // 
            this.eventNameTextbox.Location = new System.Drawing.Point(23, 32);
            this.eventNameTextbox.Name = "eventNameTextbox";
            this.eventNameTextbox.Size = new System.Drawing.Size(159, 21);
            this.eventNameTextbox.TabIndex = 1;
            this.eventNameTextbox.Text = "logged-in";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.signalValueTextbox);
            this.groupBox5.Controls.Add(this.signalNameTextbox);
            this.groupBox5.Controls.Add(this.btnLogBackgroundSignal);
            this.groupBox5.Location = new System.Drawing.Point(287, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(260, 101);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Background Signals";
            // 
            // signalValueTextbox
            // 
            this.signalValueTextbox.Location = new System.Drawing.Point(171, 32);
            this.signalValueTextbox.Name = "signalValueTextbox";
            this.signalValueTextbox.Size = new System.Drawing.Size(83, 21);
            this.signalValueTextbox.TabIndex = 3;
            this.signalValueTextbox.Text = "500";
            // 
            // signalNameTextbox
            // 
            this.signalNameTextbox.Location = new System.Drawing.Point(6, 32);
            this.signalNameTextbox.Name = "signalNameTextbox";
            this.signalNameTextbox.Size = new System.Drawing.Size(159, 21);
            this.signalNameTextbox.TabIndex = 2;
            this.signalNameTextbox.Text = "emails-sent";
            // 
            // outputTextbox
            // 
            this.outputTextbox.Location = new System.Drawing.Point(12, 346);
            this.outputTextbox.Multiline = true;
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextbox.Size = new System.Drawing.Size(534, 109);
            this.outputTextbox.TabIndex = 7;
            // 
            // secretTextbox
            // 
            this.secretTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Preact_Api_Consumer.Properties.Settings.Default, "SecretKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.secretTextbox.Location = new System.Drawing.Point(188, 29);
            this.secretTextbox.Name = "secretTextbox";
            this.secretTextbox.Size = new System.Drawing.Size(159, 21);
            this.secretTextbox.TabIndex = 1;
            this.secretTextbox.Text = global::Preact_Api_Consumer.Properties.Settings.Default.SecretKey;
            // 
            // codeTextbox
            // 
            this.codeTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Preact_Api_Consumer.Properties.Settings.Default, "ProjectCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.codeTextbox.Location = new System.Drawing.Point(23, 29);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(159, 21);
            this.codeTextbox.TabIndex = 0;
            this.codeTextbox.Text = global::Preact_Api_Consumer.Properties.Settings.Default.ProjectCode;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 461);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximumSize = new System.Drawing.Size(575, 500);
            this.MinimumSize = new System.Drawing.Size(575, 500);
            this.Name = "MainForm";
            this.Text = "Preact Logging Test Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogEvent;
        private System.Windows.Forms.Button btnLogBackgroundSignal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox secretTextbox;
        private System.Windows.Forms.TextBox codeTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox uidTextbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox personNameTextbox;
        private System.Windows.Forms.TextBox accountNameTextbox;
        private System.Windows.Forms.TextBox accountIdTextbox;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.TextBox eventNameTextbox;
        private System.Windows.Forms.TextBox signalNameTextbox;
        private System.Windows.Forms.TextBox signalValueTextbox;
    }
}

