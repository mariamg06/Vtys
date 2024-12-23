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
    public partial class Aktivite : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=diyetisyen_yonetim_sistemi; user ID=postgres; password= mari0809");

        public Aktivite()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from aktivite";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut7 = new NpgsqlCommand("SELECT * FROM aktivite WHERE danisanid=@p1", baglanti);
            komut7.Parameters.AddWithValue("@p1", int.Parse(textBox5.Text));

            using (var reader = komut7.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show($"Danışan İD: {reader["danisanid"]}, Aktivite Türü: {reader["aktiviteturu"]}, Süre: {reader["sure"]}, Kalori: {reader["yakilankalori"]}");
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
            NpgsqlCommand komut14 = new NpgsqlCommand("update aktivite set aktiviteturu=@p1, sure=@p2, yakilankalori=@p3 where danisanid=@p4", baglanti);
            komut14.Parameters.AddWithValue("@p1", textBox7.Text);
            komut14.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
            komut14.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
            komut14.Parameters.AddWithValue("@p4", int.Parse(textBox5.Text));

            komut14.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Aktivite başarıyla guncellendi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
