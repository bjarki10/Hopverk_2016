using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hopverk
{
    public partial class Form1 : Form
    {


        List<int> listi2 = new List<int>();

        Random rnd = new Random();
        List<int> listi = new List<int>();

        List<string> linur = new List<string>();

        string[] arr = new string[4];


        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public Form1()
        {
            InitializeComponent();

            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            li_lager.Clear();
            li_lager.Columns.Add("Nafn", 200);
            li_lager.Columns.Add("Voruflokkur", 120);
            li_lager.Columns.Add("Verd", 60);
            li_lager.Columns.Add("ALager", 60);

            ListViewItem itm;

            linur = gagnagrunnur.LesautSQLToflu();

            try
            {

                foreach (string lin in linur)
                {
                    string[] linaUrLista = lin.Split(':');
                    string Nafn = linaUrLista[0];
                    string Voruflokkur = linaUrLista[1];
                    string Verd = linaUrLista[2];
                    string ALager = linaUrLista[3];

                    arr[0] = Nafn;
                    arr[1] = Voruflokkur;
                    arr[2] = Verd;
                    arr[3] = ALager;


                    itm = new ListViewItem(arr);
                    li_lager.Items.Add(itm);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            li_lager.Clear();
            li_lager.Columns.Add("Nafn", 200);
            li_lager.Columns.Add("Voruflokkur", 120);
            li_lager.Columns.Add("Verd", 60);
            li_lager.Columns.Add("ALager", 60);

            ListViewItem itm;

            linur = gagnagrunnur.LesautSQLToflu();

            try
            {

                foreach (string lin in linur)
                {
                    string[] linaUrLista = lin.Split(':');
                    string Nafn = linaUrLista[0];
                    string Voruflokkur = linaUrLista[1];
                    string Verd = linaUrLista[2];
                    string ALager = linaUrLista[3];
                    if (linaUrLista[0].ToLower().StartsWith(textBox1.Text))
                    {
                        arr[0] = Nafn;
                        arr[1] = Voruflokkur;
                        arr[2] = Verd;
                        arr[3] = ALager;


                        itm = new ListViewItem(arr);
                        li_lager.Items.Add(itm);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

