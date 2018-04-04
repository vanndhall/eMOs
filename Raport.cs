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
    public partial class Raport : Form
    {
        public Raport()
        {
            InitializeComponent();
        }

        private void Raport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emosDataSet1.MoOperacje' table. You can move, or remove it, as needed.
            this.MoOperacjeTableAdapter.FillByData(this.emosDataSet1.MoOperacje, dateTimePicker1.Value, dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Pracownik")
            {
                this.MoOperacjeTableAdapter.FillByPracownik(this.emosDataSet1.MoOperacje, dateTimePicker1.Value, dateTimePicker2.Value, textBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            if (comboBox1.Text == "Produkt")
            {
                this.MoOperacjeTableAdapter.FillByProdukt(this.emosDataSet1.MoOperacje, dateTimePicker1.Value, dateTimePicker2.Value, textBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            if (comboBox1.Text == "MO's")
            {
                this.MoOperacjeTableAdapter.FillByMO(this.emosDataSet1.MoOperacje, dateTimePicker1.Value, dateTimePicker2.Value, textBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            if (comboBox1.Text == "Operacja")
            {
                this.MoOperacjeTableAdapter.FillByOperacja(this.emosDataSet1.MoOperacje, dateTimePicker1.Value, dateTimePicker2.Value, textBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            if (comboBox1.Text == "Edycja")
            {
                this.MoOperacjeTableAdapter.FillByEdycja(this.emosDataSet1.MoOperacje, dateTimePicker1.Value, dateTimePicker2.Value, textBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            if (comboBox1.Text == "")
            {
                this.MoOperacjeTableAdapter.FillByData(this.emosDataSet1.MoOperacje, dateTimePicker1.Value, dateTimePicker2.Value);
                this.reportViewer1.RefreshReport();
            }
        }
        private void Raport_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show(this, "Czy chcesz zakończyć aplikacje? Uwaga wszystkie niezapisane raporty zostaną utracone!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res != DialogResult.Yes)
            {


                e.Cancel = true;

                return;
            }
            bool oknootwarte = false;
            int i = 1;
            Start menu = new Start(oknootwarte, i);

        }
    }
}
