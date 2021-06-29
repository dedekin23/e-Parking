using System;
using System.Windows.Forms;

namespace TubesKPL
{
    public partial class Thanks : Form
    {
        // Inisialisasi komponen ketika form dibuka.
        public Thanks()
        {
            InitializeComponent();
        }

        // Kembali ke Halaman Menu Utama.
        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUtama menuUtama = new MenuUtama();
            menuUtama.Show();
        }

        // Kembali ke Halaman Menu Utama.
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUtama menuUtama = new MenuUtama();
            menuUtama.Show();
        }
    }
}
