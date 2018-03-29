using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF101.Model
{
    public class Actor
    {
        public int ActorID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfWedding { get; set; }
    }
}
