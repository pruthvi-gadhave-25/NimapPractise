

using Newtonsoft.Json;

namespace SeriliazationDemo
{
    public class JosnSerialize
    {
        public static void SerlizeJson()
        {
            Person person = new Person
            {
                Name = "John Doe",
                Age = 30,
                IsActive = true
            };


            // Serialize the  object to a JSON string
            string jsonString = JsonConvert.SerializeObject(person);
            Console.WriteLine(jsonString);

            var deserilazePerson = JsonConvert.DeserializeObject<Person>(jsonString);
            Console.WriteLine($"" +
                $"{person.Name} , {person.Age} , {person.IsActive}" 
               );
        }


        
           


    }
}
