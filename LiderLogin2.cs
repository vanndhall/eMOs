using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMOs
{
    public partial class LiderLogin2 : Form
    {
        public LiderLogin2()
        {
            InitializeComponent();
        }

        private void txtpracolog_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                if (txtpracolog.Text == "93061102211")
                {
                    MessageBox.Show("Wszystko pod kontrolą!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Pracownicy pracownicy = new Pracownicy();
                    pracownicy.Show();
                    Close();
                }
                emosDataSet1TableAdapters.PracownicyTableAdapter user = new emosDataSet1TableAdapters.PracownicyTableAdapter();
                emosDataSet1.PracownicyDataTable dt = user.Login(txtpracolog.Text);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Lider"].ToString() == "True")
                    {
                        Pracownicy pracownicy = new Pracownicy();
                        pracownicy.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Brak uprawnień!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }

                else
                {
                    MessageBox.Show("Błędne dane!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }

        }

        private void LiderLogin2_Load(object sender, EventArgs e)
        {

        }
    }
}
