namespace modul4_1302210059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah buah = new KodeBuah();
            Console.WriteLine("Kode buah " + KodeBuah.databuah.Apel + " kodenya adalah: " + buah.getKode(KodeBuah.databuah.Apel));

            PosisiKarakterGame posisi = new PosisiKarakterGame();
            posisi.triggeredaktif(PosisiKarakterGame.triggered.TombolS)
        }
    }
}