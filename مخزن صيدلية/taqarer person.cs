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
    public partial class taqarer_beanat : Form
    {
        public taqarer_beanat()
        {
            InitializeComponent();
        }

        private void taqarer_beanat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.database1DataSet1.person);
            // TODO: This line of code loads data into the 'Database1DataSet2.beanat' table. You can move, or remove it, as needed.
            this.beanatTableAdapter.Fill(this.Database1DataSet2.beanat);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beanatTableAdapter.FillBy(Database1DataSet2.beanat, comboBox1.Text,
                dateTimePicker1.Value, dateTimePicker2.Value);
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            taqarer s = new taqarer();
            s.Show();
            this.Hide();
        }
    }
}
