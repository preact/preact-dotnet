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
            this.SuspendLayout();
            // 
            // btnLogEvent
            // 
            this.btnLogEvent.Location = new System.Drawing.Point(29, 29);
            this.btnLogEvent.Name = "btnLogEvent";
            this.btnLogEvent.Size = new System.Drawing.Size(85, 63);
            this.btnLogEvent.TabIndex = 0;
            this.btnLogEvent.Text = "Log Event";
            this.btnLogEvent.UseVisualStyleBackColor = true;
            this.btnLogEvent.Click += new System.EventHandler(this.btnLogEvent_Click);
            // 
            // btnLogBackgroundSignal
            // 
            this.btnLogBackgroundSignal.Location = new System.Drawing.Point(29, 128);
            this.btnLogBackgroundSignal.Name = "btnLogBackgroundSignal";
            this.btnLogBackgroundSignal.Size = new System.Drawing.Size(85, 63);
            this.btnLogBackgroundSignal.TabIndex = 1;
            this.btnLogBackgroundSignal.Text = "Log Background Signal";
            this.btnLogBackgroundSignal.UseVisualStyleBackColor = true;
            this.btnLogBackgroundSignal.Click += new System.EventHandler(this.btnLogBackgroundSignal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnLogBackgroundSignal);
            this.Controls.Add(this.btnLogEvent);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogEvent;
        private System.Windows.Forms.Button btnLogBackgroundSignal;
    }
}

