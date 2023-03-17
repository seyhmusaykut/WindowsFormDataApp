using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace FinalCalismasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-025GNLO;Initial Catalog=FinalCalismasi;Integrated Security=True");
        private void add_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if(txtad.Text=="" && txtsad.Text=="" && txtmaas.Text=="" && txtdt.Text=="" && txtdp.Text=="" && txtgrv.Text=="")
            {
                MessageBox.Show("Boş Bıraktığınız Yerleri Kontrol Ediniz..");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into Personel (Ad,Soyad,Maas,[Dogum Tarihi],Departman,Gorev) values ('" + txtad.Text + "','" + txtsad.Text + "','" + txtmaas.Text + "','" + txtdt.Text + "','" + txtdp.Text + "','" + txtgrv.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Kaydedildi..");
            }
            baglanti.Close();
        }
    }
}
