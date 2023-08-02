using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraTask
{
    internal class Page
    {
        public string Content {get;}
        public uint PageNumber { get; set; }

        public Page(string content, uint pageNumber)
        {
            Content = content;
            PageNumber = pageNumber;
        }
    }
}
