using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using Google.Cloud.Vision.V1;
using System.Windows.Forms;
using System.IO;

namespace ImageToTextConverter
{
    public partial class Form1 : Form
    {
        // To store multiple file names
        public List<string> filePaths = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseAllFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            openFileDialog.Multiselect = true;
            string fileNames = "";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames.ToList();
                foreach (string fileName in openFileDialog.FileNames)
                {
                    string[] fileNameArray = fileName.Split('\\');
                    string currentFile = fileNameArray[fileNameArray.Length - 1];
                    fileNames = fileNames + currentFile + " ";
                    this.filePathTxt.Text = fileNames;
                }
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            foreach (string file in filePaths)
            {
                System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\v-rballali\\source\\repos\\Google_OCR_Image_To_Text_Software\\Google_OCR_Image_To_Text_Software\\ServiceAccountApiKey\\eastern-stock-312205-3d738d0f8f0b.json");

                string[] fileNameArray = file.Split('\\');
                string currentFile = fileNameArray[fileNameArray.Length - 1];
                using (Bitmap bitmap = (Bitmap)System.Drawing.Image.FromFile(file))
                {
                    using (Bitmap newBitmap = new Bitmap(bitmap))
                    {
                        newBitmap.SetResolution(4000, 4000);
                        newBitmap.Save(currentFile + "4000.jpg", ImageFormat.Png);
                    }
                }

                var currentImage = Google.Cloud.Vision.V1.Image.FromFile(file);
                var client = ImageAnnotatorClient.Create();
                var response = client.DetectDocumentText(currentImage);

                var saveFilePath = "C:\\Users\\v-rballali\\Desktop\\" + currentFile.Split('.')[0] + ".txt";
                File.Create(saveFilePath).Close();

                using (StreamWriter writer = new StreamWriter(saveFilePath))
                {
                    writer.Write(response.Text);
                    writer.Close();
                }


            }
            //  ww.Hide();
            MessageBox.Show("Success");
        }
    }
}
