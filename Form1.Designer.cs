namespace AppStopper17_0
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.stoppAppB = new System.Windows.Forms.Button();
            this.errorTB = new System.Windows.Forms.RichTextBox();
            this.stopProcB = new System.Windows.Forms.Button();
            this.servCB = new System.Windows.Forms.ComboBox();
            this.procCB = new System.Windows.Forms.ComboBox();
            this.updateB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // stoppAppB
            // 
            this.stoppAppB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stoppAppB.Location = new System.Drawing.Point(100, 45);
            this.stoppAppB.Name = "stoppAppB";
            this.stoppAppB.Size = new System.Drawing.Size(95, 48);
            this.stoppAppB.TabIndex = 1;
            this.stoppAppB.Text = "stop serv";
            this.stoppAppB.UseVisualStyleBackColor = false;
            this.stoppAppB.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorTB
            // 
            this.errorTB.Location = new System.Drawing.Point(13, 159);
            this.errorTB.Name = "errorTB";
            this.errorTB.Size = new System.Drawing.Size(285, 157);
            this.errorTB.TabIndex = 2;
            this.errorTB.Text = "";
            // 
            // stopProcB
            // 
            this.stopProcB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stopProcB.Location = new System.Drawing.Point(100, 99);
            this.stopProcB.Name = "stopProcB";
            this.stopProcB.Size = new System.Drawing.Size(95, 48);
            this.stopProcB.TabIndex = 6;
            this.stopProcB.Text = "stop proc";
            this.stopProcB.UseVisualStyleBackColor = false;
            this.stopProcB.Click += new System.EventHandler(this.stopProcB_Click);
            // 
            // servCB
            // 
            this.servCB.FormattingEnabled = true;
            this.servCB.Location = new System.Drawing.Point(201, 56);
            this.servCB.Name = "servCB";
            this.servCB.Size = new System.Drawing.Size(300, 28);
            this.servCB.TabIndex = 7;
            // 
            // procCB
            // 
            this.procCB.FormattingEnabled = true;
            this.procCB.Location = new System.Drawing.Point(201, 110);
            this.procCB.Name = "procCB";
            this.procCB.Size = new System.Drawing.Size(300, 28);
            this.procCB.TabIndex = 8;
            // 
            // updateB
            // 
            this.updateB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateB.Location = new System.Drawing.Point(406, 159);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(95, 48);
            this.updateB.TabIndex = 9;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 419);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.procCB);
            this.Controls.Add(this.servCB);
            this.Controls.Add(this.stopProcB);
            this.Controls.Add(this.errorTB);
            this.Controls.Add(this.stoppAppB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Stopper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button stoppAppB;
        private System.Windows.Forms.RichTextBox errorTB;
        private System.Windows.Forms.Button stopProcB;
        private System.Windows.Forms.ComboBox procCB;
        private System.Windows.Forms.ComboBox servCB;
        private System.Windows.Forms.Button updateB;
    }
}

