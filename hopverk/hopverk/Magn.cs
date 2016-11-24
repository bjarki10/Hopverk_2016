using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hopverk
{
    public partial class Magn : Form
    {
        string Nafn = null;
        string Alager = null;

        public Magn()
        {
            InitializeComponent();
        }

        private void Magn_Load(object sender, EventArgs e)
        {
             label1.Text = "Hvesu marga viltu það er ";
             label2.Text = Alager + " til af þessa voru";
        }
        public string reciver (string nafn,string alager)
        {
            Nafn = nafn;
            Alager = alager;

            return Alager;
        }
    }
}
