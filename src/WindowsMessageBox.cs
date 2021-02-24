using System;
using System.Windows;

namespace Atomus.Windows.MessageBox
{
    /// <summary>
    /// 사용자에게 메시지를 보여 주는 메시지 창을 표시합니다.이 창을 대화 상자라고도 합니다.이 창은 사용자가 닫을 때까지 응용 프로그램의 다른 동작을 차단하는 모달 창입니다.
    /// System.Windows.Forms.MessageBox에는 사용자에게 필요한 정보와 명령을 제공하는 텍스트, 단추 및 기호가 포함될 수 있습니다.
    /// System.Windows.Forms.MessageBox로 표시가 되도록 구현 되어 있습니다.
    /// </summary>
    public class WindowsMessageBox : IMessageBox
    {
        MessageBoxResult IMessageBox.Show(string text, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(text.Translate(args));

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(messageResult.Message.Translate(args));

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(text.Translate(args));
            }
        }
        MessageBoxResult IMessageBox.Show(string text, string caption, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(text.Translate(args), caption.Translate());

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate());

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(text.Translate(args), caption.Translate());
            }
        }
        MessageBoxResult IMessageBox.Show(string text, string caption, MessageBoxButton messageBoxButtons, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons);
            }
        }
        MessageBoxResult IMessageBox.Show(string text, string caption, MessageBoxButton messageBoxButtons, MessageBoxImage messageBoxIcon, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);
            }
        }
        MessageBoxResult IMessageBox.Show(string text, string caption, MessageBoxButton messageBoxButtons, MessageBoxImage messageBoxIcon, MessageBoxResult defaultResult, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult);
            }
        }
        MessageBoxResult IMessageBox.Show(string text, string caption, MessageBoxButton messageBoxButtons, MessageBoxImage messageBoxIcon, MessageBoxResult defaultResult, MessageBoxOptions messageBoxOptions, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult, messageBoxOptions);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult, messageBoxOptions);

                return ((IMessageBox)this).Show(messageResult.Message.Translate(args), messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult, messageBoxOptions);
            }
        }
        MessageBoxResult IMessageBox.Show(AtomusException exception)
        {
            return System.Windows.MessageBox.Show(exception.Message, exception.GetType().Name, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        MessageBoxResult IMessageBox.Show(Exception exception)
        {
            if (exception.InnerException != null)
                return System.Windows.MessageBox.Show(exception.InnerException.Message, exception.InnerException.GetType().Name, MessageBoxButton.OK, MessageBoxImage.Error);
            else
                return System.Windows.MessageBox.Show(exception.Message, exception.GetType().Name, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        
        MessageBoxResult IMessageBox.Show(Window owner, string text, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(owner, text.Translate(args));

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(owner, messageResult.Message.Translate(args));

                return ((IMessageBox)this).Show(owner, messageResult.Message, messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(owner, text.Translate(args));
            }
        }
        MessageBoxResult IMessageBox.Show(Window owner, string text, string caption, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(owner, text.Translate(args), caption.Translate());

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(owner, messageResult.Message.Translate(args), caption.Translate());

                return ((IMessageBox)this).Show(owner, messageResult.Message, messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(owner, text.Translate(args), caption.Translate());
            }
        }
        MessageBoxResult IMessageBox.Show(Window owner, string text, string caption, MessageBoxButton messageBoxButtons, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(owner, text.Translate(args), caption.Translate(), messageBoxButtons);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons);

                return ((IMessageBox)this).Show(owner, messageResult.Message, messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(owner, text.Translate(args), caption.Translate(), messageBoxButtons);
            }
        }
        MessageBoxResult IMessageBox.Show(Window owner, string text, string caption, MessageBoxButton messageBoxButtons, MessageBoxImage messageBoxIcon, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);

                return ((IMessageBox)this).Show(owner, messageResult.Message, messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon);
            }
        }
        MessageBoxResult IMessageBox.Show(Window owner, string text, string caption, MessageBoxButton messageBoxButtons, MessageBoxImage messageBoxIcon, MessageBoxResult defaultResult, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult);

                return ((IMessageBox)this).Show(owner, messageResult.Message, messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult);
            }
        }
        MessageBoxResult IMessageBox.Show(Window owner, string text, string caption, MessageBoxButton messageBoxButtons, MessageBoxImage messageBoxIcon, MessageBoxResult defaultResult, MessageBoxOptions messageBoxOptions, params string[] args)
        {
            Message.MessageResult messageResult;

            try
            {
                messageResult = this.GetMessage(text);

                if (messageResult == null )
                    return System.Windows.MessageBox.Show(owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult, messageBoxOptions);

                if (text.Contains("^"))
                    args = text.Substring(text.IndexOf('^') + 1).Split('^');

                if (!messageResult.Result)
                    return System.Windows.MessageBox.Show(owner, messageResult.Message.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult, messageBoxOptions);

                return ((IMessageBox)this).Show(owner, messageResult.Message, messageResult.Title, this.MessageBoxButtonConvert(messageResult.MessageBoxButtons), this.MessageBoxIconConvert(messageResult.MessageBoxIcon), args);
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return System.Windows.MessageBox.Show(owner, text.Translate(args), caption.Translate(), messageBoxButtons, messageBoxIcon, defaultResult, messageBoxOptions);
            }
        }
        MessageBoxResult IMessageBox.Show(Window owner, AtomusException exception)
        {
            return System.Windows.MessageBox.Show(owner, exception.Message, exception.GetType().Name, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        MessageBoxResult IMessageBox.Show(Window owner, Exception exception)
        {
            if (exception.InnerException != null)
                return System.Windows.MessageBox.Show(owner, exception.InnerException.Message, exception.InnerException.GetType().Name, MessageBoxButton.OK, MessageBoxImage.Error);
            else
                return System.Windows.MessageBox.Show(owner, exception.Message, exception.GetType().Name, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        Message.MessageResult GetMessage(string text)
        {
            try
            {
                string[] temps;
                Message.MessageResult messageResult;

                if (!text.Contains("-"))
                    return null;

                temps = text.Split('-');

                if (temps.Length < 2)
                    return null;

                if (temps[1].Length < 5)
                    return null;

                try
                {
                    if (temps[1].Length == 5 || temps[1].Substring(5, 1) != " ")
                        messageResult = ((Message.IMessageSource)this.CreateInstance("MessageSource")).GetMessage(temps[0], temps[1].Substring(0, 5), text);
                    else
                        messageResult = ((Message.IMessageSource)this.CreateInstance("MessageSource")).GetMessage(temps[0], temps[1].Substring(0, 5), text.Substring(temps[0].Length + 7));
                }
                catch (Exception ex)
                {
                    Diagnostics.DiagnosticsTool.MyTrace(ex);

                    messageResult = new Message.MessageResult();
                    if (temps[1].Length == 5 || temps[1].Substring(5, 1) != " ")
                        messageResult.Message = text;
                    else
                        messageResult.Message = text.Substring(temps[0].Length + 7);
                }

                if (messageResult.Message.Contains("^"))
                    messageResult.Message = messageResult.Message.Substring(0, messageResult.Message.IndexOf('^'));

                return messageResult;
            }
            catch (Exception ex)
            {
                Diagnostics.DiagnosticsTool.MyTrace(ex);
                return null;
            }
        }

        private MessageBoxButton MessageBoxButtonConvert(System.Windows.Forms.MessageBoxButtons messageBoxButtons)
        {
            switch (messageBoxButtons)
            {
                case System.Windows.Forms.MessageBoxButtons.AbortRetryIgnore:
                    throw new AtomusException("AbortRetryIgnore Not Support.");
                case System.Windows.Forms.MessageBoxButtons.OK:
                    return MessageBoxButton.OK;
                case System.Windows.Forms.MessageBoxButtons.OKCancel:
                    return MessageBoxButton.OKCancel;
                case System.Windows.Forms.MessageBoxButtons.RetryCancel:
                    throw new AtomusException("RetryCancel Not Support.");
                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    return MessageBoxButton.YesNo;
                case System.Windows.Forms.MessageBoxButtons.YesNoCancel:
                    return MessageBoxButton.YesNoCancel;
                default:
                    throw new AtomusException("Not Support.");
            }
        }

        private MessageBoxImage MessageBoxIconConvert(System.Windows.Forms.MessageBoxIcon messageBoxIcon)
        {
            switch (messageBoxIcon)
            {

                case System.Windows.Forms.MessageBoxIcon.None:
                    return MessageBoxImage.None;
                case System.Windows.Forms.MessageBoxIcon.Question:
                    return MessageBoxImage.Question;
                default:
                    if (messageBoxIcon == System.Windows.Forms.MessageBoxIcon.Asterisk)
                        return MessageBoxImage.Asterisk;

                    if (messageBoxIcon == System.Windows.Forms.MessageBoxIcon.Information)
                        return MessageBoxImage.Information;

                    if (messageBoxIcon == System.Windows.Forms.MessageBoxIcon.Exclamation)
                        return MessageBoxImage.Exclamation;

                    if (messageBoxIcon == System.Windows.Forms.MessageBoxIcon.Warning)
                        return MessageBoxImage.Warning;

                    if (messageBoxIcon == System.Windows.Forms.MessageBoxIcon.Error)
                        return MessageBoxImage.Error;

                    if (messageBoxIcon == System.Windows.Forms.MessageBoxIcon.Hand)
                        return MessageBoxImage.Hand;

                    if (messageBoxIcon == System.Windows.Forms.MessageBoxIcon.Stop)
                        return MessageBoxImage.Stop;

                    throw new AtomusException("Not Support.");
            }
        }
    }
}