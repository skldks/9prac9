using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _9prac9
{
    struct Students
    {
        public Students(string surname, string street, string house, string flat)
        {
            Surname = surname;
            Street = street;
            House = house;
            Flat = flat;
        }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
    }
}
