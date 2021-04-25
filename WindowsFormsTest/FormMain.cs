using System;
using System.Windows.Forms;
using NetSoftwareUpdateChecker;
using Newtonsoft.Json;

namespace WindowsFormsTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            UpdateChecker.ExceptionOccurred += ExceptionOccurred;
        }

        private void ExceptionOccurred(object? sender, ExceptionEventArgs e)
        {
            const string delimiterLine = "--------------------";
            tbExceptionLog.AppendText((e.Exception.StackTrace == null
                ? string.Join(Environment.NewLine, e.Exception.Message, delimiterLine)
                : string.Join(Environment.NewLine, e.Exception.Message, delimiterLine, e.Exception.StackTrace,
                    delimiterLine)) + Environment.NewLine);
        }

        private async void RunTestsClick(object sender, EventArgs e)
        {
            tbExceptionLog.Clear();
            tbOutputFileDownload.Clear();
            tbOutputRestData.Clear();

            var uri = tbDownloadUri.Text;
            var checker = new UpdateChecker(uri, true);
            var updateData = await checker.GetUpdateData();
            tbOutputFileDownload.AppendText(JsonConvert.SerializeObject(updateData, Formatting.Indented));

            uri = tbRestUriUri.Text;
            checker = new UpdateChecker(uri, false);
            updateData = await checker.GetUpdateData();
            tbOutputRestData.AppendText(JsonConvert.SerializeObject(updateData, Formatting.Indented));
        }
    }
}