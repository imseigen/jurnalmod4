using System;

class main
{
    static void Main(string[] args)
    {
        // Contoh penggunaan KodePos dengan input manual
        KodePos kodePos = new KodePos();
        Console.WriteLine("Masukkan nama kelurahan:");
        string kelurahan = Console.ReadLine();
        Console.WriteLine("Kode Pos " + kelurahan + ": " + kodePos.GetKodePos(kelurahan));

        // Contoh penggunaan DoorMachine dengan input manual
        DoorMachine door = new DoorMachine();
        while (true)
        {
            Console.WriteLine("\nPilih aksi untuk pintu:");
            Console.WriteLine("1. Kunci Pintu");
            Console.WriteLine("2. Buka Pintu");
            Console.WriteLine("3. Keluar");
            string pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                door.Lock();
            }
            else if (pilihan == "2")
            {
                door.Unlock();
            }
            else if (pilihan == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
            }
        }
    }
}