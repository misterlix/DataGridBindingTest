using System;
using System.Collections.Generic;

namespace DataGridBindingTest.DAL
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<PhoneNumbers> PhoneNumbers { get; set; }
    }
}