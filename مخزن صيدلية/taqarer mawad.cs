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
    public partial class taqarer_mawad : Form
    {
        public taqarer_mawad()
        {
            InitializeComponent();
        }

        private void taqarer_mawad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet2.beanat' table. You can move, or remove it, as needed.
            this.beanatTableAdapter.Fill(this.Database1DataSet2.beanat);
            // TODO: This line of code loads data into the 'Database1DataSet3.mawad' table. You can move, or remove it, as needed.
            this.mawadTableAdapter.Fill(this.Database1DataSet3.mawad);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mawadTableAdapter.FillBy(Database1DataSet3.mawad, comboBox1.Text);
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
