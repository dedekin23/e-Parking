using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TubesKPL
{
    public partial class Report : Form
    {
        // Inisialisasi Variabel.
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"../../../json/Report.json";
        List<ReportModel> reportModel = new List<ReportModel>();

        // Inisialisasi komponen ketika form dibuka. Mengambil data username yang sign in.
        // Membaca jika file JSON sudah ada, jika belum buat file JSON dengan isi DummyData().
        public Report()
        {
            InitializeComponent();
            SignIn signIn = new SignIn();
            txtUsername.Text = signIn.username;

            try
            {
                reportModel = Config.ReadFromJson<List<ReportModel>>(path + pathJSON);
            }
            catch
            {
                DummyData();
                Config.SaveToJson<List<ReportModel>>(reportModel, path + pathJSON);
            }
        }

        // Cuma data palsu buat isi JSON.
        private void DummyData()
        {
            reportModel.Add(new ReportModel(
                "althoof",
                "Parkiran no. 091 sudah ada yang pakai, harusnya saya yang pakai."
                ));
        }

        // Kembali ke Halaman Menu Utama.
        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUtama menuUtama = new MenuUtama();
            menuUtama.Show();
        }

        // Menambahkan data report ke Report.JSON.
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length != 0 && txtMessage.Text.Length != 0)
            {
                reportModel.Add(new ReportModel(txtUsername.Text, txtMessage.Text));
                Config.SaveToJson<List<ReportModel>>(reportModel, path + pathJSON);

                this.Hide();
                Thanks thanks = new Thanks();
                thanks.Show();
            } else
                MessageBox.Show("Data Masih Kosong!!", "Warning");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
