namespace TubesKPL
{
    class ParkingTableDriven
    {
        // Inisialisasi variabel tabledriven.
        public enum Park { A11, B11, C11, D11, E11 };
        public static int[] parkNumber = { 101, 201, 301, 401, 501 };

        // Mengambil nilai parkNumber berdasarkan Park yang dipilih.
        public static int getNumber(Park park)
        {
            return parkNumber[(int)park];
        }
    }
}
