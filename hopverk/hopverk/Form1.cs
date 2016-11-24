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
        
        string karfa;

        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();

        Magn magn = new Magn();
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
            li_korfa.Columns.Add("Nafn", 200);
            li_korfa.Columns.Add("Voruflokkur", 120);
            li_korfa.Columns.Add("Verd", 60);
            li_korfa.Columns.Add("ALager", 60);

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

        private void bt_korfu_Click(object sender, EventArgs e)
        {
            

            ListViewItem itm;
            string test = null;
            string[] linaUrLista = karfa.Split(':');
            string Nafn = linaUrLista[0];
            string Voruflokkur = linaUrLista[1];
            string Verd = linaUrLista[2];
            string ALager = linaUrLista[3];
            test = magn.reciver(Nafn,ALager);
            magn.Show();
            
                arr[0] = Nafn;
                arr[1] = Voruflokkur;
                arr[2] = Verd;
                arr[3] = ALager;


                itm = new ListViewItem(arr);
                li_korfa.Items.Add(itm);
            
        }
        private void li_lager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (li_lager.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intSelectIndex = li_lager.SelectedIndices[0];
            if (intSelectIndex >= 0)
            {
                karfa = li_lager.SelectedItems[0].SubItems[0].Text + ":" + li_lager.SelectedItems[0].SubItems[1].Text + ":" + li_lager.SelectedItems[0].SubItems[2].Text + ":" + li_lager.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void li_korfa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void bt_eda_Click(object sender, EventArgs e)
        {
            for (int i = li_korfa.Items.Count - 1; i >= 0; i--)
            {
                if (li_korfa.Items[i].Selected)
                {
                    li_korfa.Items[i].Remove();
                }
            }
        }

        private void bt_Check_out_Click(object sender, EventArgs e)
        {
            Check_out checkout = new Check_out();
            checkout.Show();
        }
    }
}

