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
    public partial class person : Form
    {
        public person()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void person_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.database1DataSet1.person);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jdawl s = new jdawl();
            s.Show();
            this.Hide();
        }

        private void personTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addressTextBox.Focus();
            }
        }

        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                emaillTextBox.Focus();
            }
        }

        private void emaillTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mobileTextBox.Focus();
            }
        }

        private void mobileTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nodTextBox.Focus();
            }
        }
    }
}
