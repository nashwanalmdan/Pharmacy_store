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
    public partial class taqarer : Form
    {
        public taqarer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            taqarer_beanat s = new taqarer_beanat();
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            taqarer_mawad s = new taqarer_mawad();
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jdawl s = new jdawl();
            s.Show();
            this.Hide();
        }
    }
}
