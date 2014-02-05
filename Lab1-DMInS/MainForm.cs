using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Shared;

namespace Lab1_DMInS
{
    public partial class MainForm : Form
    {
        private readonly IDisplayer _displayer;
        private string _filePath;

        public MainForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            var settings = new DisplayerFields
                {
                    BalckAndWhitePictureBox = BlackAndWhitePictureBox,
                    CorrectedBrightnessPictureBox = CorrectedBrightnessPictureBox,
                    ResultPictureBox = ResultPictureBox,
                    OriginalPictureBox = OriginalImagePictureBox
                };

            _displayer = new Displayer(settings);
        }

        /// <summary>
        /// Selecting file
        /// </summary>
        private void SelectFileButton_Click(object sender, System.EventArgs e)
        {
            var fileDialog = new OpenFileDialog
                {
                    Title = @"Select Image",
                    Filter = @"JPEG|*.jpg",
                    InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath)
                };

            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show(@"Error when open file");
            }

            _filePath = fileDialog.FileName;
            FilePathLabel.Text = _filePath;
        }

        private void GoButton_Click(object sender, System.EventArgs e)
        {
            var image = new Bitmap(_filePath);
            var correctedImage = ImageCorrector.CorrectBrightness(image);
            var blackAndWhiteImage = ImageCorrector.ConvertToBlackAndWhite(correctedImage, int.Parse(BinarizationLevelTextBox.Text));
            var labels = new int[blackAndWhiteImage.Width,blackAndWhiteImage.Height];
            ImageCorrector.Labeling(blackAndWhiteImage, labels);

            _displayer.ShowOriginalImage(image);
            _displayer.ShowCorrectedImage(correctedImage);
            _displayer.ShowBlackAndWhiteImage(blackAndWhiteImage);

            var dictionary = FindLabelGroups(labels, image.Width, image.Height);




            //           _displayer.ShowResultImage(resultImage);
        }

        private static Dictionary<int, LabelGroup> FindLabelGroups(int[,] labels, int width, int height)
        {
            var dictionary = new Dictionary<int, LabelGroup>();
            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    if (labels[i, j] == 0)
                    {
                        continue;
                    }

                    LabelGroup labelGroup;
                    var item = labels[i, j];

                    if (!dictionary.TryGetValue(item, out labelGroup))
                    {
                        labelGroup = new LabelGroup { Label = item, Pixels = new List<Coords>() };
                        dictionary.Add(item, labelGroup);
                    }

                    if (labelGroup != null)
                    {
                        labelGroup.Pixels.Add(new Coords(i, j));
                    }
                }
            }

            return dictionary;
        }
    }
}
