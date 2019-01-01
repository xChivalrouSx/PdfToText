using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfToText
{
    public partial class Result : Form
    {
        public Result(string context)
        {
            InitializeComponent();

            tbx_context.Text = context;
        }
    }
}
