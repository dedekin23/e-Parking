namespace TubesKPL
{
    class PaymentModel
    {
        // Initialisasi variabel.
        public string username;
        public int parkingNumber;
        public int parkingTime;
        public int totalFee;
        public string message;

        // Konstruktor kosong untuk global inisialisasi.
        public PaymentModel() { }

        // Konstruktor untuk membuat objek PaymentModel.
        public PaymentModel(string username, int parkingNumber, int parkingTime, int totalFee, string message)
        {
            this.username = username;
            this.parkingNumber = parkingNumber;
            this.parkingTime = parkingTime;
            this.totalFee = totalFee;
            this.message = message;
        }
    }
}
