using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LInqQueries
{
    internal class LinqList
    {
        public static void LinqDemo1()
        {
            List<int> list = new List<int>() {
                1,2,3,4,5,6,7,8,90,3
            };
            List<string> my_list = new List<string>() {
                "This is my Dog",
                "Name of my Dog is Robin",
                "This is my Cat",
                "Name of the cat is Mewmew"
            };



            var res = my_list.Contains("Dog");



            IEnumerable<int> list1 = list.Where(x => x % 2 == 0).ToList();
            int maxNum = list.Max();
            int secondMax = list1.OrderByDescending(x => x).Skip(1).FirstOrDefault();


            Console.WriteLine("max Num :" + maxNum + " SecondMax : " + secondMax + " res : " + res);
            IEnumerable<int> list2 = from number in list
                                     where number % 2 != 0
                                     select number; 

            foreach (int x in list2) Console.Write($"{x} ,");
        }

        public static void LinqDemo2()
        {
            List<Student> list = new List<Student>() {
                new Student {ID = 101, Name = "Sravan", Age = 12 , Gender= "Male"},
                new Student {ID = 103, Name = "manoja", Age = 13 , Gender= "Male"},
                new Student  {ID = 104, Name = "sathwik", Age = 12 , Gender= "Male"},
                new Student  {ID = 105, Name = "Saran",  Age = 15 , Gender= "Male"},
                new Student  {ID = 106, Name = "Shruti",  Age = 15 , Gender= "Female"}
            };


            IEnumerable<Student> students =  list.Where(n => (n.Name[0] == 'S') || (n.Name[0] == 's') ).ToList();

            IEnumerable<Student> students1 = list.Where(n => n.Name.StartsWith("S")).ToList();

            IQueryable<Student> MethodSyntax = list.AsQueryable()
                               .Where(std => std.Gender == "Male");

            foreach (Student s  in MethodSyntax)
            {
                Console.WriteLine(s.Name);
            }
        }

        public static void PaginationDemo(int pageNumber , int NoOfRecords)
        {
          
          List<Employee>  employees =  Employee.GetAllEmployees()
                .Skip((pageNumber -1)* NoOfRecords)
                .Take(NoOfRecords).ToList();


            foreach (Employee emp in employees) {
                Console.WriteLine($"ID : {emp.ID}, Name : {emp.Name}, Department : {emp.Department}");
            }
         }

        //pagination using raw sql 

        public static void PaginationRawSql( int pgNumber , int noOfRows)
        {

            List<Student> students = new List<Student>();
            string connString = "Server=DESKTOP-HG3NPSB;Database=StudentPortalDb;Trusted_Connection=True";
            int recordNumber = (pgNumber - 1) * noOfRows;

            string query = $"SELECT * FROM student ORDER BY ID OFFSET {recordNumber} ROWS FETCH NEXT {noOfRows} ROWS ONLY;";

            using (SqlConnection connection = new SqlConnection(connString))
            {
               
                SqlCommand cmd = new SqlCommand(query ,connection);
                try
                {
                    connection.Open();
                   SqlDataReader reader =   cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            Name = reader.GetString(reader.GetOrdinal("namefirst"))
                        };


                        students.Add(student);
                    }

                    foreach (var student in students)
                    {
                        Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }



        }
    }
}
