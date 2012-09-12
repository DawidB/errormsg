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
    internal class ReportHelper
    {
        #region Fields
        static bool _blinkState = true;
        #endregion

        #region Public custom methods
        /// <summary>
        /// Method used to control blinking state of given LinkLabel control.
        /// </summary>
        /// <param name="linkLabel"></param>
        public static void ControlLinkLabelBlinking(ref LinkLabel linkLabel)
        {
            Color _linkColor = linkLabel.LinkColor; //input color (before change)
            byte _incrementValue = 15; //by how many steps should color component change

            if (_linkColor.R == 0)
                _blinkState = true;
            else if (_linkColor.R == 255)
                _blinkState = false;

            if (_blinkState)
            {
                linkLabel.LinkColor = Color.FromArgb(
                    _linkColor.R + _incrementValue,
                    _linkColor.G,
                    _linkColor.B - _incrementValue);
            }
            else
            {
                linkLabel.LinkColor = Color.FromArgb(
                    _linkColor.R - _incrementValue,
                    _linkColor.G,
                    _linkColor.B + _incrementValue);
            }
        }

        /// <summary>
        /// Method used to format report and copy it to clipboard.
        /// </summary>
        /// <param name="emailRecipient"></param>
        /// <param name="emailSubject"></param>
        /// <param name="emailBody"></param>
        public static void CopyToClipboard(string emailRecipient, string emailSubject, string emailBody)
        {
            Clipboard.Clear();

            StringBuilder _sb = new StringBuilder("");

            _sb.Append("Temat raportu: ");
            _sb.AppendLine(ErrorMsg.EmailSubject);
            _sb.AppendLine();
            _sb.AppendLine("----------------------------------------------------------------");
            _sb.AppendLine();

            _sb.Append("Adresat: ");
            _sb.AppendLine(ErrorMsg.EmailRecipient);
            _sb.AppendLine();
            _sb.AppendLine("----------------------------------------------------------------");
            _sb.AppendLine();

            _sb.AppendLine("Treść raportu: ");
            _sb.AppendLine();
            foreach (string _line in ErrorMsg.ErrorDetails.Split(Environment.NewLine.ToCharArray()))
                _sb.AppendLine(_line);
            _sb.AppendLine();
            _sb.Append("----------------------------------------------------------------");

            Clipboard.SetText(_sb.ToString());
        }

        /// <summary>
        /// Method used to form an email and open it with default email client.
        /// </summary>
        /// <param name="emailRecipient"></param>
        /// <param name="emailSubject"></param>
        /// <param name="emailBody"></param>
        public static void CreateAndOpenEmail(string emailRecipient, string emailSubject, string emailBody)
        {
            //create email
            StringBuilder _sb = new StringBuilder("mailto:<AdresEmail>?subject=<Temat>&body=Komunikat:%0D%0A----------------START----------------%0D%0A<Komunikat>%0D%0A----------------STOP-----------------");

            _sb.Replace("<AdresEmail>", emailRecipient);

            //form e-mail subject text
            ConvertWhitespacesToHtml(ref emailSubject);
            _sb.Replace("<Temat>", emailSubject);

            //form e-mail body text
            ConvertWhitespacesToHtml(ref emailBody);
            ReplaceText(ref emailBody, "%0D%0A", "%0D%0A%20%20%20");
            _sb.Replace("<Komunikat>", emailBody);

            //open email with default client
            System.Diagnostics.Process.Start(_sb.ToString());
        }
        #endregion

        #region Private custom methods
        /// <summary>
        /// Converts whitespaces in text to HTML format using StringBuilder.
        /// </summary>
        /// <param name="stringToConvert">Referenced string to convert</param>
        private static void ConvertWhitespacesToHtml(ref string stringToConvert)
        {
            StringBuilder _sb = new StringBuilder(stringToConvert);

            _sb.Replace(" ", "%20");
            _sb.Replace(Environment.NewLine, "%0D%0A");
            _sb.Replace("\n", "%0D%0A");

            stringToConvert = _sb.ToString();
        }

        /// <summary>
        /// Replaces given string using StringBuilder.
        /// </summary>
        /// <param name="stringToConvert">Referenced string to convert</param>
        /// <param name="stringToReplace"></param>
        /// <param name="replacedString"></param>
        private static void ReplaceText(ref string stringToConvert, string stringToReplace, string replacedString)
        {
            StringBuilder _sb = new StringBuilder(stringToConvert);

            _sb.Replace(stringToReplace, replacedString);

            stringToConvert = _sb.ToString();
        }
        #endregion
    }
}
