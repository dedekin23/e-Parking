using System.Windows.Forms;

namespace TubesKPL
{
    public partial class MenuUtama : Form
    {
        // Inisialisasi komponen ketika form dibuka.
        public MenuUtama()
        {
            InitializeComponent();
        }

        // Menampilkan form Park.
        private void btnPark_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Park park = new Park();
            park.Show();
        }

        // Menampilkan form Payment.
        private void btnPayment_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        // Menampilkan form Report.
        private void btnReport_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show();
        }
    }
}
