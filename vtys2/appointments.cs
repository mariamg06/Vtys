
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
    public partial class Appointments : Form
    {

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=diyetisyen_yonetim_sistemi; user ID=postgres; password= mari0809");

        public Appointments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Appointments_LocationChanged(object sender, EventArgs e)
        {

        }

        private void Appointments_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Appointments_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from danisan";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("insert into danisan (ad, eposta, telefon,yas, kilo, boy, diyetisyenid) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglanti);
            komut5.Parameters.AddWithValue("@p1", textBox7.Text);
            komut5.Parameters.AddWithValue("@p2", textBox8.Text);
            komut5.Parameters.AddWithValue("@p3", textBox4.Text);
            komut5.Parameters.AddWithValue("@p4", int.Parse(textBox1.Text));
            komut5.Parameters.AddWithValue("@p5", double.Parse(textBox2.Text));
            komut5.Parameters.AddWithValue("@p6", double.Parse(textBox3.Text));
            komut5.Parameters.AddWithValue("@p7", int.Parse(textBox6.Text));

            komut5.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla eklendi.");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut6 = new NpgsqlCommand("update danisan set ad=@p1, eposta=@p2, telefon=@p3,yas=@p4, kilo=@p5, boy=@p6, diyetisyenid=@p7 where danisanid=@p8", baglanti);
            komut6.Parameters.AddWithValue("@p1", textBox7.Text);
            komut6.Parameters.AddWithValue("@p2", textBox8.Text);
            komut6.Parameters.AddWithValue("@p3", textBox4.Text);
            komut6.Parameters.AddWithValue("@p4", int.Parse(textBox1.Text));
            komut6.Parameters.AddWithValue("@p5", double.Parse(textBox2.Text));
            komut6.Parameters.AddWithValue("@p6", double.Parse(textBox3.Text));
            komut6.Parameters.AddWithValue("@p7", int.Parse(textBox6.Text));
            komut6.Parameters.AddWithValue("@p8", int.Parse(textBox5.Text));

            komut6.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla guncellendi.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut7 = new NpgsqlCommand("SELECT * FROM danisan WHERE danisanid=@p1", baglanti);
            komut7.Parameters.AddWithValue("@p1", int.Parse(textBox5.Text));

            using (var reader = komut7.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show($"Ad: {reader["ad"]}, Eposta: {reader["eposta"]}, Telefon: {reader["telefon"]}, Yas: {reader["yas"]}, Kilo: {reader["kilo"]}, Boy: {reader["boy"]}");
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı.");
                }
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut8 = new NpgsqlCommand("Delete from danisan where danisanid = @p1", baglanti);
            komut8.Parameters.AddWithValue("@p1", int.Parse(textBox5.Text));
            komut8.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Danisan silme islemi basarili");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
