using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraTask
{
    internal class Book
    {

        private int pageIndex = 0;

        private Page[] pages;

        public Page[] copyPages;

        public string line = new string(' ', 18);
        public uint CountOfPages { get; }
        public string Title { get; }
        public string Author { get; }
        public Page CurrentPage { get; set; }

        public Book(string title, string author, uint countOfPages, string[] pages)
        {
            Title = title;
            Author = author;

            CountOfPages = countOfPages;
            this.pages = new Page[countOfPages];

            InitPages(pages);
        }

        private void InitPages(string[] pages)
        {
            for (uint i = 0; i < pages.Length; i++)
            {

                this.pages[i] = new Page(pages[i], i);

            }
        }

        public Page StartReading() => CurrentPage = pages[0];

        public Page GetNextPage()
        {
            if (pageIndex + 1 <= CountOfPages && pages[pageIndex + 1] != null)
            {
                return CurrentPage = pages[pageIndex++];
            }

            return CurrentPage = pages[0];
        }

        public Page GetPreviousPage()
        {
            if (pageIndex - 1 >= 0 && pages[pageIndex - 1] != null)
            {
                return CurrentPage = pages[--pageIndex];
            }

            return CurrentPage = pages[0];
        }

        public Page[] GetAllPages()
        {
            uint countNotEmpty;

            for (countNotEmpty = 0; countNotEmpty < CountOfPages; countNotEmpty++)
            {
                if (pages[countNotEmpty] == null)
                    break;
            }

            copyPages = new Page[countNotEmpty];
            Array.Copy(pages, copyPages, countNotEmpty);

            return copyPages;
        }

        public void GetContetn()
        {
            Console.WriteLine(line + CurrentPage.Content);
        }

        public void AddPage(string content, uint number)
        {
            var index = number - 1;
            if (index <= pages.Length)
            {
                pages[index] = new Page(content, index);
            }
            else
                Console.WriteLine("Incorrect operation");
        }

        public void GetBookInfo()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nCount of pages: {CountOfPages}\n");

        }
    }
}

