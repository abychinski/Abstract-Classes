using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Models
{
    public abstract class Media
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public abstract void Display();
        public abstract void Read();



    }
}
