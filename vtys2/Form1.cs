/****************************************************************************
**					SAKARYA ?N?VERS?TES?
**				B?LG?SAYAR VE B?L???M B?L?MLER? FAK?LTES?
**				    B?LG?SAYAR M?HEND?SL??? B?L?M?
**				   NESNEYE DAYALI PROGRAMLAMA DERS?
**					2023-2024 BAHAR D?NEM?
**	
**				?DEV NUMARASI..........: Proje
**				??RENC? ADI............: Mariam Gasanova
**				??RENC? NUMARASI.......: b231210567
**              DERS?N ALINDI?I GRUP...: 1.C
****************************************************************************/



namespace oop_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            randevu randevu = new randevu();
            randevu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Diyetplani diyetplani = new Diyetplani();
            diyetplani.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Aktivite aktivite = new Aktivite();
            aktivite.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Alerji alerji = new Alerji();
            alerji.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Diyetgecmisi diyetgecmisi = new Diyetgecmisi();
            diyetgecmisi.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Mesaj mesaj = new Mesaj();
            mesaj.Show();
        }
    }
}
