using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oop_project
{
    public partial class Diyetgecmisi : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=diyetisyen_yonetim_sistemi; user ID=postgres; password= mari0809");

        public Diyetgecmisi()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from diyetgecmisi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut7 = new NpgsqlCommand("SELECT * FROM diyetgecmisi WHERE danisanid=@p1", baglanti);
            komut7.Parameters.AddWithValue("@p1", int.Parse(textBox5.Text));

            using (var reader = komut7.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show($"Danışan İd: {reader["danisanid"]},Baslangis Tarihi: {reader["baslangictarihi"]}, Bitis Tarihi: {reader["bitistarihi"]}, Sonuç: {reader["sonuc"]}");
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı.");
                }
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut12 = new NpgsqlCommand("update diyetgecmisi set baslangictarihi=@p1, bitistarihi=@p2, sounuc=@p3 where danisanid=@p4", baglanti);
            komut12.Parameters.AddWithValue("@p1", DateTime.Parse(textBox7.Text));
            komut12.Parameters.AddWithValue("@p2", DateTime.Parse(textBox2.Text));
            komut12.Parameters.AddWithValue("@p3", (textBox3.Text));
            komut12.Parameters.AddWithValue("@p4", int.Parse(textBox5.Text));

            komut12.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla guncellendi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
