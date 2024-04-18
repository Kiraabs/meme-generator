namespace meme_generator
{
    public partial class MemeEditorForm : Form
    {
        public MemeEditorForm(string imagePath)
        {
            InitializeComponent();
            PictureBoxImage.BackgroundImage = new Bitmap(imagePath);
        }
    }
}
