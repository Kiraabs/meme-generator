using System.Drawing.Imaging;

namespace MemeGenerator
{
    public partial class TemplateEditorForm : Form
    {
        /// <summary>
        /// Шрифт 
        /// </summary>
        static Font? font;

        public TemplateEditorForm(string imagePath)
        {
            InitializeComponent();
            PictureBoxTemplate.ScaleImage(new Bitmap(imagePath));
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
        }

        /// <summary>
        /// Обработчик события закрытия контекстного меню настроек текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ContextMenuStripFont_Closed(object sender, ToolStripDropDownClosedEventArgs e) => TextSet();

        /// <summary>
        /// Обработчик события закрытия контекстного меню изображения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ContextMenuStripImage_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if (ContextMenuStripImage.SourceControl is PictureBox pb)
            {
                // если получилось считать значения ширины и высота из полей
                if (int.TryParse(ToolStripTextBoxWidth.Text, out var w) &&
                    int.TryParse(ToolStripTextBoxHeight.Text, out var h))
                {
                    // введенные размеры не должны превышать размеры шаблона (необязательно, но джаст ин кейс)
                    if (w <= PictureBoxTemplate.Image.Width && h <= PictureBoxTemplate.Image.Height)
                        pb.ClientSize = new Size(w, h);

                    // задать размеры клиенсткой области полученного PictureBox, где у каждого масштабирование - автоматическое. 
                    // Здесь логика немного обратная, чем у PictureBoxTemplate в ОПР я это разжевал.
                }
            }
        }

        /// <summary>
        /// Обработчик события добавления текста на шаблон.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonAddText_Click(object sender, EventArgs e)
        {
            // создание экземпляра label-а с привязкой к нему контекстного меню
            // то есть для каждого label-а - свое контекстное меню,
            // которое будет менять параметры только у своего инициатора.
            var lb = new Label
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
        /// Обработчик события удаления текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            // получение источника (label-а), к которому привязано контекстное меню
            if (ContextMenuStripFont.SourceControl is Label lb)
                lb.Dispose(); // удаление источника
        }

        /// <summary>
        /// Обработчик события добавления изображения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonAddImage_Click(object sender, EventArgs e)
        {
            // аналогично добавлению текста
            var ofd = new OpenFileDialog
            {
                Filter = "Файлы изображений|*.jpg;*.png;*.jpeg"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var pb = new PictureBox
                {
                    Image = new Bitmap(ofd.FileName),
                    ContextMenuStrip = ContextMenuStripImage,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                ControlExtension.Draggable(pb, true); // аналогично тексту
                PictureBoxTemplate.Controls.Add(pb);
            }
        }

        /// <summary>
        /// Обработчик события удаления изображения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemDeleteImg_Click(object sender, EventArgs e)
        {
            // аналогично удалению текста
            if (ContextMenuStripImage.SourceControl is PictureBox pb)
                pb.Dispose();
        }

        /// <summary>
        /// Обработчик события сохранения шаблона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonSave_Click(object sender, EventArgs e)
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

                using var graphics = Graphics.FromImage(PictureBoxTemplate.Image);

                foreach (var item in PictureBoxTemplate.Controls) // перебор всех элементов PictureBox
                {
                    if (item is Label lb)
                    {
                        // рисование текста на выходном изображении, с указанным шрифтом, цветом и позицией.
                        graphics.DrawString(lb.Text, lb.Font, new SolidBrush(lb.ForeColor), lb.Location);
                    }
                    else if (item is PictureBox pb)
                    {
                        // рисование изображения на выходном изображении.
                        var scaled = pb.ScaledSize();
                        graphics.DrawImage(pb.Image, pb.Location.X, pb.Location.Y, scaled.Width, scaled.Height);
                    }
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
            var mbr = MessageBox.Show
            (
                "Шаблон будет сброшен. Вы уверены?",
                "Подтверждение",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (mbr != DialogResult.Yes) 
                return;

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

        // обработчики для реализации поведения RadioButton-ов у кнопок стилей шрифта контекстного меню,
        // поскольку, одновременно может быть установлен только один стиль.
        void ToolStripMenuItemBold_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemItalic.Checked = false;
            ToolStripMenuItemUnderline.Checked = false;
        }

        void ToolStripMenuItemItalic_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemBold.Checked = false;
            ToolStripMenuItemUnderline.Checked = false;
        }

        void ToolStripMenuItemUnderline_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemBold.Checked = false;
            ToolStripMenuItemItalic.Checked = false;
        }

        #endregion

        #region Методы.

        /// <summary>
        /// Устанавливает настройки текста источника, в соответствии с параметрами контекстного меню.
        /// </summary>
        void TextSet()
        {
            // получение источника (label-а), к которому привязано контекстное меню
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
            // в зависимости от выбранного стиля шрифта - создать шрифт с таким стилем.
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
    }
}
