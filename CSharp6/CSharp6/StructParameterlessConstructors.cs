using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    struct Person
    {
        public string Name { get; }
        public int Age { get; }
        public Person(string name, int age) { Name = name; Age = age; }
        public Person() : this("Jane Doe", 37) { }

        // does not work with default(Person)
    }
}
