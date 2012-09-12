using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DawidBurek.ErrorMsg
{
    public enum ErrorMsgIcon { Information, Question, Critical, Exclamation, Stop }

    public static class ErrorMsg
    {
        #region Fields
        //if 3 variables below are not set, default values 
        //are assigned to then in FormErrorMessage constructor.
        public static string ErrorDetails = "";
        public static string EmailRecipient = "";
        public static string EmailSubject = "";
        #endregion

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <returns></returns>
        public static DialogResult Show()
        {
            FormErrorMessage _form = new FormErrorMessage();

            return _form.ShowDialog();
        }

        /// <summary>
        /// Constructor with message text as parameter.
        /// </summary>
        /// <param name="message">Message text to show and copy to clipboard/send as an e-mail</param>
        /// <returns></returns>
        public static DialogResult Show(string message)
        {
            FormErrorMessage _form = new FormErrorMessage();

            _form.LabelMessage.Text = message;
            return _form.ShowDialog();
        }

        /// <summary>
        /// Constructor with window title and message text as parameters.
        /// </summary>
        /// <param name="message">Message text to show and copy to clipboard/send as an e-mail</param>
        /// <param name="title">Window title</param>
        /// <returns></returns>
        public static DialogResult Show(string message, string title)
        {
            FormErrorMessage _form = new FormErrorMessage();

            _form.LabelMessage.Text = message;
            _form.Text = title;

            return _form.ShowDialog();
        }

        /// <summary>
        /// Constructor with window title, message text and icon type as parameters.
        /// </summary>
        /// <param name="message">Message text to show and copy to clipboard/send as an e-mail</param>
        /// <param name="title">Window title</param>
        /// <param name="iconType">Icon type</param>
        /// <returns></returns>
        public static DialogResult Show(string message, string title, ErrorMsgIcon iconType)
        {
            FormErrorMessage _form = new FormErrorMessage();

            _form.LabelMessage.Text = message;
            _form.Text = title;
            _form.SetIcon(iconType);

            return _form.ShowDialog();
        }

        /// <summary>
        /// Constructor with window title, message text, icon type and error details as parameters.
        /// </summary>
        /// <param name="message">Message text - shown on dialogbox and copied to clipboard/sent as an e-mail</param>
        /// <param name="title">Window title</param>
        /// <param name="iconType">Icon type</param>
        /// <param name="errorDetails">Error details - copied to clipboard/sent as an e-mail</param>
        /// <returns></returns>
        public static DialogResult Show(string message, string title, ErrorMsgIcon iconType, string errorDetails)
        {
            FormErrorMessage _form = new FormErrorMessage();

            _form.LabelMessage.Text = message;
            _form.Text = title;
            _form.SetIcon(iconType);
            ErrorDetails = errorDetails;
            _form.LLReport.Visible = true;

            return _form.ShowDialog();
        }    
    }
}
