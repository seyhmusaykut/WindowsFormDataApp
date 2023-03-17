using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace FinalCalismasi
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-025GNLO;Initial Catalog=FinalCalismasi;Integrated Security=True");
        private void verigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Personel", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Maas"].ToString());
                ekle.SubItems.Add(oku["Dogum Tarihi"].ToString());
                ekle.SubItems.Add(oku["Departman"].ToString());
                ekle.SubItems.Add(oku["Gorev"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("select*from Personel where Ad like '%" + textBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Maas"].ToString());
                ekle.SubItems.Add(oku["Dogum Tarihi"].ToString());
                ekle.SubItems.Add(oku["Departman"].ToString());
                ekle.SubItems.Add(oku["Gorev"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
