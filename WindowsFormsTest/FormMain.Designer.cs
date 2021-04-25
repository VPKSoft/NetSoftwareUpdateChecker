
namespace WindowsFormsTest
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btRunTests = new System.Windows.Forms.Button();
            this.gpFileDownloadTest = new System.Windows.Forms.GroupBox();
            this.lbFileUriDescription = new System.Windows.Forms.Label();
            this.lbOutputFileDownload = new System.Windows.Forms.Label();
            this.tbOutputFileDownload = new System.Windows.Forms.TextBox();
            this.tbDownloadUri = new System.Windows.Forms.TextBox();
            this.lbDownloadUri = new System.Windows.Forms.Label();
            this.gpRESTDataTest = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOutputRestData = new System.Windows.Forms.Label();
            this.tbOutputRestData = new System.Windows.Forms.TextBox();
            this.tbRestUriUri = new System.Windows.Forms.TextBox();
            this.lbRestUriUri = new System.Windows.Forms.Label();
            this.tbExceptionLog = new System.Windows.Forms.TextBox();
            this.gpFileDownloadTest.SuspendLayout();
            this.gpRESTDataTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRunTests
            // 
            this.btRunTests.Location = new System.Drawing.Point(518, 12);
            this.btRunTests.Name = "btRunTests";
            this.btRunTests.Size = new System.Drawing.Size(270, 23);
            this.btRunTests.TabIndex = 0;
            this.btRunTests.Text = "Run tests >>";
            this.btRunTests.UseVisualStyleBackColor = true;
            this.btRunTests.Click += new System.EventHandler(this.RunTestsClick);
            // 
            // gpFileDownloadTest
            // 
            this.gpFileDownloadTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpFileDownloadTest.Controls.Add(this.lbFileUriDescription);
            this.gpFileDownloadTest.Controls.Add(this.lbOutputFileDownload);
            this.gpFileDownloadTest.Controls.Add(this.tbOutputFileDownload);
            this.gpFileDownloadTest.Controls.Add(this.tbDownloadUri);
            this.gpFileDownloadTest.Controls.Add(this.lbDownloadUri);
            this.gpFileDownloadTest.Location = new System.Drawing.Point(12, 12);
            this.gpFileDownloadTest.Name = "gpFileDownloadTest";
            this.gpFileDownloadTest.Size = new System.Drawing.Size(494, 207);
            this.gpFileDownloadTest.TabIndex = 1;
            this.gpFileDownloadTest.TabStop = false;
            this.gpFileDownloadTest.Text = "File download test";
            // 
            // lbFileUriDescription
            // 
            this.lbFileUriDescription.AutoSize = true;
            this.lbFileUriDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFileUriDescription.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbFileUriDescription.Location = new System.Drawing.Point(149, 48);
            this.lbFileUriDescription.Name = "lbFileUriDescription";
            this.lbFileUriDescription.Size = new System.Drawing.Size(253, 15);
            this.lbFileUriDescription.TabIndex = 4;
            this.lbFileUriDescription.Text = "↑ Set this to file to test with local JSON file ↑";
            // 
            // lbOutputFileDownload
            // 
            this.lbOutputFileDownload.AutoSize = true;
            this.lbOutputFileDownload.Location = new System.Drawing.Point(6, 51);
            this.lbOutputFileDownload.Name = "lbOutputFileDownload";
            this.lbOutputFileDownload.Size = new System.Drawing.Size(48, 15);
            this.lbOutputFileDownload.TabIndex = 3;
            this.lbOutputFileDownload.Text = "Output:";
            // 
            // tbOutputFileDownload
            // 
            this.tbOutputFileDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputFileDownload.Location = new System.Drawing.Point(6, 77);
            this.tbOutputFileDownload.Multiline = true;
            this.tbOutputFileDownload.Name = "tbOutputFileDownload";
            this.tbOutputFileDownload.ReadOnly = true;
            this.tbOutputFileDownload.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutputFileDownload.Size = new System.Drawing.Size(482, 124);
            this.tbOutputFileDownload.TabIndex = 2;
            this.tbOutputFileDownload.WordWrap = false;
            // 
            // tbDownloadUri
            // 
            this.tbDownloadUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDownloadUri.Location = new System.Drawing.Point(156, 22);
            this.tbDownloadUri.Name = "tbDownloadUri";
            this.tbDownloadUri.Size = new System.Drawing.Size(332, 23);
            this.tbDownloadUri.TabIndex = 1;
            this.tbDownloadUri.Text = "http://localhost:52348/api/download/testData.json";
            // 
            // lbDownloadUri
            // 
            this.lbDownloadUri.AutoSize = true;
            this.lbDownloadUri.Location = new System.Drawing.Point(6, 25);
            this.lbDownloadUri.Name = "lbDownloadUri";
            this.lbDownloadUri.Size = new System.Drawing.Size(88, 15);
            this.lbDownloadUri.TabIndex = 0;
            this.lbDownloadUri.Text = "Download URL:";
            // 
            // gpRESTDataTest
            // 
            this.gpRESTDataTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpRESTDataTest.Controls.Add(this.label1);
            this.gpRESTDataTest.Controls.Add(this.lbOutputRestData);
            this.gpRESTDataTest.Controls.Add(this.tbOutputRestData);
            this.gpRESTDataTest.Controls.Add(this.tbRestUriUri);
            this.gpRESTDataTest.Controls.Add(this.lbRestUriUri);
            this.gpRESTDataTest.Location = new System.Drawing.Point(12, 219);
            this.gpRESTDataTest.Name = "gpRESTDataTest";
            this.gpRESTDataTest.Size = new System.Drawing.Size(500, 207);
            this.gpRESTDataTest.TabIndex = 2;
            this.gpRESTDataTest.TabStop = false;
            this.gpRESTDataTest.Text = "File download test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(149, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "↑ Run the TestServer to test with localhost connection ↑";
            // 
            // lbOutputRestData
            // 
            this.lbOutputRestData.AutoSize = true;
            this.lbOutputRestData.Location = new System.Drawing.Point(6, 51);
            this.lbOutputRestData.Name = "lbOutputRestData";
            this.lbOutputRestData.Size = new System.Drawing.Size(48, 15);
            this.lbOutputRestData.TabIndex = 3;
            this.lbOutputRestData.Text = "Output:";
            // 
            // tbOutputRestData
            // 
            this.tbOutputRestData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputRestData.Location = new System.Drawing.Point(6, 77);
            this.tbOutputRestData.Multiline = true;
            this.tbOutputRestData.Name = "tbOutputRestData";
            this.tbOutputRestData.ReadOnly = true;
            this.tbOutputRestData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutputRestData.Size = new System.Drawing.Size(488, 124);
            this.tbOutputRestData.TabIndex = 2;
            this.tbOutputRestData.WordWrap = false;
            // 
            // tbRestUriUri
            // 
            this.tbRestUriUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRestUriUri.Location = new System.Drawing.Point(156, 22);
            this.tbRestUriUri.Name = "tbRestUriUri";
            this.tbRestUriUri.Size = new System.Drawing.Size(338, 23);
            this.tbRestUriUri.TabIndex = 1;
            this.tbRestUriUri.Text = "http://localhost:52348/api/test";
            // 
            // lbRestUriUri
            // 
            this.lbRestUriUri.AutoSize = true;
            this.lbRestUriUri.Location = new System.Drawing.Point(6, 25);
            this.lbRestUriUri.Name = "lbRestUriUri";
            this.lbRestUriUri.Size = new System.Drawing.Size(144, 15);
            this.lbRestUriUri.TabIndex = 0;
            this.lbRestUriUri.Text = "RESTful API endpoint URL:";
            // 
            // tbExceptionLog
            // 
            this.tbExceptionLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExceptionLog.Location = new System.Drawing.Point(518, 41);
            this.tbExceptionLog.Multiline = true;
            this.tbExceptionLog.Name = "tbExceptionLog";
            this.tbExceptionLog.ReadOnly = true;
            this.tbExceptionLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbExceptionLog.Size = new System.Drawing.Size(270, 379);
            this.tbExceptionLog.TabIndex = 3;
            this.tbExceptionLog.WordWrap = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.tbExceptionLog);
            this.Controls.Add(this.gpRESTDataTest);
            this.Controls.Add(this.gpFileDownloadTest);
            this.Controls.Add(this.btRunTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "NetSoftwareUpdateChecker Test Application";
            this.gpFileDownloadTest.ResumeLayout(false);
            this.gpFileDownloadTest.PerformLayout();
            this.gpRESTDataTest.ResumeLayout(false);
            this.gpRESTDataTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRunTests;
        private System.Windows.Forms.GroupBox gpFileDownloadTest;
        private System.Windows.Forms.Label lbOutputFileDownload;
        private System.Windows.Forms.TextBox tbOutputFileDownload;
        private System.Windows.Forms.TextBox tbDownloadUri;
        private System.Windows.Forms.Label lbDownloadUri;
        private System.Windows.Forms.Label lbFileUriDescription;
        private System.Windows.Forms.GroupBox gpRESTDataTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOutputRestData;
        private System.Windows.Forms.TextBox tbOutputRestData;
        private System.Windows.Forms.TextBox tbRestUriUri;
        private System.Windows.Forms.Label lbRestUriUri;
        private System.Windows.Forms.TextBox tbExceptionLog;
    }
}

