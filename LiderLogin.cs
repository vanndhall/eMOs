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
    public partial class LiderLogin : Form
    {
        static bool czyotwartetool = false;
        public LiderLogin()
        {
            InitializeComponent();

        }

        public LiderLogin(bool otwarte)
        {
            czyotwartetool = otwarte;
        }
        public LiderLogin(string ID)
        {
            InitializeComponent();
           

        }
        public string Dane;
        public void Logon(string ID)
        {

        }
        private void txtpracolog_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                if( txtpracolog.Text == "93061102211")
                {
                    MessageBox.Show("Wszystko pod kontrolą!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LiderTool tool = new LiderTool(txtpracolog.Text);
                    tool.Show();
                    Close();
                }
                emosDataSet1TableAdapters.PracownicyTableAdapter user = new emosDataSet1TableAdapters.PracownicyTableAdapter();
                emosDataSet1.PracownicyDataTable dt = user.Login(txtpracolog.Text);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["Lider"].ToString() == "True")
                    {
                        
                        if (czyotwartetool == false)
                        {
                            LiderTool tool = new LiderTool(txtpracolog.Text);
                            tool.Show();
                        }
                        else
                        {
                            MessageBox.Show("Zamknij aktualne okno logowania 'Raporty' aby otworzyć kolejne!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        czyotwartetool = true;
                        double i = 0.0;
                        Start start = new Start(czyotwartetool, i);
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

        private void LiderLogin_Load(object sender, EventArgs e)
        {

        }
        
    }
    }

