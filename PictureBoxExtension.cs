namespace MemeGenerator
{
    /// <summary>
    /// Представляет методы расширения для PictureBox.
    /// </summary>
    public static class PictureBoxExtension
    {
        /// <summary>
        /// Выполняет масштабирование изображения внутри PictureBox, относительно его размеров.
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="img"></param>
        public static void ScaleImage(this PictureBox pictureBox, Image img)
        {
            pictureBox.Image = new Bitmap(img, ScaledSize(pictureBox));
        }

        /// <summary>
        /// Вычисляет размер изображения, после его масштабирования, относительно клиентской области PictureBox.
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <returns></returns>
        public static Size ScaledSize(this PictureBox pictureBox)
        {
            var containerSize = pictureBox.ClientSize;
            var originalImageSize = pictureBox.Size;
            var containerAspectRatio = (float)containerSize.Height / (float)containerSize.Width;
            var imageAspectRatio = (float)originalImageSize.Height / (float)originalImageSize.Width;
            var scaled = new Size();

            if (containerAspectRatio > imageAspectRatio)
            {
                scaled.Width = containerSize.Width;
                scaled.Height = (int)(imageAspectRatio * (float)containerSize.Width);
            }
            else
            {
                scaled.Height = containerSize.Height;
                scaled.Width = (int)((1.0f / imageAspectRatio) * (float)containerSize.Height);
            }

            return scaled;
        }
    }
}
