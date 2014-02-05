using System.Drawing;

namespace Lab1_DMInS
{
    public interface IDisplayer
    {
        void ShowOriginalImage(Bitmap originalImage);
        void ShowCorrectedImage(Bitmap treatedImage);

        void ShowBlackAndWhiteImage(Bitmap image);
        void ShowResultImage(Bitmap resultImage);
    }
}
