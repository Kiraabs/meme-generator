namespace MemeGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события выбора изображения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonImageSelect_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Файлы изображений|*.jpg;*.png;*.jpeg"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!Template.Exists(ofd.FileName)) // если изображения нет в папке шаблонов
                {
                    var mbr = MessageBox.Show
                    (
                        "Добавить выбранное изображение в папку шаблонов?",
                        "Подтверждение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (mbr == DialogResult.Yes) Template.Create(ofd.FileName);
                }

                var tef = new TemplateEditorForm(ofd.FileName);
                tef.Show();
                Hide();
            }
        }

        /// <summary>
        /// Обработчик события выбора шаблона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonTemplateSelect_Click(object sender, EventArgs e)
        {
            var tsf = new TemplateSelectionForm();
            tsf.Show();
            Hide();
        }

        /// <summary>
        /// Обработчик события закрытия формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // из-за всех переключений между формами, выходить из приложения приходится вручную.
            Application.Exit();
        }
    }
}
