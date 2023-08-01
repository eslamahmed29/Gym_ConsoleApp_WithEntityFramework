using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ta5beet.Entities
{
    public class GymTrainer
    {
        public int GymID { get; set; }
        
        public string GymName { get; set; }
        public int TrainerID { get; set; }
        public string TrainerName { get; set; }
        [MaxLength(2)]
        public string Shift { get; set; }
       
        public virtual Gym Gym { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
