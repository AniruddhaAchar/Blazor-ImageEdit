using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Processing;
using System;

namespace blazorImageProcessing
{
    public class ImageProcessing : IDisposable
    {
        private Image originalImage;
        private Image editImage;
        private IImageFormat imageFormat;

        public ImageProcessing(Image image, IImageFormat imageFormat)
        {
            this.imageFormat = imageFormat;
            this.originalImage = image;
            this.editImage = image;
        }

        public string getBase64String()
        {
            return editImage.ToBase64String(imageFormat);
        }

        public Image GetImage()
        {
            return this.editImage;
        }

        public void UpdateImage(Image image)
        {
            this.editImage = image;
        }

        public void ResetImage()
        {
            editImage = originalImage;
        }

        public void Dispose()
        {
            originalImage.Dispose();
            editImage.Dispose();
        }
    }
}
