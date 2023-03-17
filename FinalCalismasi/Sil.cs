using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace FinalCalismasi
{
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-025GNLO;Initial Catalog=FinalCalismasi;Integrated Security=True");
        private void delete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Personel where id='" + txtgetir.Text + "'", baglanti);
            baglanti.Close();
            MessageBox.Show("Kayıt Silme Başarılı");
            Application.Exit();
        }

        private void getir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Personel where id ='" + txtgetir.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtad.Text = oku["Ad"].ToString();
                txtsad.Text = oku["Soyad"].ToString();
                txtmaas.Text = oku["Maas"].ToString();
                txtdt.Text = oku["Dogum Tarihi"].ToString();
                txtdp.Text = oku["Departman"].ToString();
                txtgrv.Text = oku["Gorev"].ToString();
            }
            baglanti.Close();
        }
    }
}
