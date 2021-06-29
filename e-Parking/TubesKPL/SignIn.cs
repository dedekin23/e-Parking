using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TubesKPL
{
    public partial class SignIn : Form
    {

        // Inisialisasi Variabel.
        // Ambil data username dari tabledriven "appan".
        static UserTableDriven.Username id = UserTableDriven.Username.users;
        public string username = id.ToString();
        public string password = UserTableDriven.getPassword(id);

        // Inisialisasi komponen ketika form dibuka.
        public SignIn()
        {
            InitializeComponent();
        }

        // Menyembunyikan karakter di txtPassword menjadi *.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.PasswordChar = '*';
        }

        // Masuk ke menu utama jika username dan password yang di inputkan sesuai
        // dengan username password dari tabledriven "appan".
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(username.ToString());
            Console.WriteLine(password.ToString());

            Debug.Assert(txtUsername.Text.Length >= 5, "Panjang Username Minimal 5 Karakter.");
            Debug.Assert(txtPassword.Text.Length >= 8, "Panjang Username Minimal 8 Karakter.");

            if (txtUsername.Text == username.ToString() && txtPassword.Text == password.ToString())
            {
                MessageBox.Show("Selamat Datang " + username.ToString(), "Message");
                Console.WriteLine(password.ToString());

                this.Hide();
                MenuUtama menuUtama = new MenuUtama();
                menuUtama.Show();
            } else 
                MessageBox.Show("Username atau password tidak sesuai", "Warning");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
