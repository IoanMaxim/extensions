using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "My awesome students.";
            int wordNumber = Extensions.WordCount(myString);
            int wordNumberExtension = myString.WordCountExtension();

            var now = DateTime.Now;
            Console.WriteLine(Extensions.RoundToHalfHour(now));
            Console.WriteLine(now.RoundToHalfHour());

            List<Person> persons = new List<Person>();
            persons.Add(new Person() { City = "Iasi", Country = "Romania", FirstName = "Ionut", LastName = "Maxim" });
            persons.Add(new Person() { City = "Botosani", Country = "Romania", FirstName = "Bogdan", LastName = "Doroftei" });
            persons.Add(new Person() { City = "Targu Neamt", Country = "Romania", FirstName = "Andrei", LastName = "Maxim" });
            persons.Add(new Person() { City = "Vaslui", Country = "Romania", FirstName = "Stefan", LastName = "Drumea" });


            //Anonymous type;
            var student = new
            {
                Name = "Student 1",
                Course = ".NET"
            };
            Console.WriteLine(student.Course + student.Name);

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);

            //whit Linq;
            var personInCity = persons.Where(person => person.City == "Iasi")
                .OrderBy(x => x.FirstName)
                .OrderByDescending(x => x.Country.WordCountExtension()).ToList();

            Console.ReadLine();
        }
    }
}
