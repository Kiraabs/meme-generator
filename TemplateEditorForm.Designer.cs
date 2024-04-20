namespace MemeGenerator
{
    partial class TemplateEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PanelItems = new Panel();
            ButtonBack = new Button();
            ButtonAddImage = new Button();
            ButtonSave = new Button();
            ButtonAddText = new Button();
            ContextMenuStripFont = new ContextMenuStrip(components);
            ToolStripTextBoxText = new ToolStripTextBox();
            ToolStripTextBoxFontSize = new ToolStripTextBox();
            ToolStripComboBoxFontFamily = new ToolStripComboBox();
            ToolStripMenuItemForeColor = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ToolStripMenuItemBold = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItemItalic = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            ToolStripMenuItemUnderline = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            ToolStripMenuItemDelete = new ToolStripMenuItem();
            ColorDialogForeground = new ColorDialog();
            PictureBoxTemplate = new PictureBox();
            ContextMenuStripImage = new ContextMenuStrip(components);
            ToolStripTextBoxWidth = new ToolStripTextBox();
            ToolStripTextBoxHeight = new ToolStripTextBox();
            ToolStripMenuItemDeleteImg = new ToolStripMenuItem();
            PanelItems.SuspendLayout();
            ContextMenuStripFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxTemplate).BeginInit();
            ContextMenuStripImage.SuspendLayout();
            SuspendLayout();
            // 
            // PanelItems
            // 
            PanelItems.Controls.Add(ButtonBack);
            PanelItems.Controls.Add(ButtonAddImage);
            PanelItems.Controls.Add(ButtonSave);
            PanelItems.Controls.Add(ButtonAddText);
            PanelItems.Location = new Point(818, 12);
            PanelItems.Name = "PanelItems";
            PanelItems.Size = new Size(233, 600);
            PanelItems.TabIndex = 1;
            // 
            // ButtonBack
            // 
            ButtonBack.Cursor = Cursors.Hand;
            ButtonBack.FlatAppearance.BorderColor = Color.FromArgb(77, 144, 254);
            ButtonBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(77, 144, 254);
            ButtonBack.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ButtonBack.Location = new Point(3, 291);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(227, 42);
            ButtonBack.TabIndex = 4;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonAddImage
            // 
            ButtonAddImage.Cursor = Cursors.Hand;
            ButtonAddImage.FlatAppearance.BorderColor = Color.FromArgb(77, 144, 254);
            ButtonAddImage.FlatAppearance.MouseDownBackColor = Color.FromArgb(77, 144, 254);
            ButtonAddImage.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonAddImage.FlatStyle = FlatStyle.Flat;
            ButtonAddImage.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ButtonAddImage.Location = new Point(3, 99);
            ButtonAddImage.Name = "ButtonAddImage";
            ButtonAddImage.Size = new Size(227, 42);
            ButtonAddImage.TabIndex = 3;
            ButtonAddImage.Text = "Добавить изображение";
            ButtonAddImage.UseVisualStyleBackColor = true;
            ButtonAddImage.Click += ButtonAddImage_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Cursor = Cursors.Hand;
            ButtonSave.FlatAppearance.BorderColor = Color.FromArgb(77, 144, 254);
            ButtonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(77, 144, 254);
            ButtonSave.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonSave.FlatStyle = FlatStyle.Flat;
            ButtonSave.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ButtonSave.Location = new Point(3, 195);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(227, 42);
            ButtonSave.TabIndex = 2;
            ButtonSave.Text = "Сохранить";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonAddText
            // 
            ButtonAddText.Cursor = Cursors.Hand;
            ButtonAddText.FlatAppearance.BorderColor = Color.FromArgb(77, 144, 254);
            ButtonAddText.FlatAppearance.MouseDownBackColor = Color.FromArgb(77, 144, 254);
            ButtonAddText.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonAddText.FlatStyle = FlatStyle.Flat;
            ButtonAddText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ButtonAddText.Location = new Point(3, 3);
            ButtonAddText.Name = "ButtonAddText";
            ButtonAddText.Size = new Size(227, 42);
            ButtonAddText.TabIndex = 1;
            ButtonAddText.Text = "Добавить текст";
            ButtonAddText.UseVisualStyleBackColor = true;
            ButtonAddText.Click += ButtonAddText_Click;
            // 
            // ContextMenuStripFont
            // 
            ContextMenuStripFont.Items.AddRange(new ToolStripItem[] { ToolStripTextBoxText, ToolStripTextBoxFontSize, ToolStripComboBoxFontFamily, ToolStripMenuItemForeColor, ToolStripMenuItemBold, ToolStripMenuItemItalic, ToolStripMenuItemUnderline, ToolStripMenuItemDelete });
            ContextMenuStripFont.Name = "ContextMenuStripFont";
            ContextMenuStripFont.Size = new Size(182, 191);
            ContextMenuStripFont.Closed += ContextMenuStripFont_Closed;
            // 
            // ToolStripTextBoxText
            // 
            ToolStripTextBoxText.Name = "ToolStripTextBoxText";
            ToolStripTextBoxText.Size = new Size(100, 23);
            ToolStripTextBoxText.Text = "Текст";
            // 
            // ToolStripTextBoxFontSize
            // 
            ToolStripTextBoxFontSize.Name = "ToolStripTextBoxFontSize";
            ToolStripTextBoxFontSize.Size = new Size(100, 23);
            ToolStripTextBoxFontSize.Text = "Размер";
            // 
            // ToolStripComboBoxFontFamily
            // 
            ToolStripComboBoxFontFamily.DropDownHeight = 64;
            ToolStripComboBoxFontFamily.IntegralHeight = false;
            ToolStripComboBoxFontFamily.Name = "ToolStripComboBoxFontFamily";
            ToolStripComboBoxFontFamily.Size = new Size(121, 23);
            ToolStripComboBoxFontFamily.Text = "Шрифт";
            // 
            // ToolStripMenuItemForeColor
            // 
            ToolStripMenuItemForeColor.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            ToolStripMenuItemForeColor.Name = "ToolStripMenuItemForeColor";
            ToolStripMenuItemForeColor.Size = new Size(181, 22);
            ToolStripMenuItemForeColor.Text = "Цвет текста";
            ToolStripMenuItemForeColor.Click += ToolStripForeColor_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(67, 22);
            // 
            // ToolStripMenuItemBold
            // 
            ToolStripMenuItemBold.CheckOnClick = true;
            ToolStripMenuItemBold.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            ToolStripMenuItemBold.Name = "ToolStripMenuItemBold";
            ToolStripMenuItemBold.Size = new Size(181, 22);
            ToolStripMenuItemBold.Text = "Жирный";
            ToolStripMenuItemBold.Click += ToolStripMenuItemBold_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(67, 22);
            // 
            // ToolStripMenuItemItalic
            // 
            ToolStripMenuItemItalic.CheckOnClick = true;
            ToolStripMenuItemItalic.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            ToolStripMenuItemItalic.Name = "ToolStripMenuItemItalic";
            ToolStripMenuItemItalic.Size = new Size(181, 22);
            ToolStripMenuItemItalic.Text = "Курсив";
            ToolStripMenuItemItalic.Click += ToolStripMenuItemItalic_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Enabled = false;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(67, 22);
            // 
            // ToolStripMenuItemUnderline
            // 
            ToolStripMenuItemUnderline.CheckOnClick = true;
            ToolStripMenuItemUnderline.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4 });
            ToolStripMenuItemUnderline.Name = "ToolStripMenuItemUnderline";
            ToolStripMenuItemUnderline.Size = new Size(181, 22);
            ToolStripMenuItemUnderline.Text = "Подчекрнутый";
            ToolStripMenuItemUnderline.Click += ToolStripMenuItemUnderline_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Enabled = false;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(67, 22);
            // 
            // ToolStripMenuItemDelete
            // 
            ToolStripMenuItemDelete.Name = "ToolStripMenuItemDelete";
            ToolStripMenuItemDelete.Size = new Size(181, 22);
            ToolStripMenuItemDelete.Text = "Удалить";
            ToolStripMenuItemDelete.Click += ToolStripMenuItemDelete_Click;
            // 
            // PictureBoxTemplate
            // 
            PictureBoxTemplate.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBoxTemplate.Location = new Point(12, 12);
            PictureBoxTemplate.Name = "PictureBoxTemplate";
            PictureBoxTemplate.Size = new Size(800, 600);
            PictureBoxTemplate.TabIndex = 2;
            PictureBoxTemplate.TabStop = false;
            // 
            // ContextMenuStripImage
            // 
            ContextMenuStripImage.Items.AddRange(new ToolStripItem[] { ToolStripTextBoxWidth, ToolStripTextBoxHeight, ToolStripMenuItemDeleteImg });
            ContextMenuStripImage.Name = "ContextMenuStipImage";
            ContextMenuStripImage.Size = new Size(181, 98);
            ContextMenuStripImage.Closed += ContextMenuStripImage_Closed;
            // 
            // ToolStripTextBoxWidth
            // 
            ToolStripTextBoxWidth.Name = "ToolStripTextBoxWidth";
            ToolStripTextBoxWidth.Size = new Size(100, 23);
            ToolStripTextBoxWidth.Text = "Ширина";
            // 
            // ToolStripTextBoxHeight
            // 
            ToolStripTextBoxHeight.Name = "ToolStripTextBoxHeight";
            ToolStripTextBoxHeight.Size = new Size(100, 23);
            ToolStripTextBoxHeight.Text = "Высота";
            // 
            // ToolStripMenuItemDeleteImg
            // 
            ToolStripMenuItemDeleteImg.Name = "ToolStripMenuItemDeleteImg";
            ToolStripMenuItemDeleteImg.Size = new Size(180, 22);
            ToolStripMenuItemDeleteImg.Text = "Удалить";
            ToolStripMenuItemDeleteImg.Click += ToolStripMenuItemDeleteImg_Click;
            // 
            // TemplateEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 627);
            Controls.Add(PictureBoxTemplate);
            Controls.Add(PanelItems);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TemplateEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактор";
            FormClosed += MemeEditorForm_FormClosed;
            PanelItems.ResumeLayout(false);
            ContextMenuStripFont.ResumeLayout(false);
            ContextMenuStripFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxTemplate).EndInit();
            ContextMenuStripImage.ResumeLayout(false);
            ContextMenuStripImage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelItems;
        private Button ButtonAddText;
        private Button ButtonAddImage;
        private Button ButtonSave;
        private ContextMenuStrip ContextMenuStripFont;
        private ToolStripTextBox ToolStripTextBoxFontSize;
        private ToolStripComboBox ToolStripComboBoxFontFamily;
        private ColorDialog ColorDialogForeground;
        private ToolStripTextBox ToolStripForeColor;
        private ToolStripMenuItem ToolStripMenuItemForeColor;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripTextBox ToolStripTextBoxText;
        private PictureBox PictureBoxTemplate;
        private Button ButtonBack;
        private ToolStripMenuItem ToolStripMenuItemBold;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItemItalic;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem ToolStripMenuItemUnderline;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem ToolStripMenuItemDelete;
        private ContextMenuStrip ContextMenuStripImage;
        private ToolStripMenuItem ToolStripMenuItemDeleteImg;
        private ToolStripTextBox ToolStripTextBoxWidth;
        private ToolStripTextBox ToolStripTextBoxHeight;
    }
}