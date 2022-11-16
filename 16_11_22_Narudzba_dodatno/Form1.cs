using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_11_22_Narudzba_dodatno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        PoslanaNarudzba[] poslNarudzbe = new PoslanaNarudzba[3];
        int counter = 0;

        private void btnInputSave_Click_1(object sender, EventArgs e)
        {
            if (txtBrNar.Text == "")
            { MessageBox.Show("Unesite broj narudžbe");
              txtBrNar.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Unesite ime kupca");
                txtName.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Unesite količinu");
                txtKol.Focus();
            }
            else
            {
                lblReturn1.Text = "";                
                poslNarudzbe[counter] = new PoslanaNarudzba(Convert.ToInt32(txtBrNar.Text), txtName.Text, Convert.ToInt32(txtKol.Text));
                int broj = Convert.ToInt32(txtBrNar.Text);
                txtBrNar.Clear();
                txtBrNar.Focus();
                txtName.Clear();
                txtKol.Clear();
                    for(int i= 0; i < counter; i++)
                    {
                        if (broj == poslNarudzbe[i].BrojNarudzbe)
                        {
                            MessageBox.Show("Broj narudžbe već postoji.\nPonovite unos");
                            txtBrNar.Clear();
                            return;
                        }
                    }

                    counter++;
                    if (counter == poslNarudzbe.Length)
                    {
                        txtBrNar.Enabled = false;
                        txtName.Enabled = false;
                        txtKol.Enabled = false;
                        lblReturn1.Text = String.Empty;

                        Array.Sort(poslNarudzbe);
                        foreach (PoslanaNarudzba narudzba in poslNarudzbe)
                        {
                            lblReturn1.Text += narudzba.ToString() + "\n";
                        }
                    }
                

                

            }

            
           
        }
        void Usporedi(params Narudzba[] narudzbe)
        {
            for(int i = 0; i < narudzbe.Length; i++)
            {
                for(int j = i+1; j < narudzbe.Length; j++)
                {
                    if (narudzbe[i].Equals(narudzbe[j]))
                    {

                    }
                }
            }


        }

        
    }
}