using Week5Close;

class Program
{
    public static void Main(string[] args)
    {
        //generic list oluşturumu
        List<Car> cars = new List<Car>();
        //başka bir araç daha üretmek isterse while döngüsü ile başlangıcı
        while (true)
            //goto için etiket tanımı
        {   CreateCar:
            Console.WriteLine("Araç Üretmek İstiyormusunuz.Cevap için :\n[e] Evet\n[q] Hayır");
            //tolower ve trim ile giriş formatlanması
            string input = Console.ReadLine().ToLower().Trim();

            if(input == "e")
            {
                //newCar adında constructor ile nesnenin oluşumu ve generic listenin içine aktarılması
                Car newCar = Car.CreateCar();
                cars.Add(newCar);
            }else if(input == "q")
            {
                Console.WriteLine("Hoşca Kalın");
                break;
            }
            else
            {
                Console.WriteLine("Cevap olarak sadece e veya q giriniz");
                goto CreateCar;
            }
        }//End-while
        //üretilen araçların listelenmesi foreach ile liste içinde dönülmesi
        Console.WriteLine("\nÜretilmiş Araçlar:");
        Console.WriteLine("***********************************");
        foreach (var item in cars)
        {
            Console.WriteLine($"Üretim Tarihi : {item.ProductionDate}\nSeri Numarası: {item.SerialNumber}\nMarka: {item.Brand}\nModeli : {item.Model}\nRengi : {item.Color}\nKapı Sayısı : {item.NumberDoors}");
            Console.WriteLine("*****************************************");
        }
    }
}