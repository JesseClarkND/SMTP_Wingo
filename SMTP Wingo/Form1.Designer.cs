namespace SMTP_Wingo
{
    partial class Form1
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
            this.AddButt = new System.Windows.Forms.Button();
            this.DelButt = new System.Windows.Forms.Button();
            this.StartButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerList = new System.Windows.Forms.ListBox();
            this.ServerNameTB = new System.Windows.Forms.TextBox();
            this.SenderEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceiverEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.checkBoxServer = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.PortCycleCB = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portCycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PassedTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProgBar = new System.Windows.Forms.ProgressBar();
            this.LogsButt = new System.Windows.Forms.Button();
            this.abountWingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButt
            // 
            this.AddButt.Location = new System.Drawing.Point(295, 42);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(128, 23);
            this.AddButt.TabIndex = 0;
            this.AddButt.Text = "Add Server to List ->";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // DelButt
            // 
            this.DelButt.Location = new System.Drawing.Point(429, 402);
            this.DelButt.Name = "DelButt";
            this.DelButt.Size = new System.Drawing.Size(128, 23);
            this.DelButt.TabIndex = 1;
            this.DelButt.Text = "Delete Server from List";
            this.DelButt.UseVisualStyleBackColor = true;
            this.DelButt.Click += new System.EventHandler(this.DelButt_Click);
            // 
            // StartButt
            // 
            this.StartButt.Location = new System.Drawing.Point(17, 172);
            this.StartButt.Name = "StartButt";
            this.StartButt.Size = new System.Drawing.Size(103, 46);
            this.StartButt.TabIndex = 2;
            this.StartButt.Text = "Start";
            this.StartButt.UseVisualStyleBackColor = true;
            this.StartButt.Click += new System.EventHandler(this.StartButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SMTP Server name:";
            // 
            // ServerList
            // 
            this.ServerList.FormattingEnabled = true;
            this.ServerList.Location = new System.Drawing.Point(429, 44);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(128, 355);
            this.ServerList.TabIndex = 4;
            // 
            // ServerNameTB
            // 
            this.ServerNameTB.Location = new System.Drawing.Point(117, 44);
            this.ServerNameTB.Name = "ServerNameTB";
            this.ServerNameTB.Size = new System.Drawing.Size(172, 20);
            this.ServerNameTB.TabIndex = 5;
            // 
            // SenderEmail
            // 
            this.SenderEmail.Location = new System.Drawing.Point(121, 73);
            this.SenderEmail.Name = "SenderEmail";
            this.SenderEmail.Size = new System.Drawing.Size(163, 20);
            this.SenderEmail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sender Email Addy:";
            // 
            // ReceiverEmail
            // 
            this.ReceiverEmail.Location = new System.Drawing.Point(121, 108);
            this.ReceiverEmail.Name = "ReceiverEmail";
            this.ReceiverEmail.Size = new System.Drawing.Size(163, 20);
            this.ReceiverEmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Receiver Email Addy:";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 402);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(393, 69);
            this.TextBox.TabIndex = 10;
            this.TextBox.Text = "";
            // 
            // checkBoxServer
            // 
            this.checkBoxServer.AutoSize = true;
            this.checkBoxServer.Location = new System.Drawing.Point(265, 149);
            this.checkBoxServer.Name = "checkBoxServer";
            this.checkBoxServer.Size = new System.Drawing.Size(123, 17);
            this.checkBoxServer.TabIndex = 11;
            this.checkBoxServer.Text = "Cycle thru all servers";
            this.checkBoxServer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Port to use:";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(355, 112);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(33, 20);
            this.PortTextBox.TabIndex = 13;
            // 
            // PortCycleCB
            // 
            this.PortCycleCB.AutoSize = true;
            this.PortCycleCB.Location = new System.Drawing.Point(265, 172);
            this.PortCycleCB.Name = "PortCycleCB";
            this.PortCycleCB.Size = new System.Drawing.Size(156, 17);
            this.PortCycleCB.TabIndex = 14;
            this.PortCycleCB.Text = "Cycle Common SMTP Ports";
            this.PortCycleCB.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wingoToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wingoToolStripMenuItem
            // 
            this.wingoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.wingoToolStripMenuItem.Name = "wingoToolStripMenuItem";
            this.wingoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.wingoToolStripMenuItem.Text = "Wingo";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portCycleToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // portCycleToolStripMenuItem
            // 
            this.portCycleToolStripMenuItem.Name = "portCycleToolStripMenuItem";
            this.portCycleToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.portCycleToolStripMenuItem.Text = "Port Cycle";
            this.portCycleToolStripMenuItem.Click += new System.EventHandler(this.portCycleToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abountWingoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // PassedTextBox
            // 
            this.PassedTextBox.Location = new System.Drawing.Point(12, 298);
            this.PassedTextBox.Name = "PassedTextBox";
            this.PassedTextBox.Size = new System.Drawing.Size(393, 74);
            this.PassedTextBox.TabIndex = 16;
            this.PassedTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Passed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Failed:";
            // 
            // ProgBar
            // 
            this.ProgBar.Location = new System.Drawing.Point(12, 478);
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.Size = new System.Drawing.Size(545, 16);
            this.ProgBar.TabIndex = 19;
            // 
            // LogsButt
            // 
            this.LogsButt.Location = new System.Drawing.Point(339, 376);
            this.LogsButt.Name = "LogsButt";
            this.LogsButt.Size = new System.Drawing.Size(66, 23);
            this.LogsButt.TabIndex = 20;
            this.LogsButt.Text = "Clear logs";
            this.LogsButt.UseVisualStyleBackColor = true;
            this.LogsButt.Click += new System.EventHandler(this.LogsButt_Click);
            // 
            // abountWingoToolStripMenuItem
            // 
            this.abountWingoToolStripMenuItem.Name = "abountWingoToolStripMenuItem";
            this.abountWingoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abountWingoToolStripMenuItem.Text = "About Wingo";
            this.abountWingoToolStripMenuItem.Click += new System.EventHandler(this.abountWingoToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 497);
            this.Controls.Add(this.LogsButt);
            this.Controls.Add(this.ProgBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassedTextBox);
            this.Controls.Add(this.PortCycleCB);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxServer);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ReceiverEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SenderEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerNameTB);
            this.Controls.Add(this.ServerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButt);
            this.Controls.Add(this.DelButt);
            this.Controls.Add(this.AddButt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SMTP Wingo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Button DelButt;
        private System.Windows.Forms.Button StartButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ServerList;
        private System.Windows.Forms.TextBox ServerNameTB;
        private System.Windows.Forms.TextBox SenderEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReceiverEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.CheckBox checkBoxServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.CheckBox PortCycleCB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wingoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portCycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox PassedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar ProgBar;
        private System.Windows.Forms.Button LogsButt;
        private System.Windows.Forms.ToolStripMenuItem abountWingoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
    }
}

