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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-025GNLO;Initial Catalog=FinalCalismasi;Integrated Security=True");
        private void getir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Personel where id ='"+txtgetir.Text+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
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
        private void verilerigoster()
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
        private void up_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Personel set Ad='"+txtad.Text+ "', Soyad='"+ txtsad.Text + "', Maas='"+txtmaas.Text+"',[Dogum Tarihi]='"+txtdt.Text+"', Departman='"+txtdp.Text+"', Gorev='"+txtgrv.Text+"' where id ='" + txtgetir.Text + "'", baglanti);        
            SqlDataReader oku = komut.ExecuteReader(); 
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarıyla Tamamlandı..");
            verilerigoster();
        }
    }
}
