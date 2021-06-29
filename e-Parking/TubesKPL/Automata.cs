namespace TubesKPL
{
    class Automata
    {
        // Initialisasi variabel.
        public enum State { PARK, REPORT, PAY };
        public static State posisi, nextPosisi;

        // Konstruktor kosong untuk global initialisasi.
        public Automata() { }

        // Mengganti posisi untuk automata.
        public static void setPosisi(State pos, State nextPos)
        {
            posisi = pos;
            nextPosisi = nextPos;
        }

        // Mengambil posisi state.
        public static State getPosisi()
        {
            return posisi;
        }

        // Mengubah form ketika state berubah.
        public static void posisiTransition(State nextPos)
        {
            if (posisi == State.PARK)
            {
                if (nextPos == State.REPORT)
                {
                    Report report = new Report();
                    report.Show();
                }
                else if (nextPos == State.PAY)
                {
                    Payment payment = new Payment();
                    payment.Show();
                }
            }
        }
    }
}
