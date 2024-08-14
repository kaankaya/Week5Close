using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Close
{
    public class Car
    {
        //Property Tanımları 
        public DateTime ProductionDate { get; set; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumberDoors { get; set; }
        //Constructor Methodu tanımı -Kullanıcı oluşturucağı zaman veri eşitlenme işlemi yapımı
        public Car(string serialNumber, string brand, string model, string color, int numberDoors)
        {
            //üretim tarihini o anın tarihini atama
            ProductionDate = DateTime.Now;
            SerialNumber = serialNumber;
            Brand = brand;
            Model = model;
            Color = color;
            NumberDoors = numberDoors;
        }
        //Araç oluşturma methodu kullanıcıdan bilgileri alma
        //kapı sayısı kontrolü
        public static Car CreateCar()
        {
            //Tolower ve trim ile kullanıcıdan girilen verilerin formatlanması
            Console.Write("Seri Numarası: ");
            string seriNumarasi = Console.ReadLine().Trim().ToLower();

            Console.Write("Marka: ");
            string marka = Console.ReadLine().Trim().ToLower();

            Console.Write("Model: ");
            string model = Console.ReadLine().Trim().ToLower();

            Console.Write("Renk: ");
            string renk = Console.ReadLine().Trim().ToLower();

            int numberOfDoors;
            while (true)
            {
                Console.Write("Kapı Sayısı: ");
                string numberDoor = Console.ReadLine();

                if (int.TryParse(numberDoor, out numberOfDoors))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kapı Sayısı sadece sayısal bir değer olabilir. Lütfen tekrar deneyin.");
                }
            }

            return new Car(seriNumarasi, marka, model, renk, numberOfDoors);
        }
    }
}
