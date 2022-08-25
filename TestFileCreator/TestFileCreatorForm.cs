using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.IO;

namespace TestFileCreator
{
    public partial class TestFileCreatorForm : Form
    {
        
        public TestFileCreatorForm()
        {
            InitializeComponent();
            enableDisable();
        }
        private void enableDisable()
        {
            
        }

        private void browseStartFileButton_Click(object sender, EventArgs e)
        {
            //let the user select a file
            var browseFileDialog = new OpenFileDialog();
            browseFileDialog.Filter = "XML Files|*.xml";
            browseFileDialog.FilterIndex = 1;
            browseFileDialog.Multiselect = false;
            var dialogResult = browseFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                //if the user selected the file then put the filename in the abbreviationsfileTextBox
                this.startFileTextBox.Text = browseFileDialog.FileName;
                //move cursor to end to make sure the end of the path is visible
                this.startFileTextBox.Select(this.startFileTextBox.Text.Length, 0);
            }
        }

        private void createButtonClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.feedbackTextBox.Clear();
            var feedback = TestFileCreator.createTestFile(this.startFileTextBox.Text,this.destinationFileTextBox.Text, (long)this.repeatsUpDown.Value);
            this.feedbackTextBox.Text = string.IsNullOrEmpty(feedback) ? "Finished without feedback" : feedback;
            Cursor.Current = Cursors.Default;
        }

        private void browseDestinationFileButton_Click(object sender, EventArgs e)
        {
            //let the user select a file
            var browseFileDialog = new SaveFileDialog();
            browseFileDialog.Filter = "XML Files|*.xml";
            browseFileDialog.FilterIndex = 1;
            var dialogResult = browseFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                //if the user selected the file then put the filename in the abbreviationsfileTextBox
                this.destinationFileTextBox.Text = browseFileDialog.FileName;
                //move cursor to end to make sure the end of the path is visible
                this.destinationFileTextBox.Select(this.destinationFileTextBox.Text.Length, 0);
            }
        }
    }
}
