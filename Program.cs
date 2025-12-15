using System.Diagnostics;

namespace labb4
{
    internal class Program
    {

        // Metod som skriver ut meny
        static void Meny()
        {
            Console.WriteLine();
            Console.WriteLine("1. Lägg till person");
            Console.WriteLine("2. Lista personer");
            Console.WriteLine("3. Avsluta programmet");
            Console.Write("Skriv ditt val här: ");
        }

        // Metod för att lägga person
        static void AddPerson(List<Person> persons)
        {
            Console.Write("\nAnge namn: ");
            string name = Console.ReadLine();

            int age;
            Console.Write("\nAnge ålder: ");

            // Felhantering
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Felaktig input, skriv ålder med siffror: ");
            }

            Console.WriteLine("\nVälj kön: ");
            Console.Write("1:Female\n2: Male\n3: NonBrinary\n4:Annan\nSvar: ");

            // Felhantering
            int genderChoice;
            while (!int.TryParse(Console.ReadLine(), out genderChoice) || genderChoice < 1 || genderChoice > 4)
            {
                Console.WriteLine("Felakting input, välj 1-4");

            }

            // Här konverteras valet till enum
            Gender gender = (Gender)(genderChoice - 1);

            Hair hair = new Hair();

            Console.Write("\nAnge hårfärg: ");
            hair.HairColor = Console.ReadLine();

            Console.Write("\nAnge hårlängd (skriv: kort, medium eller långt): ");
            hair.HairLength = Console.ReadLine();

            DateTime birthday;

            // Itererar frågan tills svaret är i rätt format
            while (true)
            {
                Console.Write("\nAnge födelsedag (YYYY-MM-DD): ");

                try
                {
                    birthday = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Fel formulerat datum");

                }
            }

            Console.Write("\nAnge ögonfärg: ");
            string eyeColor =Console.ReadLine();

            // Här skapas ett Person-objekt
            Person person = new Person();
            person.Name = name;
            person.Age = age;
            person.Gender = gender;
            person.Hair = hair;
            person.SetBirthday(birthday);
            person.SetEyeColor(eyeColor);


            // Här läggs ett objekt till i listan 
            persons.Add(person);
            Console.WriteLine("\nEn person har lagts till.\n");

        }

        // Metod för att lista personer i listan 
        static void ListPersons(List<Person> persons)
        {
            if (persons.Count == 0)
            {
                Console.WriteLine("Tyvärr finns det inga personer i listan.");
                return;
            }

            // Skriver ut varje persons information
            foreach (Person p in persons)
            {
                Console.WriteLine(p.ToString());
            }
        }

        static void Main(string[] args)
        {
            // En lista skapas
            List <Person> persons = new List<Person>();
            bool running = true;
            while (running)
            {
                // Meny-metoden anropas + felhantering
                Meny();
                int userChoise;
                while (!int.TryParse(Console.ReadLine(), out userChoise))
                {
                    Console.WriteLine("\nFelaktig  inmatning. Skriv en siffra (1, 2 eller 3)");
                    Console.WriteLine("Försök igen: ");
                }

                // Switch-sats för menyhantering
                switch (userChoise)
                {
                    case 1:
                        AddPerson(persons);
                        break;
                    case 2:
                        ListPersons(persons);
                        break;
                    case 3:
                        Console.WriteLine("\nAvslutar programmet");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Felaktigt val");
                        break;
                }
            }
            
        }
    }
}
