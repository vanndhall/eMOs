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
    public partial class LiderTool : Form
    {
        public LiderTool()
        {
            InitializeComponent();
        }

        public LiderTool(string UserName)
        {
            InitializeComponent();
            emosDataSet1TableAdapters.PracownicyTableAdapter user = new emosDataSet1TableAdapters.PracownicyTableAdapter();
            emosDataSet1.PracownicyDataTable dt = user.Login(UserName);
            if (dt.Rows.Count > 0)
            {
             LogLider.Text = dt.Rows[0]["pr_Imie"].ToString() + " " + dt.Rows[0]["pr_Nazwisko"].ToString();
            }
            else
            { LogLider.Text = "Programista"; }
        }

        private void LiderTool_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emosDataSet1.Pracownicy' table. You can move, or remove it, as needed.
            //this.pracownicyTableAdapter.Fill(this.emosDataSet1.Pracownicy);
            // TODO: This line of code loads data into the 'emosDataSet1.MoOperacje' table. You can move, or remove it, as needed.
            this.moOperacjeTableAdapter.FillByLider(this.emosDataSet1.MoOperacje);
            Edit(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LiderLogin2 log2 = new LiderLogin2();
            log2.Show();
           
        }

        private void pracownicyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pracownicyBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.emosDataSet1);
                MessageBox.Show("Dane zostały poprawnie dodane!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.moOperacjeTableAdapter.FillByLider(this.emosDataSet1.MoOperacje);
        }

        private void Edit(bool value)
        {
            txtid.Enabled = value;
            txtpracownik.Enabled = value;
            txtprodukt.Enabled = value;
            txtmo.Enabled = value;
            txtwc.Enabled = value;
            txtstart.Enabled = value;
            txtstop.Enabled = value;
            txtczas.Enabled = value;  
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                Edit(true);
                emosDataSet1.MoOperacje.AddMoOperacjeRow(emosDataSet1.MoOperacje.NewMoOperacjeRow());
                moOperacjeBindingSource.MoveLast();
                txtid.Focus();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emosDataSet1.MoOperacje.RejectChanges();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            panel1.Enabled = true;
            Edit(true);
            txtid.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edit(false);
            moOperacjeBindingSource.ResetBindings(false);
            panel1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                txtlider.Text = LogLider.Text;
                txtdataedycji.Text = DateTime.Now.ToString(); 
                Edit(false);
                moOperacjeBindingSource.EndEdit();
                moOperacjeTableAdapter.Update(emosDataSet1.MoOperacje);
                dataGridView1.Refresh();
                emosDataSet1.MoOperacje.AddMoOperacjeRow(emosDataSet1.MoOperacje.NewMoOperacjeRow());
               // moOperacjeBindingSource.MoveLast();
                panel1.Enabled = false;
                MessageBox.Show("Dane zostały pomyślnie dodane do bazy danych!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emosDataSet1.MoOperacje.RejectChanges();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)13)//enter
            {
                if (MessageBox.Show("Jesteś pewny, że chcesz usunąć Raport?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    moOperacjeBindingSource.RemoveCurrent();
                }

            }
        }
        /*
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    moOperacjeBindingSource.Filter = string.Format("MOop_id = '{0}' OR MOop_idPracownika LIKE'*{1}*' OR MOop_produkt LIKE '*{2}*' OR MOop_NumerMO LIKE '*{3}*' OR MOop_idZlecenia LIKE '*{4}*' OR MOop_dataStart LIKE '*{5}*' OR MOop_dataKoniec LIKE '*{6}*' OR MOop_czasTrwania LIKE '*{7}*' OR MOop_Edycja LIKE '*{8}*' OR MOop_Data_Edycji LIKE '*{9}*'", txtid,txtpracownik,txtprodukt,txtmo,txtwc,txtstart,txtstop,txtczas,txtlider,txtdataedycji);
                }
                else
                  moOperacjeBindingSource.Filter = string.Empty;
            
            }
        }*/
        private void LiderTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool oknootwarte = false;
            var res = MessageBox.Show(this, "Zamknąć LiderTool?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res != DialogResult.Yes)
            {
                
                
                e.Cancel = true;

                return;
            }
            LiderLogin login = new LiderLogin(oknootwarte);
            oknootwarte = false;
            double i = 0.0;
            Start start = new Start(oknootwarte, i);

        }
    }


}
