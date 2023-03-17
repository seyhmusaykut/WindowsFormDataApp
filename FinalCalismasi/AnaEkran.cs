using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCalismasi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Form3 up = new Form3();
            up.Show();
        }

        private void del_Click(object sender, EventArgs e)
        {
            Sil de = new Sil();
            de.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void list_Click(object sender, EventArgs e)
        {
            List liste = new List();
            liste.Show();
        }

        private void rp_Click(object sender, EventArgs e)
        {
            Report rpp = new Report();
            rpp.Show();
        }
    }
}
