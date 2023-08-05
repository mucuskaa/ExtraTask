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

            Book newBook = new Book("Vuk", "István Fekete", 300, text);

            uint a;
            bool stopread = false;

            while (!stopread)
            {

                Console.WriteLine("1-Start reading");
                Console.WriteLine("2-Get next page");
                Console.WriteLine("3-Get previous page");
                Console.WriteLine("4-Add page");
                Console.WriteLine("5-Get all pages");
                Console.WriteLine("6-Get information about book");
                Console.WriteLine();
                Console.WriteLine("0-Exit");

                while (!UInt32.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Wrong input");
                }

                Console.Clear();

                switch (a)
                {
                    case 0:
                        stopread = true;
                        continue;
                    case 1:
                        {
                            newBook.StartReading();
                            Console.WriteLine(newBook.line+newBook.CurrentPage.Content);
                            break;
                        }
                    case 2:
                        {
                            newBook.GetNextPage();
                            Console.WriteLine(newBook.line + newBook.CurrentPage.Content);
                            break;
                        }
                    case 3:
                        {
                            newBook.GetPreviousPage();
                            Console.WriteLine(newBook.line + newBook.CurrentPage.Content);
                            break;
                        }
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

                            newBook.AddPage(content, pageNumber, out string error);
                            if (error != String.Empty)
                                Console.WriteLine(error);
                            break;
                        }
                    case 5:
                        {
                            newBook.GetAllPages();
                            for (int i = 0; i < newBook.copyPages.Length; i++)
                            {
                                Console.WriteLine(newBook.line + newBook.copyPages[i].Content + '\n');
                            }
                            break;
                        }
                    case 6:
                        Console.WriteLine($"Title: {newBook.Title}\nAuthor: {newBook.Author}\nCount of pages: {newBook.CountOfPages}\n");
                        break;
                }


            }
        }
    }
}