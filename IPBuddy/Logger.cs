using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace IPBuddy
{
    class Logger
    {
        public static void Initialize()
        {
            XElement log = new XElement("Log");
            XAttribute date = new XAttribute("timestamp", Logger.timestamp());
            log.Add(date);

            XDocument doc = new XDocument(log);
            doc.Save("log.xml");
        }

        public static void WriteMessage(String message)
        {
            XDocument doc = XDocument.Load("log.xml");
            XElement log = doc.Root;

            XAttribute value = new XAttribute("value", message);
            XAttribute time = new XAttribute("timestamp", Logger.timestamp());
            XElement xmessage = new XElement("Message");

            xmessage.Add(value);
            xmessage.Add(time);
            log.Add(xmessage);

            doc.Save("log.xml");
        }

        public static void WriteException(Exception e)
        {
            XDocument doc = XDocument.Load("log.xml");
            XElement log = doc.Root;

            XAttribute source = new XAttribute("source", e.Source);
            XAttribute message = new XAttribute("message", e.Message);
            XAttribute time = new XAttribute("timestamp", Logger.timestamp());
            XElement trace = new XElement("Trace", e.StackTrace);
            XElement xmessage = new XElement("Message");

            xmessage.Add(source);
            xmessage.Add(message);
            xmessage.Add(time);
            xmessage.Add(trace);
            log.Add(xmessage);

            doc.Save("log.xml");
        }

        public static void PromptLogReview(String message = "")
        {
            DialogResult dialogResult = MessageBox.Show(message + " Would you like to save the log file? This will be useful in tracing down the exact cause of this error.", "Error", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                XDocument doc = XDocument.Load("log.xml");
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        doc.Save(saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an error saving the log file. You may not have appropraite permissions.");
                    }
                }
            }
        }

        public static void CatchThread(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Logger.WriteMessage("A UI thread exception was caught.");
            Logger.WriteException(e.Exception);
            Logger.PromptLogReview("An exception was caught in the main thread.");
        }

        public static void CatchUnhandled(Object sender, UnhandledExceptionEventArgs e)
        {
            Logger.WriteMessage("An unhandled thread exception was caught.");
            Logger.WriteException((Exception)e.ExceptionObject);
            Logger.PromptLogReview("An unhandled exception was caught.");
        }

        private static String timestamp()
        {
            return DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
    }
}
