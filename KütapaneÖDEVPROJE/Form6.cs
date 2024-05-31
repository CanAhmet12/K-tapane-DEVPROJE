using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütapaneÖDEVPROJE
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "Kütüphane Uygulması   Versiyon" + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
