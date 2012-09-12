namespace DawidBurek.ErrorMsg
{
    partial class FormErrorMessage
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
            this.components = new System.ComponentModel.Container();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.TLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LLReport = new System.Windows.Forms.LinkLabel();
            this.CMSReport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMIReportSend = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIReportToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerReport = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.TLPMain.SuspendLayout();
            this.CMSReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBIcon
            // 
            this.PBIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PBIcon.ErrorImage = null;
            this.PBIcon.InitialImage = null;
            this.PBIcon.Location = new System.Drawing.Point(12, 13);
            this.PBIcon.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.PBIcon.MaximumSize = new System.Drawing.Size(48, 48);
            this.PBIcon.MinimumSize = new System.Drawing.Size(48, 48);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(48, 48);
            this.PBIcon.TabIndex = 0;
            this.PBIcon.TabStop = false;
            this.PBIcon.Visible = false;
            // 
            // TLPMain
            // 
            this.TLPMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TLPMain.AutoScroll = true;
            this.TLPMain.BackColor = System.Drawing.SystemColors.Window;
            this.TLPMain.ColumnCount = 2;
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMain.Controls.Add(this.PBIcon, 0, 0);
            this.TLPMain.Controls.Add(this.LabelMessage, 1, 0);
            this.TLPMain.Location = new System.Drawing.Point(0, 0);
            this.TLPMain.Name = "TLPMain";
            this.TLPMain.RowCount = 1;
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMain.Size = new System.Drawing.Size(294, 75);
            this.TLPMain.TabIndex = 3;
            // 
            // LabelMessage
            // 
            this.LabelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelMessage.Location = new System.Drawing.Point(69, 20);
            this.LabelMessage.Margin = new System.Windows.Forms.Padding(9, 20, 6, 20);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(219, 35);
            this.LabelMessage.TabIndex = 5;
            this.LabelMessage.Text = "W aplikacji wystąpił nieoczekiwany wyjątek. Szczegóły problemu znajdują się w rap" +
                "orcie.";
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnOK.Location = new System.Drawing.Point(110, 87);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // LLReport
            // 
            this.LLReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LLReport.AutoSize = true;
            this.LLReport.ContextMenuStrip = this.CMSReport;
            this.LLReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LLReport.Location = new System.Drawing.Point(9, 92);
            this.LLReport.Margin = new System.Windows.Forms.Padding(3);
            this.LLReport.Name = "LLReport";
            this.LLReport.Size = new System.Drawing.Size(45, 13);
            this.LLReport.TabIndex = 5;
            this.LLReport.TabStop = true;
            this.LLReport.Text = "Raport";
            this.LLReport.Visible = false;
            this.LLReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLReport_LinkClicked);
            // 
            // CMSReport
            // 
            this.CMSReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIReportSend,
            this.TSMIReportToClipboard});
            this.CMSReport.Name = "CMSReport";
            this.CMSReport.Size = new System.Drawing.Size(217, 48);
            // 
            // TSMIReportSend
            // 
            this.TSMIReportSend.Image = global::DawidBurek.ErrorMsg.Properties.Resources.Ico_SendMail;
            this.TSMIReportSend.Name = "TSMIReportSend";
            this.TSMIReportSend.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.TSMIReportSend.Size = new System.Drawing.Size(216, 22);
            this.TSMIReportSend.Text = "Wyślij e-mail";
            this.TSMIReportSend.Click += new System.EventHandler(this.TSMIReportSend_Click);
            // 
            // TSMIReportToClipboard
            // 
            this.TSMIReportToClipboard.Image = global::DawidBurek.ErrorMsg.Properties.Resources.Ico_clipboard;
            this.TSMIReportToClipboard.Name = "TSMIReportToClipboard";
            this.TSMIReportToClipboard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.TSMIReportToClipboard.Size = new System.Drawing.Size(216, 22);
            this.TSMIReportToClipboard.Text = "Kopiuj do schowka";
            this.TSMIReportToClipboard.Click += new System.EventHandler(this.TSMIReportToClipboard_Click);
            // 
            // TimerReport
            // 
            this.TimerReport.Enabled = true;
            this.TimerReport.Interval = 10;
            this.TimerReport.Tick += new System.EventHandler(this.TimerReport_Tick);
            // 
            // FormErrorMessage
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnOK;
            this.ClientSize = new System.Drawing.Size(294, 122);
            this.Controls.Add(this.LLReport);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TLPMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(230, 110);
            this.Name = "FormErrorMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komunikat";
            this.Load += new System.EventHandler(this.FormErrorMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.TLPMain.ResumeLayout(false);
            this.CMSReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPMain;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.ContextMenuStrip CMSReport;
        private System.Windows.Forms.ToolStripMenuItem TSMIReportSend;
        private System.Windows.Forms.ToolStripMenuItem TSMIReportToClipboard;
        internal System.Windows.Forms.PictureBox PBIcon;
        internal System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Timer TimerReport;
        internal System.Windows.Forms.LinkLabel LLReport;
    }
}