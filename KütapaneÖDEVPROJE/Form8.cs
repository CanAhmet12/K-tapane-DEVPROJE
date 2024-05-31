using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütapaneÖDEVPROJE
{
    public partial class Form8 : Form
    {
        private string Adı;
        private string Soyadı;
        private string Meslek;
        private string Şehir;
        private string DoğumTarihi;

        public Form8()
        {
            InitializeComponent();
        }

        public Form8(string Adı, string Soyadı, string Meslek, string Şehir, string DoğumTarihi)
        {
            txtAdi.Text = Adı;
            txtSoyadi.Text = Soyadı;
            txtmeslek.Text= Meslek;
            txtşehir.Text = Şehir;
            txtdtarihi.Text = DoğumTarihi;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
          
        }
    }
}
