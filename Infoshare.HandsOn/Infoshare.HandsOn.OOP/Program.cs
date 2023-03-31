using Infoshare.HandsOn.Oop.Data;

namespace Infoshare.HandsOn.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Napisz metodę, która wyświetli zawartość dowolnej kolekcji obiektów typu Product

            //var products = new List<Product>
            //{
            //    new Product { Name = "ProductA", Price = 200 },
            //    new Product { Name = "ProductB", Price = 400 },
            //    new Product { Name = "ProductC", Price = 500 }
            //};

            //var products2 = new HashSet<Product>
            //{
            //    new Product { Name = "ProductA", Price = 200 },
            //    new Product { Name = "ProductB", Price = 400 },
            //    new Product { Name = "ProductC", Price = 500 }
            //};



            //2. Napisz klasę Location, która będzie posiadać dwa prywatne pola typu decimal: _latitude i _longitude
            //Klasa posiada konstruktor, do którego są przekazywane parametry latitude i longitude.
            //Klasa posiada metodę Locate(). Metoda sprawdza, położenie na podstawie Latitude i Longitude
            //jeżeli latitude jest większe od zera, zwróć North, inaczej South
            //jeżeli longitude jest większe od zera, zwróć East, inaczej West
            //przykładowy rezultat ma format North-West itp.
            //Stwórz obiekt klasy Location i wywołaj na nim metodę Locate
            //double latitude;
            //double longitude;

            //Console.WriteLine("Podaj po dwie wartośći liczbowe dla: latitude , longitude");

            //Console.Write($"latitude: " );
            //latitude = double.Parse(Console.ReadLine());

            //Console.Write($"longitude: ");
            //longitude = double.Parse(Console.ReadLine());

            //Location location = new Location(latitude, longitude);
            //location.Locate(latitude, longitude);




            //3. Napisz klasę Registration, która w konstruktorze przyjmie wartości username i password.
            //Wartości te przypisz do pól prywatnych.
            //Klasa zawiera statyczne pole publiczne Registrations typu List<DateTime>
            //Klasa zawiera publiczną metodę Register(), która dodaje wpis do Registrations z DateTime.Now()
            //Stwórz kilka instancji klasy Registration i wywołaj na nich metodę Register.
            //Wyświetl zawartość statycznego pola Registrations.
            string username = "Jarek";
            string password = "hasełko";
            Registration registration = new Registration(username, password);
            Registration registration1 = new Registration(username, password);
            Registration registration2 = new Registration(username, password);
            Registration registration3 = new Registration(username, password);

            registration.Register();
            registration1.Register();
            registration2.Register();
            registration3.Register();


            foreach (DateTime item in Registration.Registrations)
            {
                Console.WriteLine(item);
            }


        }
    }
}