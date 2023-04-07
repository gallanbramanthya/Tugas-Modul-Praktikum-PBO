using _222410102009_Gallan_Damarrio_Tugas_Modul_Praktikum_PBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _222410102009_Gallan_Damarrio_Tugas_Modul_Praktikum_PBO
{
    class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dinyalakan");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dimatikan");
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
    
    class Processor
    {
        public string merk, tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    class amd : Processor
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }

    class Ryzen : amd
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }

    class Athlon : amd
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
    class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new AMD();
            laptop2.processor = new Ryzen();
            Console.WriteLine("============== SOAL 1 ===============");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine("\n");

            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();
            Console.WriteLine("============== SOAL 2 ===============");
            //laptop1.Ngoding();
            Console.WriteLine("\n");

            Console.WriteLine("============== SOAL 3 ===============");
            Console.WriteLine("Merk VGA Laptop1        :" + laptop1.vga.merk);
            Console.WriteLine("Merk Processor Laptop1  :" + laptop1.processor.merk);
            Console.WriteLine("Tipe Processor Laptop1  :" + laptop1.processor.tipe);
            Console.WriteLine("\n");

            Predator predator = new Predator();
            predator.vga = new AMD();
            predator.processor = new CoreI7();
            Console.WriteLine("============== SOAL 4 ===============");
            predator.BermainGame();
            Console.WriteLine("\n");

            Console.WriteLine("============== SOAL 5 ==============");
            ACER acer = new Predator();
            //acer.Bermaingame();


            Console.ReadKey();
        }
    }
}