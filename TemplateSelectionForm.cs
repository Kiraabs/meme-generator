namespace MemeGenerator
{
    public partial class TemplateSelectionForm : Form
    {
        public TemplateSelectionForm()
        {
            InitializeComponent();
            TemplatesFill();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            var mf = new MainForm();
            mf.Show();
            Hide();
        }

        private void TemplateSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // в дочерних формах выход из приложения осуществляется вручную
            Application.Exit();
        }

        private void ButtonAddTemplate_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Файлы изображений|*.jpg;*.png;*.jpeg"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (Template.Create(ofd.FileName))
                {
                    TemplatesRefresh();
                }
            }
        }

        void TemplatesRefresh()
        {
            ImageListTemplates.Images.Clear();
            ListViewTemplates.Items.Clear();
            TemplatesFill();
        }

        void TemplatesFill()
        {
            ReadTemplateFold();

            for (int i = 0; i < ImageListTemplates.Images.Count; i++)
            {
                var lst = new ListViewItem()
                {
                    ImageIndex = i,
                };
                ListViewTemplates.Items.Add(lst);
            }
        }

        /// <summary>
        /// Считывает папку шаблонов.
        /// </summary>
        void ReadTemplateFold()
        {
            foreach (var item in Template.Dir.GetFiles())
            {
                ImageListTemplates.Images.Add(item.FullName, new Bitmap(item.FullName));
            }
        }

        /// <summary>
        /// Обработчик события двойного щелчка по шаблону.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewTemplates_ItemActivate(object sender, EventArgs e)
        {
            var tef = new TemplateEditorForm(ImageListTemplates.Images.Keys[ListViewTemplates.SelectedItems[0].ImageIndex]!);
            tef.Show();
            Hide();
        }
    }
}
