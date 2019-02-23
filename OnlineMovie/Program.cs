using System;
namespace OnlineMovie.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MovieContext())
            {
                Console.WriteLine("\t \t =============Jorah Entertainment, RWANDA ONLINE MOVIESTORE==============");
                Console.WriteLine("ENTER MOVIE TITLE:");
                string title = Console.ReadLine();
                Console.WriteLine("ENTER MOVIE RELEASE_YEAR");
                string year = Console.ReadLine();

                Console.WriteLine("ENTER MOVIE BUGDET");
                string bugdet = Console.ReadLine();

                Console.WriteLine("ENTER MOVIE COTEGORY");
                string category = Console.ReadLine();
                db.Movies.Add(new Movietbl { title = title });
                db.Movies.Add(new Movietbl { year = year });
                db.Movies.Add(new Movietbl { bugdet = bugdet });
                db.Movies.Add(new Movietbl { category_name = category });
                var count = db.SaveChanges();
                Console.WriteLine("\t \t-{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("\t \t title:" + "Year:" +"bugdet:" + "Category:");
                Console.WriteLine("\t \t =================HERE IS THE MOVIE YOU HAVE CREATED====================");
                foreach (var Movietbl in db.Movies)
                {

                  Console.Write("\t \t {0}, {1}, {2}, {3}" ,Movietbl.title, Movietbl.year,Movietbl.bugdet, Movietbl.category_name, "");
                    

                  Console.WriteLine("");

                }
                Console.ReadLine();
            }
        }
    }
}