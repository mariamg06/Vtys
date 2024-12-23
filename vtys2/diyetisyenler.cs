/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Mariam Gasanova
**				ÖĞRENCİ NUMARASI.......: b231210567
**              DERSİN ALINDIĞI GRUP...: 1.C
****************************************************************************/

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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void details_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=diyetisyen_yonetim_sistemi; user ID=postgres; password= mari0809");
        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from diyetisyen";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into diyetisyen (ad, eposta, sifre) values (@p1, @p2, @p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox1.Text);
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            komut1.Parameters.AddWithValue("@p3", textBox3.Text);

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla eklendi.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete from diyetisyen where diyetisyenid = @p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textBox4.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Diyetisyen silme islemi basarili");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update diyetisyen set ad=@p1, eposta=@p2, sifre=@p3 where diyetisyenid=@p4", baglanti);
            komut3.Parameters.AddWithValue("@p1", textBox1.Text);
            komut3.Parameters.AddWithValue("@p2", textBox2.Text);
            komut3.Parameters.AddWithValue("@p3", textBox3.Text);
            komut3.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));

            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla guncellendi.");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("SELECT * FROM diyetisyen WHERE diyetisyenid=@p1", baglanti);
            komut4.Parameters.AddWithValue("@p1", int.Parse(textBox4.Text));

            using (var reader = komut4.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show($"Ad: {reader["ad"]}, Eposta: {reader["eposta"]}, Şifre: {reader["sifre"]}");
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı.");
                }
            }
            baglanti.Close();

        }
    }
}
