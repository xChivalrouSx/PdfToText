using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;
using Xceed.Words.NET;

namespace PdfToText
{
    public partial class Main : Form
    {
        private const string NEW_LINE_FOR_REMOVE = "\r\n\r\n";
        private const string STRING_SPACE = " ";

        private const string CAN_NOT_CREATE_WORD = "Can not create a word file.";
        private const string ERROR_MORE_FILE = "Please drop only one file.";

        public Main()
        {
            InitializeComponent();
        }

        #region[ - Event Handlers - ]

        private void Main_Load(object sender, EventArgs e)
        {
            label_drag_drop.AllowDrop = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pdf Files|*.pdf";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(tbx_file, ofd.FileName);

                tbx_file.Text = ofd.FileName;
            }
        }

        private void btn_get_text_Click(object sender, EventArgs e)
        {
            if (!tbx_file.Text.Equals(""))
            {
                string str = Ocr(tbx_file.Text);
                //Result result = new Result(newSTR);
                //result.Show();

                string removedSTR = RemoveNewLines(str);
                Result resultRemoved = new Result(removedSTR);
                resultRemoved.Show();

            }
        }

        private void btn_save_word_Click(object sender, EventArgs e)
        {
            if (!tbx_file.Text.Equals(""))
            {
                string str = Ocr(tbx_file.Text);

                string removedSTR = RemoveNewLines(str);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents|*.doc";

                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CreateWordFile(sfd.FileName, removedSTR);
                }
            }
        }

        private void label_drag_drop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void label_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (fileList.Length > 1)
            {
                ShowMessage(ERROR_MORE_FILE);
                return;
            }

            foreach (string file in fileList)
            {
                string extension = Path.GetExtension(file);
                extension = extension.ToLower();
                if (extension.Equals(".pdf"))
                {
                    tbx_file.Text = file;
                }
            }
        }

        #endregion

        #region[ - Private Methods - ]

        private string Ocr(string path)
        {
            #region[ - IronOcr Default - ]

            //var Ocr = new AdvancedOcr()
            //{
            //    CleanBackgroundNoise = true,
            //    EnhanceContrast = true,
            //    EnhanceResolution = true,
            //    Language = IronOcr.Languages.English.OcrLanguagePack,
            //    Strategy = AdvancedOcr.OcrStrategy.Advanced,
            //    ColorSpace = AdvancedOcr.OcrColorSpace.Color,
            //    DetectWhiteTextOnDarkBackgrounds = true,
            //    InputImageType = AdvancedOcr.InputTypes.Document,
            //    RotateAndStraighten = true,
            //    ReadBarCodes = true,
            //    ColorDepth = 4
            //};

            #endregion

            #region[ - IronOcr Default - ]

            var Ocr = new AdvancedOcr()
            {
                CleanBackgroundNoise = false,
                EnhanceContrast = false,
                EnhanceResolution = false,
                Language = IronOcr.Languages.English.OcrLanguagePack,
                Strategy = IronOcr.AdvancedOcr.OcrStrategy.Fast,
                ColorSpace = AdvancedOcr.OcrColorSpace.GrayScale,
                DetectWhiteTextOnDarkBackgrounds = false,
                InputImageType = AdvancedOcr.InputTypes.Document,
                RotateAndStraighten = false,
                ReadBarCodes = false,
                ColorDepth = 4
            };

            #endregion


            var results = Ocr.Read(path);
            return results.Text;
        }

        private string RemoveNewLines(string str)
        {
            str = str.Replace(NEW_LINE_FOR_REMOVE, "%%SPACE%%");
            str = str.Replace("\r\n", " ");
            str = str.Replace("%%SPACE%%", NEW_LINE_FOR_REMOVE);

            return str;
        }

        private void CreateWordFile(string path, string text)
        {
            try
            {
                DocX doc = DocX.Create(path);
                doc.InsertParagraph(text);
                doc.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ShowMessage(CAN_NOT_CREATE_WORD);
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }





        #endregion

        
    }
}
