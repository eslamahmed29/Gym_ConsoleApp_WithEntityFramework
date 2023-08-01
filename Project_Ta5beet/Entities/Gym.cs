using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ta5beet.Entities
{
    public class Gym
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        [MaxLength(6)]
        public string? Type { get;set; }
        public virtual ICollection<Trainee> Trainees { get; set; } = new HashSet<Trainee>();
        public virtual ICollection<GymTrainer> GymTrainers { get; set;} = new HashSet<GymTrainer>();
    }
}
