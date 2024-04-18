namespace meme_generator
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
                Filter = "Файлы изображений|*.jpg;*.png;*.jpeg"
            };
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var me = new MemeEditorForm(ofd.FileName);
                me.Show();
                me.FormClosed += ChildForm_Closed;
                Hide();
            }
        }

        private void ChildForm_Closed(object? sender, FormClosedEventArgs e) => Environment.Exit(0);
    }
}
