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
    public partial class Pracownicy : Form
    {
        public Pracownicy()
        {
            InitializeComponent();
        }

      

        private void Pracownicy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emosDataSet1.Pracownicy' table. You can move, or remove it, as needed.
            this.pracownicyTableAdapter.Fill(this.emosDataSet1.Pracownicy);
            // TODO: This line of code loads data into the 'pracownikSDataSet.emos_Pracownik' table. You can move, or remove it, as needed.

           

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.pracownicyBindingSource.Remove(pracownicyBindingSource.Current);


        }

       

       

      //  private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
      //  {
        //    if(e.KeyCode == Keys.Delete)
        //    {
         //       if (MessageBox.Show("Jesteś pewny, że chcesz usunąć dane pracownika?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         //          
         //   }
      //  }

        private void pracownicyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
           
               
               // MessageBox.Show("Dane zostały poprawnie dodane!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
