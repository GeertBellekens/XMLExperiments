namespace XSDCompare
{
    partial class CompareXSDForm
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
            CompareButton = new Button();
            SuspendLayout();
            // 
            // CompareButton
            // 
            CompareButton.Location = new Point(102, 76);
            CompareButton.Name = "CompareButton";
            CompareButton.Size = new Size(75, 23);
            CompareButton.TabIndex = 0;
            CompareButton.Text = "Compare";
            CompareButton.UseVisualStyleBackColor = true;
            CompareButton.Click += CompareButton_Click;
            // 
            // CompareXSDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CompareButton);
            Name = "CompareXSDForm";
            Text = "Compare";
            ResumeLayout(false);
        }

        #endregion

        private Button CompareButton;
    }
}
