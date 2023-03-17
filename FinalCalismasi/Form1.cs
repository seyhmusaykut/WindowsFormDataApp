using System.Data.Sql;
using System.Data.SqlClient;
namespace FinalCalismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-025GNLO;Initial Catalog=FinalCalismasi;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            AnaEkran frm2 = new AnaEkran();
            frm2.Show();
        }
    }
}