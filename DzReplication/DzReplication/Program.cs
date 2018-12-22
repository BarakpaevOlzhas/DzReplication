using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzReplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LibraryContext())
            {
                context.People.Add(new Person
                {
                    FirestName = "Chelovek",
                    LastName = "NeChelovekov",
                    MiddleName = "Chelovek",
                });
                context.People.Add(new Person
                {
                    FirestName = "Fs",
                    LastName = "cxc",
                    MiddleName = "csaa",
                });
                context.People.Add(new Person
                {
                    FirestName = "1233",
                    LastName = "4545",
                    MiddleName = "234",
                });

                context.Books.Add(new Book
                {
                    Name = "BookOne",
                    Pages = 23
                });
                context.Books.Add(new Book
                {
                    Name = "BookThree",
                    Pages = 563
                });
                context.Books.Add(new Book
                {
                    Name = "BookTwo",
                    Pages = 233
                });

                context.SaveChanges();
            }
        }
    }
}
