namespace MemeGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonImageSelect_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Файлы изображений|*.jpg;*.png;*.jpeg;*.gif"
            };
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var me = new MemeEditorForm(ofd.FileName);
                me.Show();
                Hide();
            }
        }
    }
}
