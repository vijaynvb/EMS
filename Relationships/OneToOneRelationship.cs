using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationships
{

    public class Man
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Woman wife { get; set; }
    }

    public class Woman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Man Husband { get; set; }
    }




    internal class OneToOneRelationship
    {
       public static void Main()
        {
            Woman woman = new Woman();
            woman.Name = "xyz";
            woman.Id = 1;
            Woman woman1 = new Woman();
            woman1.Name = "pqr";
            woman1.Id = 1;

            Man man1 = new Man();
            man1.Id = 1;
            man1.Name = "abc";
            man1.wife = woman;
        }

    }
}
