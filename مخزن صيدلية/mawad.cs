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
    public partial class mawad : Form
    {
        public mawad()
        {
            InitializeComponent();
        }

        private void mawadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mawadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet3);

        }

        private void mawad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.mawad' table. You can move, or remove it, as needed.
            this.mawadTableAdapter.Fill(this.database1DataSet3.mawad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jdawl s = new jdawl();
            s.Show();
            this.Hide();
        }

        private void name_of_thingTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                made_inTextBox.Focus();
            }
        }

        private void made_inTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                colorTextBox.Focus();
            }
        }

        private void colorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                moasafatTextBox.Focus();
            }
        }

        private void moasafatTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                markaTextBox.Focus();
            }
        }

        private void markaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nodTextBox.Focus();
            }
        }
    }
}
