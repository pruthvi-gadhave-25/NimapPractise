using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    class FamousPerson
    {

        public FamousPerson(int id, string name, bool canFly) 
        {
            Id = id; 
            Name = name;
            CanFly = canFly;
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool CanFly { get; set; }
    }
}
