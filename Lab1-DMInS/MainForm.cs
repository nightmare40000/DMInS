using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Shared;

namespace Lab1_DMInS
{
    public partial class MainForm : Form
    {
        private readonly IDisplayer _displayer;
        private readonly IClusterizer _clusterizer;

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

            _clusterizer = new Clusterizer();
            _displayer = new Displayer(settings);
        }

        /// <summary>
        /// Selecting file
        /// </summary>
        private void SelectFileButton_Click(object sender, EventArgs e)
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

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (!FormIsValid())
            {
                return;
            }
            
            var image = new Bitmap(_filePath);
            var correctedImage = image;
            if (FilterCheckBox.Checked)
            {
                correctedImage = ImageCorrector.CorrectBrightness(image);
            }


            var labels = new int[image.Width, image.Height];
            Bitmap blackAndWhiteImage = ImageCorrector.ConvertToBlackAndWhite(correctedImage, 
                                                                               int.Parse(BinarizationLevelTextBox.Text));
                    ImageCorrector.Labeling(blackAndWhiteImage, labels);

            _displayer.ShowOriginalImage(image);
            _displayer.ShowCorrectedImage(correctedImage);
            _displayer.ShowBlackAndWhiteImage(blackAndWhiteImage);


            var dictionary = FindLabelGroups(labels, image.Width, image.Height);
            var parameters = _clusterizer.CalculateParameters(dictionary.Values, ref labels);
            var classes = _clusterizer.Clusterize(parameters, int.Parse(ClassesCountComboBox.Text));
            var resultImage = blackAndWhiteImage;
            
            foreach (var cluster in classes)
            {
                var random = new Random();
                var color = Color.FromArgb(255, random.Next(255), random.Next(255), random.Next(255));
                resultImage = ImageCorrector.SetColorToClusters(resultImage, cluster, color);
            }

            _displayer.ShowResultImage(resultImage);
        }

        private bool FormIsValid()
        {
            int result;
            return !string.IsNullOrEmpty(_filePath) && int.TryParse(ClassesCountComboBox.Text, out result);
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
            
            if (Configuration.IsDiscard)
            {
                var result = dictionary.Where(item => item.Value.Pixels.Count > Configuration.DiscardPixelsCount)
                                       .ToDictionary(item => item.Key, item => item.Value);
                return result;
            }
            return dictionary;
        }
    }
}
