namespace TestXMLReader
{
    partial class TestXMLReaderForm
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
            this.browseImportFileButton = new System.Windows.Forms.Button();
            this.importFileTextBox = new System.Windows.Forms.TextBox();
            this.importFileLabel = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.feedbackTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xmlFileGroup = new System.Windows.Forms.GroupBox();
            this.importStream = new System.Windows.Forms.Button();
            this.ImportBulkButton = new System.Windows.Forms.Button();
            this.xmlFileGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseImportFileButton
            // 
            this.browseImportFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseImportFileButton.Location = new System.Drawing.Point(381, 34);
            this.browseImportFileButton.Name = "browseImportFileButton";
            this.browseImportFileButton.Size = new System.Drawing.Size(24, 20);
            this.browseImportFileButton.TabIndex = 15;
            this.browseImportFileButton.Text = "...";
            this.browseImportFileButton.UseVisualStyleBackColor = true;
            this.browseImportFileButton.Click += new System.EventHandler(this.browseImportFileButton_Click);
            // 
            // importFileTextBox
            // 
            this.importFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importFileTextBox.Location = new System.Drawing.Point(6, 35);
            this.importFileTextBox.MinimumSize = new System.Drawing.Size(153, 20);
            this.importFileTextBox.Name = "importFileTextBox";
            this.importFileTextBox.Size = new System.Drawing.Size(369, 20);
            this.importFileTextBox.TabIndex = 14;
            // 
            // importFileLabel
            // 
            this.importFileLabel.Location = new System.Drawing.Point(3, 19);
            this.importFileLabel.Name = "importFileLabel";
            this.importFileLabel.Size = new System.Drawing.Size(141, 23);
            this.importFileLabel.TabIndex = 16;
            this.importFileLabel.Text = "Import File";
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.Location = new System.Drawing.Point(335, 66);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 17;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedbackTextBox.Location = new System.Drawing.Point(12, 126);
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.ReadOnly = true;
            this.feedbackTextBox.Size = new System.Drawing.Size(416, 253);
            this.feedbackTextBox.TabIndex = 18;
            this.feedbackTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Info";
            // 
            // xmlFileGroup
            // 
            this.xmlFileGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlFileGroup.Controls.Add(this.ImportBulkButton);
            this.xmlFileGroup.Controls.Add(this.importFileTextBox);
            this.xmlFileGroup.Controls.Add(this.importFileLabel);
            this.xmlFileGroup.Controls.Add(this.browseImportFileButton);
            this.xmlFileGroup.Controls.Add(this.importStream);
            this.xmlFileGroup.Controls.Add(this.importButton);
            this.xmlFileGroup.Location = new System.Drawing.Point(12, 12);
            this.xmlFileGroup.Name = "xmlFileGroup";
            this.xmlFileGroup.Size = new System.Drawing.Size(416, 95);
            this.xmlFileGroup.TabIndex = 21;
            this.xmlFileGroup.TabStop = false;
            this.xmlFileGroup.Text = "XML File";
            // 
            // importStream
            // 
            this.importStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importStream.Location = new System.Drawing.Point(239, 66);
            this.importStream.Name = "importStream";
            this.importStream.Size = new System.Drawing.Size(90, 23);
            this.importStream.TabIndex = 17;
            this.importStream.Text = "ImportStream";
            this.importStream.UseVisualStyleBackColor = true;
            this.importStream.Click += new System.EventHandler(this.importStream_Click);
            // 
            // ImportBulkButton
            // 
            this.ImportBulkButton.Location = new System.Drawing.Point(158, 66);
            this.ImportBulkButton.Name = "ImportBulkButton";
            this.ImportBulkButton.Size = new System.Drawing.Size(75, 23);
            this.ImportBulkButton.TabIndex = 18;
            this.ImportBulkButton.Text = "ImportBulk";
            this.ImportBulkButton.UseVisualStyleBackColor = true;
            this.ImportBulkButton.Click += new System.EventHandler(this.ImportBulkButton_Click);
            // 
            // TestXMLReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feedbackTextBox);
            this.Controls.Add(this.xmlFileGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(456, 430);
            this.Name = "TestXMLReaderForm";
            this.Text = "Test XML Reader";
            this.xmlFileGroup.ResumeLayout(false);
            this.xmlFileGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseImportFileButton;
        private System.Windows.Forms.TextBox importFileTextBox;
        private System.Windows.Forms.Label importFileLabel;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.RichTextBox feedbackTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox xmlFileGroup;
        private System.Windows.Forms.Button importStream;
        private System.Windows.Forms.Button ImportBulkButton;
    }
}

