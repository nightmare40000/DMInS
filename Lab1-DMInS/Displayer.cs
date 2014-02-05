using System.Drawing;
using System.Windows.Forms;
using Shared;

namespace Lab1_DMInS
{
    public class Displayer : IDisplayer
    {
        private readonly PictureBox _originalPictureBox;
        private readonly PictureBox _correctedBrightnessPictureBox;
        private readonly PictureBox _balckAndWhitePictureBox;
        private readonly PictureBox _resultPictureBox;
        
        public Displayer()
        {
        }

        public Displayer(DisplayerFields settings)
        {
            _originalPictureBox = settings.OriginalPictureBox;
            _resultPictureBox = settings.ResultPictureBox;
            _correctedBrightnessPictureBox = settings.CorrectedBrightnessPictureBox;
            _balckAndWhitePictureBox = settings.BalckAndWhitePictureBox;
        }

        public void ShowOriginalImage(Bitmap originalImage)
        {
            _originalPictureBox.Image = originalImage;
        }

        public void ShowCorrectedImage(Bitmap correctedImage)
        {
            _correctedBrightnessPictureBox.Image = correctedImage;
        }

        public void ShowBlackAndWhiteImage(Bitmap blackAndWhiteImage)
        {
            _balckAndWhitePictureBox.Image = blackAndWhiteImage;
        }

        public void ShowResultImage(Bitmap resultImage)
        {
            _resultPictureBox.Image = resultImage;
        }
    }
}
