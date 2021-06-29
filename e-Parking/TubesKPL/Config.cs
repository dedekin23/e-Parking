using Newtonsoft.Json;
using System;
using System.IO;

namespace TubesKPL
{
    class Config
    {
        // Membaca file JSON dan mengembalikannya berupa generic variabel
        // dalam kasus ini string.
        public static T ReadFromJson<T>(string path)
        {
            string json = File.ReadAllText(path);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        // Menyimpan variabel obj ke dalam JSON.
        public static void SaveToJson<T>(T obj, string path)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        // Mengambil angka secara acan dari 0-10.
        public static int getRandomTime()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10);
            return randomNumber;
        }

        // Membuat format jam seperti 00:00
        public static string RandomTimeLength()
        {
            string number = getRandomTime().ToString();
            if (number.Length == 1)
                return "0" + number + ":00";
            else
                return number + ":00";
        }
    }
}
