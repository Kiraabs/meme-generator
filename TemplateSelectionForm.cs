namespace MemeGenerator
{
    public partial class TemplateSelectionForm : Form
    {
        public TemplateSelectionForm()
        {
            InitializeComponent();
            ListViewFill();
        }

        #region Обработчики событий.

        /// <summary>
        /// Обработчик события возврата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonBack_Click(object sender, EventArgs e)
        {
            var mf = new MainForm();
            mf.Show();
            Hide();
        }

        /// <summary>
        /// Обработчик события закрытия формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TemplateSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // в дочерних формах выход из приложения осуществляется вручную
            Application.Exit();
        }

        /// <summary>
        /// Обработчик события добавления шаблона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonAddTemplate_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Обработчик события двойного щелчка по шаблону.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ListViewTemplates_ItemActivate(object sender, EventArgs e)
        {
            // взять у выбранного list view-элемента индекс, и выполнить индексацию в ключах
            // у списка изображений, чтобы получить полный путь к изображению и отправить его в форму редактора.
            var tef = new TemplateEditorForm
            (
                ImageListTemplates.Images.Keys[ListViewTemplates.SelectedItems[0].ImageIndex]!
            );
            tef.Show();
            Hide();
        }

        #endregion

        #region Методы

        /// <summary>
        /// Обновляет список изображений и List View.
        /// </summary>
        void TemplatesRefresh()
        {
            ImageListTemplates.Images.Clear();
            ListViewTemplates.Items.Clear();
            ListViewFill();
        }

        /// <summary>
        /// Заполняет ListView.
        /// </summary>
        void ListViewFill()
        {
            ReadTemplateFold();

            // у каждого элемента ListView будет свой индекс изображения, 
            // по которому потом, можно будет получить полный к нему путь
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
        /// Считывает папку шаблонов и заносит данные в список изображений.
        /// </summary>
        void ReadTemplateFold()
        {
            // у каждого элемента списка изображений будет ключ, который является полным путем к изображению.
            foreach (var item in Template.Dir.GetFiles())
            {
                ImageListTemplates.Images.Add(item.FullName, new Bitmap(item.FullName));
            }
        } 

        #endregion
    }
}
