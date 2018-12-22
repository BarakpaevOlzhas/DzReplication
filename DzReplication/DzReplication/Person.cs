using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzReplication
{
    public class Person : Entity
    {
        public string FirestName { set; get;}
        public string MiddleName { set; get; }
        public string LastName { set; get; }
        public string Phone { set; get; }
    }
}
