using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ta5beet.Entities
{
    public class Trainee
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual Gym Gym { get; set; }
    }
}
