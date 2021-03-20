using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace مخزن_صيدلية
{
    public partial class beanat : Form
    {
        public beanat()
        {
            InitializeComponent();
        }

        private void beanatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.beanatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet2);

        }

        private void beanat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.mawad' table. You can move, or remove it, as needed.
            this.mawadTableAdapter.Fill(this.database1DataSet3.mawad);
            // TODO: This line of code loads data into the 'database1DataSet1.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.database1DataSet1.person);
            // TODO: This line of code loads data into the 'database1DataSet2.beanat' table. You can move, or remove it, as needed.
            this.beanatTableAdapter.Fill(this.database1DataSet2.beanat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jdawl s = new jdawl();
            s.Show();
            this.Hide();
        }

        private void name_of_personTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void name_of_thingTextBox_KeyDown(object sender, KeyEventArgs e)
        {
         
            
        }

        private void noTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateDateTimePicker1.Focus();
            }
        }

        private void dateDateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nodTextBox1.Focus();
            }
        }
    }
}
