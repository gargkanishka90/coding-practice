using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.CSharp6
{
    public class GetterOnlyAutoProperties
    {
        public class Person
        {
            public int Age { get; }
            public string Name { get; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string NameAge => Name + Age;
        }


    }
}
