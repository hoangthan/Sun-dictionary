using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary1
{
    public partial class ViDu : Form
    {
        public ViDu(string text)
        {
            InitializeComponent();
            this.lbViDu.Text = "• " + text;
        }
    }
}
