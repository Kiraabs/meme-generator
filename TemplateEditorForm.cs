using System.Drawing.Imaging;

namespace MemeGenerator
{
    public partial class TemplateEditorForm : Form
    {
        // TODO: добавление изображений на шаблон
        // TODO: вероятно, есть очень высокие, но узкие изображения, тогда изменение также ширины.
        /// <summary>
        /// Максимальная ширина для изображений.
        /// </summary>
        new const int Width = 800;
        /// <summary>
        /// Максимально допустимая ширина изображений.
        /// </summary>
        const int MaxWidth = 600;
        /// <summary>
        /// Шрифт 
        /// </summary>
        static Font? font; // чтобы не создавать переменную каждый раз при установке шрифта.

        public TemplateEditorForm(string imagePath)
        {
            InitializeComponent();
            PictureBoxTemplate.Image = new Bitmap(imagePath);
            if (PictureBoxTemplate.Image.Width > MaxWidth) ResizeImage();
            LoadSystemFonts();
        }

        #region Обработчики событий

        /// <summary>
        /// Обработчик события щелчка по меню выбора цвета.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ToolStripForeColor_Click(object sender, EventArgs e)
        {
            ColorDialogForeground.ShowDialog();
            TextSet();
        }

        /// <summary>
        /// Обработчик события закрытия контекстного меню настроек текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ContextMenuStripFont_Closed(object sender, ToolStripDropDownClosedEventArgs e) => TextSet();

        /// <summary>
        /// Обработчик события добавления текста на шаблон.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonAddText_Click(object sender, EventArgs e)
        {
            var lb = new Label // создание экземпляра метки с привязкой к ней контекстного меню
            {
                Text = "Текст",
                Font = font,
                ContextMenuStrip = ContextMenuStripFont,
                AutoSize = true,
                BackColor = Color.Transparent,
            };
            ControlExtension.Draggable(lb, true); // делает компонент перемещаемым (библа из NuGet).
            PictureBoxTemplate.Controls.Add(lb); // добавление текста в компоненты PictureBox,
                                                 // т.к. иначе текст перекрывается им.
        }

        /// <summary>
        /// Обработчик события сохранения шаблона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var mbr = MessageBox.Show
            (
                "После сохранения шаблон будет сброшен. Вы уверены?",
                "Подтверждение",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (mbr != DialogResult.Yes) return;

            var sfd = new SaveFileDialog
            {
                Filter = "(*.png)|*.png|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // получение объекта Graphics из изображения PictureBox, который представляет собой GDI+ объект,
                // то есть поверхность для рисования.

                using var graphics = Graphics.FromImage(PictureBoxTemplate.Image!);

                foreach (Label item in PictureBoxTemplate.Controls) // перебор всех элементов PictureBox
                {
                    // рисование текста на изображении, с указанным шрифтом, цветом и позицией.
                    graphics.DrawString(item.Text, item.Font, new SolidBrush(item.ForeColor), item.Location);
                }

                SaveWithFormat(sfd);
            }
        }

        /// <summary>
        /// Обработчик события возврата на главную форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonBack_Click(object sender, EventArgs e)
        {
            // после сохранения изображения, шаблон и так пустой, доп. подтверждение не требуется.
            if (PictureBoxTemplate.Image != null)
            {
                var mbr = MessageBox.Show
                (
                    "Шаблон будет сброшен. Вы уверены?",
                    "Подтверждение",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (mbr != DialogResult.Yes) return;
            }

            Back();
        }

        /// <summary>
        /// Обработчик закрытия формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MemeEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // после закрытия дочерней формы, она не инициирует выход из приложения, приходится делать это вручную.
            Application.Exit();
        }

        #endregion

        #region Методы.

        /// <summary>
        /// Устанавливает настройки текста источника, в соответствии с параметрами контекстного меню.
        /// </summary>
        void TextSet()
        {
            // получение источника (label-а), к которому привязано контекстное меню:

            if (ContextMenuStripFont.SourceControl is Label source)
            {
                try // чтобы не было исключений при неправильных параметрах контекстного меню
                {
                    FontSet();
                    source.Font = font;
                    source.ForeColor = ColorDialogForeground.Color;
                    source.Text = ToolStripTextBoxText.Text;
                }
                catch (Exception) { }
            }
        }

        /// <summary>
        /// Устанавливает шрифт.
        /// </summary>
        void FontSet()
        {
            if (ToolStripMenuItemBold.Checked)
            {
                font = new Font
                (
                    ToolStripComboBoxFontFamily.Text,
                    float.Parse(ToolStripTextBoxFontSize.Text),
                    FontStyle.Bold
                );
            }
            else if (ToolStripMenuItemItalic.Checked)
            {
                font = new Font
                (
                    ToolStripComboBoxFontFamily.Text,
                    float.Parse(ToolStripTextBoxFontSize.Text),
                    FontStyle.Italic
                );
            }
            else if (ToolStripMenuItemUnderline.Checked)
            {
                font = new Font
                (
                    ToolStripComboBoxFontFamily.Text,
                    float.Parse(ToolStripTextBoxFontSize.Text),
                    FontStyle.Underline
                );
            }
            else
            {
                font = new Font
                (
                    ToolStripComboBoxFontFamily.Text,
                    float.Parse(ToolStripTextBoxFontSize.Text)
                );
            }
        }

        /// <summary>
        /// Загружает все системные шрифты.
        /// </summary>
        void LoadSystemFonts()
        {
            foreach (var item in FontFamily.Families)
            {
                ToolStripComboBoxFontFamily.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// Подгоняет изображение до максимальных размеров PictureBox.
        /// </summary>
        void ResizeImage()
        {
            PictureBoxTemplate.Image = new Bitmap(PictureBoxTemplate.Image, ProportionalResize());
        }

        /// <summary>
        /// Пропорционально изменяет размеры изображения.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="newW"></param>
        /// <returns></returns>
        Size ProportionalResize()
        {
            // ширина - константа и равна 800 (ширина PictureBox);
            // высоту нужно пропорционально изменить, относительно ширины, формула:
            // новая высота = исходная высота * новая ширина / исходная ширина
            return new Size(Width, PictureBoxTemplate.Image.Height * Width / PictureBoxTemplate.Image.Width);
        }

        /// <summary>
        /// Сохраняет изображение, с указанным пользователем форматом.
        /// </summary>
        /// <param name="sfd"></param>
        void SaveWithFormat(SaveFileDialog sfd)
        {
            var format = ImageFormat.Jpeg;

            switch (sfd.FilterIndex) // "свич" выбранного пользователем формата.
            {
                case 1:
                    format = ImageFormat.Png;
                    break;
                case 2:
                case 3:
                    format = ImageFormat.Jpeg;
                    break;
                case 4:
                    format = ImageFormat.Gif;
                    break;
            }

            PictureBoxTemplate.Image.Save(sfd.FileName, format);
            Back();
        }

        /// <summary>
        /// Переходит обратно на главную форму.
        /// </summary>
        void Back()
        {
            var mf = new MainForm();
            mf.Show();
            Hide();
        }

        #endregion

        private void ToolStripMenuItemBold_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemItalic.Checked = false;
            ToolStripMenuItemUnderline.Checked = false;
        }

        private void ToolStripMenuItemItalic_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemBold.Checked = false;
            ToolStripMenuItemUnderline.Checked = false;
        }

        private void ToolStripMenuItemUnderline_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemBold.Checked = false;
            ToolStripMenuItemItalic.Checked = false;
        }
    }
}
