namespace MemeGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonImageSelect = new Button();
            ButtonTemplateSelect = new Button();
            LabelOR = new Label();
            SuspendLayout();
            // 
            // ButtonImageSelect
            // 
            ButtonImageSelect.Cursor = Cursors.Hand;
            ButtonImageSelect.FlatAppearance.BorderColor = Color.FromArgb(77, 144, 254);
            ButtonImageSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(77, 144, 254);
            ButtonImageSelect.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonImageSelect.FlatStyle = FlatStyle.Flat;
            ButtonImageSelect.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            ButtonImageSelect.Location = new Point(121, 12);
            ButtonImageSelect.Name = "ButtonImageSelect";
            ButtonImageSelect.Size = new Size(297, 59);
            ButtonImageSelect.TabIndex = 0;
            ButtonImageSelect.Text = "Загрузить изображение";
            ButtonImageSelect.UseVisualStyleBackColor = true;
            ButtonImageSelect.Click += ButtonImageSelect_Click;
            // 
            // ButtonTemplateSelect
            // 
            ButtonTemplateSelect.Cursor = Cursors.Hand;
            ButtonTemplateSelect.FlatAppearance.BorderColor = Color.FromArgb(77, 144, 254);
            ButtonTemplateSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(77, 144, 254);
            ButtonTemplateSelect.FlatAppearance.MouseOverBackColor = Color.White;
            ButtonTemplateSelect.FlatStyle = FlatStyle.Flat;
            ButtonTemplateSelect.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            ButtonTemplateSelect.Location = new Point(121, 128);
            ButtonTemplateSelect.Name = "ButtonTemplateSelect";
            ButtonTemplateSelect.Size = new Size(297, 59);
            ButtonTemplateSelect.TabIndex = 1;
            ButtonTemplateSelect.Text = "Выбрать шаблон мема";
            ButtonTemplateSelect.UseVisualStyleBackColor = true;
            // 
            // LabelOR
            // 
            LabelOR.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LabelOR.Location = new Point(121, 74);
            LabelOR.Name = "LabelOR";
            LabelOR.Size = new Size(297, 51);
            LabelOR.TabIndex = 2;
            LabelOR.Text = "ИЛИ";
            LabelOR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 199);
            Controls.Add(LabelOR);
            Controls.Add(ButtonTemplateSelect);
            Controls.Add(ButtonImageSelect);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Генератор мемов";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonImageSelect;
        private Button ButtonTemplateSelect;
        private Label LabelOR;
    }
}
