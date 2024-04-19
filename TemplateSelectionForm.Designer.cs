namespace MemeGenerator
{
    partial class TemplateSelectionForm
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
            ButtonBack = new Button();
            ButtonAddTemplate = new Button();
            ListViewTemplates = new ListView();
            ImageListTemplates = new ImageList(components);
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Cursor = Cursors.Hand;
            ButtonBack.FlatAppearance.BorderColor = Color.FromArgb(77, 144, 254);
            ButtonBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(77, 144, 254);
            ButtonBack.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ButtonBack.Location = new Point(111, 624);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(227, 42);
            ButtonBack.TabIndex = 2;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonAddTemplate
            // 
            ButtonAddTemplate.Cursor = Cursors.Hand;
            ButtonAddTemplate.FlatAppearance.BorderColor = Color.FromArgb(77, 144, 254);
            ButtonAddTemplate.FlatAppearance.MouseDownBackColor = Color.FromArgb(77, 144, 254);
            ButtonAddTemplate.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonAddTemplate.FlatStyle = FlatStyle.Flat;
            ButtonAddTemplate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ButtonAddTemplate.Location = new Point(111, 576);
            ButtonAddTemplate.Name = "ButtonAddTemplate";
            ButtonAddTemplate.Size = new Size(227, 42);
            ButtonAddTemplate.TabIndex = 3;
            ButtonAddTemplate.Text = "Добавить шаблон";
            ButtonAddTemplate.UseVisualStyleBackColor = true;
            ButtonAddTemplate.Click += ButtonAddTemplate_Click;
            // 
            // ListViewTemplates
            // 
            ListViewTemplates.Alignment = ListViewAlignment.Left;
            ListViewTemplates.LabelWrap = false;
            ListViewTemplates.Location = new Point(11, 12);
            ListViewTemplates.MultiSelect = false;
            ListViewTemplates.Name = "ListViewTemplates";
            ListViewTemplates.Size = new Size(437, 558);
            ListViewTemplates.SmallImageList = ImageListTemplates;
            ListViewTemplates.TabIndex = 4;
            ListViewTemplates.UseCompatibleStateImageBehavior = false;
            ListViewTemplates.View = View.SmallIcon;
            ListViewTemplates.ItemActivate += ListViewTemplates_ItemActivate;
            // 
            // ImageListTemplates
            // 
            ImageListTemplates.ColorDepth = ColorDepth.Depth32Bit;
            ImageListTemplates.ImageSize = new Size(256, 256);
            ImageListTemplates.TransparentColor = Color.Transparent;
            // 
            // TemplateSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 678);
            Controls.Add(ListViewTemplates);
            Controls.Add(ButtonAddTemplate);
            Controls.Add(ButtonBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TemplateSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выбор шаблона";
            FormClosed += TemplateSelectionForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonBack;
        private Button ButtonAddTemplate;
        private ListView ListViewTemplates;
        private ImageList ImageListTemplates;
    }
}