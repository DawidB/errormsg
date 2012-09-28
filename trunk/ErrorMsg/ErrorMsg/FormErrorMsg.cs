using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DawidBurek.ErrorMsg
{
    internal partial class FormErrorMessage : Form
    {
        #region Public methods
        public void SetIcon(ErrorMsgIcon iconType)
        {
            PBIcon.Show();

            switch (iconType)
            {
                case ErrorMsgIcon.Critical:
                    PBIcon.Image = Properties.Resources.Ico_Error;
                    break;
                case ErrorMsgIcon.Exclamation:
                    PBIcon.Image = Properties.Resources.Ico_Exclamation;
                    break;
                case ErrorMsgIcon.Information:
                    PBIcon.Image = Properties.Resources.Ico_Information;
                    break;
                case ErrorMsgIcon.Question:
                    PBIcon.Image = Properties.Resources.Ico_Question;
                    break;
                case ErrorMsgIcon.Stop:
                    PBIcon.Image = Properties.Resources.Ico_Stop;
                    break;
            }
        }
        #endregion

        #region Form/controls methods
        public FormErrorMessage()
        {
            InitializeComponent();

            //ErrorMsg.ErrorDetails = "";
            //ErrorMsg.EmailRecipient = "";
            //ErrorMsg.EmailSubject = "";

            LabelMessage.Text = "W aplikacji wystąpił nieoczekiwany wyjątek.\nSzczegóły problemu znajdują się w raporcie.";
        }

        private void LLReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LLReport.ContextMenuStrip.Show(LLReport, new Point(0, LLReport.Height));
        }

        private void TimerReport_Tick(object sender, EventArgs e)
        {
            ReportHelper.ControlLinkLabelBlinking(ref LLReport);
        }

        private void TSMIReportSend_Click(object sender, EventArgs e)
        {
            ReportHelper.CreateAndOpenEmail(
                ErrorMsg.EmailRecipient,
                ErrorMsg.EmailSubject,
                ErrorMsg.ErrorDetails);
        }

        private void TSMIReportToClipboard_Click(object sender, EventArgs e)
        {
            ReportHelper.CopyToClipboard(
                ErrorMsg.EmailRecipient,
                ErrorMsg.EmailSubject,
                ErrorMsg.ErrorDetails);
        }
        #endregion

        private void FormErrorMessage_Load(object sender, EventArgs e)
        {
            if (ErrorMsg.ErrorDetails == string.Empty)
                ErrorMsg.ErrorDetails = "Brak szczegółowych informacji";
            if (ErrorMsg.EmailRecipient == string.Empty)
                ErrorMsg.EmailRecipient = "dawid.burek@gmail.com";
            if (ErrorMsg.EmailSubject == string.Empty)
                ErrorMsg.EmailSubject = "Wyjątek w aplikacji";

            using (Graphics _gfx = CreateGraphics())
            {
                int _heightOffset = this.ClientSize.Height - TLPMain.Height,
                    _widthOffset = LabelMessage.Margin.Horizontal;
                SizeF _textSize = _gfx.MeasureString(LabelMessage.Text, LabelMessage.Font, 400);

                if (PBIcon.Visible)
                {
                    _widthOffset = PBIcon.Width + PBIcon.Margin.Horizontal;
                    //if (PBIcon.Height + PBIcon.Margin.Vertical < _textSize.Height)
                        _heightOffset += PBIcon.Height + PBIcon.Margin.Vertical;
                }
                else
                    _heightOffset += LabelMessage.Margin.Vertical;

                this.ClientSize = new Size(
                    (int)Math.Ceiling(_textSize.Width) + _widthOffset,
                    (int)Math.Ceiling(_textSize.Height) + _heightOffset);

            }
        }
    }
}
