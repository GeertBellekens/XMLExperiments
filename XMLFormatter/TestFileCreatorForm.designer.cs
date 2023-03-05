namespace TestFileCreator
{
    partial class TestFileCreatorForm
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
            this.browseStartFileButton = new System.Windows.Forms.Button();
            this.startFileTextBox = new System.Windows.Forms.TextBox();
            this.importFileLabel = new System.Windows.Forms.Label();
            this.createTestFileButton = new System.Windows.Forms.Button();
            this.feedbackTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xmlFileGroup = new System.Windows.Forms.GroupBox();
            this.destinationFileTextBox = new System.Windows.Forms.TextBox();
            this.browseDestinationFileButton = new System.Windows.Forms.Button();
            this.destinationFileLabel = new System.Windows.Forms.Label();
            this.repeatsUpDown = new System.Windows.Forms.NumericUpDown();
            this.repeatsLabel = new System.Windows.Forms.Label();
            this.xmlFileGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // browseStartFileButton
            // 
            this.browseStartFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseStartFileButton.Location = new System.Drawing.Point(381, 34);
            this.browseStartFileButton.Name = "browseStartFileButton";
            this.browseStartFileButton.Size = new System.Drawing.Size(24, 20);
            this.browseStartFileButton.TabIndex = 15;
            this.browseStartFileButton.Text = "...";
            this.browseStartFileButton.UseVisualStyleBackColor = true;
            this.browseStartFileButton.Click += new System.EventHandler(this.browseStartFileButton_Click);
            // 
            // startFileTextBox
            // 
            this.startFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startFileTextBox.Location = new System.Drawing.Point(6, 35);
            this.startFileTextBox.MinimumSize = new System.Drawing.Size(153, 20);
            this.startFileTextBox.Name = "startFileTextBox";
            this.startFileTextBox.Size = new System.Drawing.Size(369, 20);
            this.startFileTextBox.TabIndex = 14;
            // 
            // importFileLabel
            // 
            this.importFileLabel.Location = new System.Drawing.Point(3, 19);
            this.importFileLabel.Name = "importFileLabel";
            this.importFileLabel.Size = new System.Drawing.Size(141, 23);
            this.importFileLabel.TabIndex = 16;
            this.importFileLabel.Text = "Start File";
            // 
            // createTestFileButton
            // 
            this.createTestFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createTestFileButton.Location = new System.Drawing.Point(335, 157);
            this.createTestFileButton.Name = "createTestFileButton";
            this.createTestFileButton.Size = new System.Drawing.Size(75, 23);
            this.createTestFileButton.TabIndex = 17;
            this.createTestFileButton.Text = "Create";
            this.createTestFileButton.UseVisualStyleBackColor = true;
            this.createTestFileButton.Click += new System.EventHandler(this.createButtonClick);
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedbackTextBox.Location = new System.Drawing.Point(12, 217);
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.ReadOnly = true;
            this.feedbackTextBox.Size = new System.Drawing.Size(416, 162);
            this.feedbackTextBox.TabIndex = 18;
            this.feedbackTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Info";
            // 
            // xmlFileGroup
            // 
            this.xmlFileGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlFileGroup.Controls.Add(this.repeatsUpDown);
            this.xmlFileGroup.Controls.Add(this.repeatsLabel);
            this.xmlFileGroup.Controls.Add(this.destinationFileTextBox);
            this.xmlFileGroup.Controls.Add(this.destinationFileLabel);
            this.xmlFileGroup.Controls.Add(this.browseDestinationFileButton);
            this.xmlFileGroup.Controls.Add(this.startFileTextBox);
            this.xmlFileGroup.Controls.Add(this.importFileLabel);
            this.xmlFileGroup.Controls.Add(this.browseStartFileButton);
            this.xmlFileGroup.Controls.Add(this.createTestFileButton);
            this.xmlFileGroup.Location = new System.Drawing.Point(12, 12);
            this.xmlFileGroup.Name = "xmlFileGroup";
            this.xmlFileGroup.Size = new System.Drawing.Size(416, 186);
            this.xmlFileGroup.TabIndex = 21;
            this.xmlFileGroup.TabStop = false;
            this.xmlFileGroup.Text = "XML File";
            // 
            // destinationFileTextBox
            // 
            this.destinationFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationFileTextBox.Location = new System.Drawing.Point(6, 83);
            this.destinationFileTextBox.MinimumSize = new System.Drawing.Size(153, 20);
            this.destinationFileTextBox.Name = "destinationFileTextBox";
            this.destinationFileTextBox.Size = new System.Drawing.Size(369, 20);
            this.destinationFileTextBox.TabIndex = 18;
            // 
            // browseDestinationFileButton
            // 
            this.browseDestinationFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseDestinationFileButton.Location = new System.Drawing.Point(381, 83);
            this.browseDestinationFileButton.Name = "browseDestinationFileButton";
            this.browseDestinationFileButton.Size = new System.Drawing.Size(24, 20);
            this.browseDestinationFileButton.TabIndex = 19;
            this.browseDestinationFileButton.Text = "...";
            this.browseDestinationFileButton.UseVisualStyleBackColor = true;
            this.browseDestinationFileButton.Click += new System.EventHandler(this.browseDestinationFileButton_Click);
            // 
            // destinationFileLabel
            // 
            this.destinationFileLabel.Location = new System.Drawing.Point(3, 67);
            this.destinationFileLabel.Name = "destinationFileLabel";
            this.destinationFileLabel.Size = new System.Drawing.Size(141, 23);
            this.destinationFileLabel.TabIndex = 20;
            this.destinationFileLabel.Text = "Destination File";
            // 
            // repeatsUpDown
            // 
            this.repeatsUpDown.Location = new System.Drawing.Point(6, 130);
            this.repeatsUpDown.Name = "repeatsUpDown";
            this.repeatsUpDown.Size = new System.Drawing.Size(120, 20);
            this.repeatsUpDown.TabIndex = 21;
            // 
            // repeatsLabel
            // 
            this.repeatsLabel.Location = new System.Drawing.Point(3, 115);
            this.repeatsLabel.Name = "repeatsLabel";
            this.repeatsLabel.Size = new System.Drawing.Size(141, 23);
            this.repeatsLabel.TabIndex = 22;
            this.repeatsLabel.Text = "Repeats";
            // 
            // TestFileCreatorForm
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
            this.Name = "TestFileCreatorForm";
            this.Text = "Test XML Reader";
            this.xmlFileGroup.ResumeLayout(false);
            this.xmlFileGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseStartFileButton;
        private System.Windows.Forms.TextBox startFileTextBox;
        private System.Windows.Forms.Label importFileLabel;
        private System.Windows.Forms.Button createTestFileButton;
        private System.Windows.Forms.RichTextBox feedbackTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox xmlFileGroup;
        private System.Windows.Forms.TextBox destinationFileTextBox;
        private System.Windows.Forms.Label destinationFileLabel;
        private System.Windows.Forms.Button browseDestinationFileButton;
        private System.Windows.Forms.NumericUpDown repeatsUpDown;
        private System.Windows.Forms.Label repeatsLabel;
    }
}

