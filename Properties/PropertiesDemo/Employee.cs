

namespace PropertiesDemo
{
    internal class Employee
    {
        private int id;
        private string name;
        private int age;


        public int GetId() {
            return id;
        }


        public int Id { get; set; }
        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }
    }
}
