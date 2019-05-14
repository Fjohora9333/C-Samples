using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zisa_Personal_Information
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set;}
        public uint Age { get; set; }
        public string Phone { get; set; }
        public string Color { get; set; } = "Aliceblue";

        //Default Constructor
        public Person()
        {
        }
        public Person(string name, string address, uint age, string phone)
        {
            Name = name;
            Address = address;
            Age = age;
            Phone = phone;
        }
        public override string ToString() => $"Name: {Name}; Address: {Address}; Age: {Age}; Phone: {Phone}";
       
    }
    
}
