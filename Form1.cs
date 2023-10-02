using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuocHungThinh_19_ThiCSharp
{
    public partial class lblInfo : Form
    {
        public lblInfo()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "Thông tin");
        }

        private void giảiPhươngTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();
            gpt.Show();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DinhDang dd = new DinhDang();
            dd.Show();
        }

        private void lblInfo_Load_1(object sender, EventArgs e)
        {
            String hovaten = "Nguyen Quoc Hung Thinh";
            String mssv = "1223360204";
            String monthi = "Lập Trình Windows 2 - C#";

            lbl1.Text = "Họ và tên: " + hovaten;
            lbl1.Text += "\nMSSV: " + mssv;
            lbl1.Text += "\nNgày thi: " + System.DateTime.Now.ToString();
            lbl1.Text += "\n Môn thi: " + monthi;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
