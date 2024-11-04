using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationships
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Shishya> shishyas { get; set; }
    }

    public class Shishya
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Course> courses { get; set; }
    }

    internal class ManyToMany
    {
        public static void Main()
        {

        }
    }
}
