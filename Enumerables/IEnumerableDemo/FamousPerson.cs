using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    public class FamousPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isFamous { get; set; }

        public FamousPerson(int id ,string name , bool isFamous)
        {
            Id = id;
            Name = name;
            this.isFamous = isFamous;
        }
    }
}
