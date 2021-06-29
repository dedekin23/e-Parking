namespace TubesKPL
{
    class ReportModel
    {
        // Initialisasi variabel.
        public string username;
        public string message;

        // Konstruktor kosong untuk global inisialisasi.
        public ReportModel() { }

        // Konstruktor untuk membuat objek ReportModel.
        public ReportModel(string username, string message)
        {
            this.username = username;
            this.message = message;
        }
    }
}