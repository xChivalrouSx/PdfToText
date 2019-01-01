using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace PdfToText
{
    public partial class Form1 : Form
    {
        private const string NEW_LINE_FOR_REMOVE = "\r\n\r\n";
        private const string STRING_SPACE = " ";

        public Form1()
        {
            InitializeComponent();
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
            if(!tbx_file.Text.Equals(""))
            {
                string str = Ocr(tbx_file.Text);
                //Result result = new Result(newSTR);
                //result.Show();

                string removedSTR = RemoveNewLines(str);
                Result resultRemoved = new Result(removedSTR);
                resultRemoved.Show();

            }
        }

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
    }
}
