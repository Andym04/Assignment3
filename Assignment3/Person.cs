using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }

        // Read-only property combining FirstName and LastName
        public string FullName => $"{FirstName} {LastName}".Trim();

        // Read-only property determining adulthood
        public bool IsAdult => Age >= 18;

        public Person() { }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}