using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF101.Model
{
    public class Director
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool? isGood { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? MarriageDate { get; set; }
        public int Age { get; set; }
    }
}
