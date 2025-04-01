namespace XSDCompare
{
    public partial class CompareXSDForm : Form
    {
        public CompareXSDForm()
        {
            InitializeComponent();
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            new XSDComparer().CompareXSD("C:\\Temp\\Atrias\\XSD\\Generated new style\\ResponseRequestRectification_02-02p008.xsd",
                "C:\\Temp\\Atrias\\XSD\\ResponseRequestRectification_02-02p008_org.xsd");
        }
    }
}
