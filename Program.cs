using CinemaConsoleProjectNew.Models;
using CinemaConsoleProjectNew.Services;

namespace CinemaConsoleProjectNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var theater = new Theater();
            var hallManager = new HallManager();
            var filmManager = new FilmManager();
            var ticketManager = new TicketManager();
            var seansManager = new SeansManager();
            string command = "";

            theater.Name = "BakuCinemaHouse";
            Console.WriteLine(theater.Name);

            var seans1 = new Seans
            {
                Id = 1,
                DateTime = "13:00",
                Film = "About Time",
                Hall = "Zal 1",
                Price = "11 AZN"
            };

            var seans2 = new Seans
            {
                Id = 2,
                DateTime = "16:30",
                Film = "Avengers",
                Hall = "Zal 2",
                Price = "9 AZN"
            };
            var seans3 = new Seans
            {
                Id = 3,
                DateTime = "20:00",
                Film = "7-ci kogustaki adam",
                Hall = "Zal 3",
                Price = "12 AZN"
            };
            var seans4 = new Seans()
            {
                Id = 4,
                DateTime = "23:30",
                Film = "Bizans Oyunlari",
                Hall = "Zal 4",
                Price = "8 AZN"
            };
            seansManager.Add(seans1);
            seansManager.Add(seans2);
            seansManager.Add(seans3);
            seansManager.Add(seans4);

            var hall1 = new Hall
            {
                Id = 1,
                Name = "Zal 1",
                Row = 10,
                Column = 20
            };
            var hall2 = new Hall
            {
                Id = 2,
                Name = "Zal 2",
                Row = 10,
                Column = 20
            };
            var hall3 = new Hall
            {
                Id = 3,
                Name = "Zal 3",
                Row = 10,
                Column = 10
            };
            hallManager.Add(hall1);
            hallManager.Add(hall2);
            hallManager.Add(hall3);

            var film1 = new Film()
            {
                Id = 1,
                Name = "About time",
                Director = "Henry Cavell",
                DateofFilm = "18 March 2016"
            };
            var film2 = new Film()
            {
                Id = 2,
                Name = "Bizans Oyunlari",
                Director = "Cenk Ozgun",
                DateofFilm = "9 October 2014"
            };

            var film3 = new Film()
            {
                Id = 3,
                Name = "Avengers",
                Director = "Andrew Stansli",
                DateofFilm = "21 January 2008"
            };
            var film4 = new Film()
            {
                Id = 4,
                Name = "7-ci kogusdaki adam",
                Director = "Melih Kadiroglu",
                DateofFilm = "20 April 2020"
            };
            filmManager.Add(film1);
            filmManager.Add(film2);
            filmManager.Add(film3);
            filmManager.Add(film4);

            do
            {
                Console.Write("Enter Command: ");
                command = Console.ReadLine();

                if (command.ToLower().Equals("print hall"))
                {
                    hallManager.Print();
                }
                else if (command.ToLower().Equals("update hall"))
                {
                    Console.Write("Id daxil edin: ");
                    var id = int.Parse(Console.ReadLine());
                    var existHall = hallManager.Get(id);

                    var hall4 = new Hall
                    {
                        Id = 4,
                        Name = "Zal 4",
                        Row = 10,
                        Column = 20
                    };
                    hallManager.Update(id, hall4);
                }
                else if (command.ToLower().Equals("get hall"))
                {
                    Console.Write("ID daxil edin: ");
                    var id = int.Parse(Console.ReadLine());

                    hallManager.Get(id);
                }

                else if (command.ToLower().Equals("show seans"))
                {
                    seansManager.Print();
                }
                else if (command.ToLower().Equals("show films"))
                {
                    filmManager.Print();
                }
                else if (command.ToLower().Equals("delete film"))
                {
                    Console.Write("ID daxil edin: ");
                    int id = int.Parse(Console.ReadLine());

                    filmManager.Delete(id);
                }
                else if (command.ToLower().Equals("update film"))
                {
                    Console.Write("ID daxil edin: ");
                    int id = int.Parse(Console.ReadLine());

                    var film5 = new Film()
                    {
                        Id = 5,
                        Name = "Labirint",
                        Director = "Milos Kvarasecuk",
                        DateofFilm = "29 September 2007"
                    };
                    filmManager.Update(id, film5);
                }
                else if (command.ToLower().Equals("get film"))
                {
                    Console.Write("Id daxil edin: ");
                    int id = int.Parse(Console.ReadLine());

                    filmManager.Get(id);
                }
                else if (command.ToLower().Equals("add ticket"))
                {
                    var ticket = new Ticket();
                    seansManager.Print();
                    Console.Write("Hansi id-li seansi almaq isteyirsiniz: ");
                    int id = int.Parse(Console.ReadLine());
                    seansManager.Get(id);

                    string[,] place = new string[10, 20];
                    ticket.Id = 1;
                    ticket.Price = 9;

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            place[i, j] = "0";
                            Console.Write($"{place[i, j]}-2  ");

                        }
                    }
                    Console.WriteLine();

                    Console.Write("Hansi sirada oturmaq isteyirsiniz: ");
                    int row = int.Parse(Console.ReadLine());
                    Console.Write("Hansi yerde oturmaq isteyirsiniz: ");
                    int column = int.Parse(Console.ReadLine());
                    place[row - 1, column - 1] = "1";

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            Console.Write($"{place[i, j]}-2  ");
                        }
                    }
                    Console.WriteLine();

                    ticketManager.Add(ticket);
                    ticketManager.Get(1);
                    Console.WriteLine("Bilet Ugurla Alindi!!");

                }

            } while (!command.ToLower().Equals("quit"));

        }
    }
}