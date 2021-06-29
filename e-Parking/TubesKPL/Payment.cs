using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TubesKPL
{
    public partial class Payment : Form
    {
        // Inisialisasi variabel.
        Park park = new Park();
        SignIn signIn = new SignIn();
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"../../../json/Payment.json";
        List<PaymentModel> paymentModel = new List<PaymentModel>();

        // Inisialisasi komponen ketika form dibuka.
        // Membaca jika file JSON sudah ada, jika belum buat file JSON dengan isi DummyData().
        public Payment()
        {
            InitializeComponent();

            try
            {
                paymentModel = Config.ReadFromJson<List<PaymentModel>>(path + pathJSON);
            }
            catch
            {
                DummyData();
                Config.SaveToJson<List<PaymentModel>>(paymentModel, path + pathJSON);
            }
        }

        // Cuma data palsu buat isi JSON.
        private void DummyData()
        {
            paymentModel.Add(new PaymentModel("althoof", 29, 3, 21000, "-"));
        }

        // Menambahkan data pembayaran ke payment.JSON.
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Length != 0)
            {
                paymentModel.Add(new PaymentModel(
                    signIn.username, 
                    int.Parse(labelParkingNumber.Text),
                    int.Parse(labelParkingTime.Text.Substring(0, 2)),
                    int.Parse(labelParkingTime.Text.Substring(0, 2)) * 7000,
                    txtMessage.Text
                    ));
                Config.SaveToJson<List<PaymentModel>>(paymentModel, path + pathJSON);

                this.Hide();
                Thanks thanks = new Thanks();
                thanks.Show();
            }
            else
                MessageBox.Show("Data Masih Kosong!!", "Warning");
        }

        // Ambil nomor parkiran dari form park.
        // Ambil random jam parkir dan hitung total fee yang harus dibayar.
        private void Payment_Load(object sender, EventArgs e)
        {
            labelParkingNumber.Text = park.GetlabelParkNumber();
            labelParkingTime.Text = Config.RandomTimeLength();
            labelTotal.Text = "Rp. " + (int.Parse(labelParkingTime.Text.Substring(0,2)) * 7000).ToString();
        }

        // Kembali ke Halaman Menu Utama.
        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUtama menuUtama = new MenuUtama();
            menuUtama.Show();
        }
    }
}
