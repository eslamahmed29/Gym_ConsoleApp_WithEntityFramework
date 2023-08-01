using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ta5beet.Entities
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string? Phone { get; set; }

        public virtual ICollection<Trainee> Trainees { get; set; } = new HashSet<Trainee>();

        public virtual ICollection<GymTrainer> GymTrainers { get; set;}=new HashSet<GymTrainer>();

    }
}
