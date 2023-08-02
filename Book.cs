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
        private uint countOfPages;

        private uint pageIndex;

        private Page[] pages;

        private string line = "                  ";
        public string Title { get; }
        public string Author { get; }

        public Book(string title, string author, uint countOfPages, string[] pages, uint pageIndex)
        {
            Title = title;
            Author = author;

            this.countOfPages = countOfPages+1;
            this.pages = new Page[countOfPages+1];

            InitPages(pages);
            this.pageIndex = pageIndex;
        }

        private void InitPages(string[] pages)
        {
            for (uint i = 1; i <= countOfPages-1; i++)
            {

                this.pages[i] = new Page(pages[i-1], i);

            }
        }

        public string GetCurrentPage(uint number)
        {
            return line +pages[number].Content;
        }

        public string StartReading(uint number = 1)
        {
            return GetCurrentPage(number);
        }

        public string GetNextPage()
        {
            if (pageIndex == countOfPages)
            {
                return "You are already at the end!\n";
            }
            pageIndex++;
            return GetCurrentPage(pageIndex);
        }

        public string GetPreviousPage()
        {
            if (pageIndex - 1 == 0)
            {
                return "You are already at the beginning!\n";
            }
            pageIndex--;
            return GetCurrentPage(pageIndex);
        }

        public string GetAllPages()
        {
            for (uint i = 1; i <= countOfPages; i++)
            {
                Console.WriteLine(line+pages[i].Content + "\n");
            }

            return "";
        }

        public void AddPage(string content, uint number)
        {
            if (number >= 1 && number <= countOfPages+1)
            {
                Page[] newPages = new Page[countOfPages+1];

                for (uint i = 1; i <number; i++)
                {
                    newPages[i] = pages[i];
                }

                newPages[number] = new Page(content, number);

                for (uint i = number + 1; i <= countOfPages; i++)
                {
                    newPages[i] = pages[i - 1];
                    newPages[i].PageNumber = i;
                }

                pages = newPages;
                countOfPages++;
            }
            else
                Console.WriteLine("Incorrect operation");
        }
    }
}
