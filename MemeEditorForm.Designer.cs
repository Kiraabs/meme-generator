namespace meme_generator
{
    partial class MemeEditorForm
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
            PictureBoxImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // PictureBoxImage
            // 
            PictureBoxImage.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBoxImage.Location = new Point(12, 12);
            PictureBoxImage.Name = "PictureBoxImage";
            PictureBoxImage.Size = new Size(800, 600);
            PictureBoxImage.TabIndex = 0;
            PictureBoxImage.TabStop = false;
            // 
            // MemeEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 627);
            Controls.Add(PictureBoxImage);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MemeEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактор";
            ((System.ComponentModel.ISupportInitialize)PictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PictureBoxImage;
    }
}