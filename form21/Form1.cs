using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if(cbKirmizi.Checked == true)
            {
                lblYaz.Text = "Kirmizi Yapıldı";
                this.BackColor = Color.Red;
            }
            else
            {
                lblYaz.Text = "Kirmizi Kaldırıldı";
                this.BackColor = Color.Red;
            }
        }
    }
}
