namespace ExtraTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new string[]
            {
                @"Lefelé hajlott a nap.
                  Búcsúzóul betekintett
                  még az erdőbe,
                  hol hosszúra nyúlt az 
                  árnyék, és a szelíd 
                  szemű gerlék  
                  halkan kurrogtak.",

                @"Vörös fényben úszott
                  a fák dereka; hazafelé
                  zümmögtek a méhek,
                  és csengő madárdal
                  fuvolázott ezer hangon.",

                @"Aztán halkult az ének,
                  és amikor túl a dombon 
                  üszkös felhőhamu maradt
                  az égő fény helyén, már 
                  csak a feketerigó nótázott",

                @"Ekkor már meleg párákat
                  lehelt a föld, és a 
                  virágos fák illatos 
                  üzeneteket küldtek egymásnak
                  apró szélgyerekekkel,",

                @"Lefelé hajlott a nap.
                  Búcsúzóul betekintett
                  még az erdőbe,
                  hol hosszúra nyúlt az 
                  árnyék, és a szelíd 
                  szemű gerlék  
                  halkan kurrogtak.",

                @"Vörös fényben úszott
                  a fák dereka; hazafelé
                  zümmögtek a méhek,
                  és csengő madárdal
                  fuvolázott ezer hangon.",

                @"Aztán halkult az ének,
                  és amikor túl a dombon 
                  üszkös felhőhamu maradt
                  az égő fény helyén, már 
                  csak a feketerigó nótázott",

                @"Ekkor már meleg párákat
                  lehelt a föld, és a 
                  virágos fák illatos 
                  üzeneteket küldtek egymásnak
                  apró szélgyerekekkel,",


            };

            Book newBook = new Book("Vuk", "István Fekete", 8, text,1);

            uint a;
            bool stopread = false;

            while (!stopread)
            {
                
                Console.WriteLine("1-Start reading");
                Console.WriteLine("2-Get previous page");
                Console.WriteLine("3-Get next page");
                Console.WriteLine("4-Add page");
                Console.WriteLine();
                Console.WriteLine("0-Exit");

                while (!UInt32.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Wrong input");
                }

                switch (a)
                {
                    case 0:
                        stopread = true;
                        continue;
                    case 1:
                        Console.WriteLine(newBook.StartReading());
                        break;
                    case 2:
                        Console.WriteLine(newBook.GetPreviousPage());
                        break;
                    case 3:
                        Console.WriteLine(newBook.GetNextPage());
                        break;
                    case 4:
                        {
                            uint pageNumber;
                            string content;

                            Console.WriteLine("Input the page number");
                            while (!UInt32.TryParse(Console.ReadLine(), out pageNumber))
                            {
                                Console.WriteLine("Wrong input");
                            }

                            Console.WriteLine("Input page content");
                            content = Console.ReadLine();

                            newBook.AddPage(content,pageNumber);
                            break;
                        }
                }

                    
            }
        }
    }
}