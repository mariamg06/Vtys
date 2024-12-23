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

    public partial class Alerji : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=diyetisyen_yonetim_sistemi; user ID=postgres; password= mari0809");

        public Alerji()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from alerji";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut9 = new NpgsqlCommand("SELECT * FROM alerji WHERE danisanid=@p1", baglanti);
            komut9.Parameters.AddWithValue("@p1", int.Parse(textBox5.Text));

            using (var reader = komut9.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show($"Danışan ID: {reader["danisanid"]}, Alerji Türü: {reader["alerjituru"]}");
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
            NpgsqlCommand komut10 = new NpgsqlCommand("update alerji set alerjituru=@p1  where danisanid=@p2", baglanti);
            komut10.Parameters.AddWithValue("@p1", textBox7.Text);
            komut10.Parameters.AddWithValue("@p2", int.Parse(textBox5.Text));

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
