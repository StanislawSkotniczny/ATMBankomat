using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBankomat
{
    public class Person: IPerson
    {
        public  static string Name { get; set; }
        public  static string Surname { get; set; }


        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    
        
    
    }
}
