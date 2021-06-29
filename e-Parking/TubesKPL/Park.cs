using System;
using System.Windows.Forms;

namespace TubesKPL
{
    public partial class Park : Form
    {
        // Inisialisasi state di posisi park.
        Automata.State posisi = Automata.State.PARK, nextPosisi;

        // Inisialisasi komponen ketika form dibuka.
        // Mengambil data nomor parkiran dari tabledriven C11 dan tampilkan di label.
        public Park()
        {
            InitializeComponent();
            labelParkNumber.Text = ParkingTableDriven.getNumber(ParkingTableDriven.Park.C11).ToString();
        }

        // Mengambil nilai dari labelParkNumber.
        public string GetlabelParkNumber()
        {
            return labelParkNumber.Text;
        }

        // Menampilkan form Menu Utama.
        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUtama menuUtama = new MenuUtama();
            menuUtama.Show();
        }

        // Mengganti posisi state menjadi REPORT, lali berpindah ke form Report.
        private void btnReport_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.REPORT;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        // Mengganti posisi state menjadi PAY, lali berpindah ke form Payment.
        private void btnPayment_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.PAY;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }
    }
}
