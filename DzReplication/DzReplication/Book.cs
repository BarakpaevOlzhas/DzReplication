using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzReplication
{
    public class Book : Entity
    {
        public string Name { set; get; }

        public int Pages { set; get; }

        public Person person { set; get; }
    }
}
