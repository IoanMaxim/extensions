using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public DateTime BirthDate { get => DateTime.Now; }
    }
}
