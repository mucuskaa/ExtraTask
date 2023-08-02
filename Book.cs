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

        private uint pageIndex = 0;

        private Page[] pages;

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
            if (pages[pageIndex + 1] != null)
            {
                pageIndex++;
                return CurrentPage = pages[pageIndex];
            }

            return CurrentPage = pages[0];
        }

        public Page GetPreviousPage()
        {
            if (pages[pageIndex - 1] != null)
            {
                pageIndex--;
                return CurrentPage = pages[pageIndex];
            }

            return CurrentPage = pages[0];
        }

        public void GetAllPages()
        {
            CurrentPage=pages[0];
            for (uint i = 0; i < CountOfPages; i++)
            {
                if (CurrentPage == null)
                    break;

                Console.WriteLine(line + CurrentPage.Content + "\n");
                CurrentPage = pages[i];
            }

        }

        public void GetContetn()
        {
            Console.WriteLine(line + CurrentPage.Content);
        }

        public void AddPage(string content, uint number)
        {
            number--;
            if (number <= pages.Length)
            {
                pages[number] = new Page(content, number);
            }

            else
                Console.WriteLine("Incorrect operation");
        }
    }
}

