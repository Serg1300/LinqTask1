namespace LinqTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            var sortedContact = from s in phoneBook orderby s.Name, s.LastName select s;
            Console.WriteLine("Множественная сортировка через LINQ выражения");
            foreach (var citizen in sortedContact)
                Console.WriteLine("\t" + citizen.Name + " " + citizen.LastName);

            Console.WriteLine("\n");
            var sortedContact2 = phoneBook
               .OrderBy(s => s.Name)
               .ThenBy(s => s.LastName);
            Console.WriteLine("Множественная сортировка через методы расширения LINQ ");
            foreach (var citizen in sortedContact2)
                Console.WriteLine("\t" + citizen.Name + " " + citizen.LastName);
        }
        public class Contact 
        {
            public Contact(string name, string lastName, long phoneNumber, String email) 
            {
                Name = name;
                LastName = lastName;
                PhoneNumber = phoneNumber;
                Email = email;
            }

            public String Name { get; }
            public String LastName { get; }
            public long PhoneNumber { get; }
            public String Email { get; }
        }
    }
}