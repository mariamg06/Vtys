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

namespace oop_project
{
    public partial class randevu : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=diyetisyen_yonetim_sistemi; user ID=postgres; password= mari0809");

        public randevu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from randevu";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut11 = new NpgsqlCommand("SELECT * FROM randevu WHERE danisanid=@p1", baglanti);
            komut11.Parameters.AddWithValue("@p1", int.Parse(textBox5.Text));

            using (var reader = komut11.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show($"Danışan ID: {reader["danisanid"]}, DiyetisyenID: {reader["diyetisyenid"]}, Durum: {reader["durum"]}, Notlar: {reader["notlar"]}, Tarih: {reader["tarih"]}");
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
            NpgsqlCommand komut10 = new NpgsqlCommand("update randevu set notlar=@p2, durum=@p1 where danisanid=@p3", baglanti);
            komut10.Parameters.AddWithValue("@p1", textBox7.Text);
            komut10.Parameters.AddWithValue("@p2", textBox1.Text);
            komut10.Parameters.AddWithValue("@p3", int.Parse(textBox5.Text));

            komut10.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Icerik başarıyla guncellendi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
