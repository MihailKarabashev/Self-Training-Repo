using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountState.Models
{
    public class Person
    {
        public Person(string nickName)
            : this(nickName + "ff", 0)
        {
            NickName = nickName;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string NickName { get; set;}
    }
}
