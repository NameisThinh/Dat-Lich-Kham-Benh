using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class formGioiThieu : Form
    {
        public formGioiThieu()
        {
            InitializeComponent();
        }


        private void formGioiThieu_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hoanmysaigonclinic.com/");
        }

        private void btnFb_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.facebook.com/HoanMySaiGonClinicOfficial/");
        }

        private void btnGG_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hoanmysaigonclinic.com/");
        
        }

        private void btnYT_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/channel/UC08MpEOYg9y1XeSWY8nxmpg");
        }

        private void btnITG_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hoanmysaigonclinic.com/");
        }
    }
}
