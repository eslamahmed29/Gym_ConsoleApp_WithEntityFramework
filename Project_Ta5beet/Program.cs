using Microsoft.EntityFrameworkCore;
using Project_Ta5beet.Context;
using Project_Ta5beet.Entities;
using System;
namespace Project_Ta5beet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(Gymanzioum con = new Gymanzioum())
            {
                con.Database.Migrate();
                //add Gyms to database
                #region Add New Gyms
                Gym gym1 = new Gym
                {
                    Name = "4Fit",
                    Address = "Qawmia",
                };
                Gym gym2 = new Gym
                {
                    Name = "CrossFit",
                    Address = "Sadat",
                    Type = "Men"
                };
                var gym3 = new Gym
                {
                    Name = "Fitness Club",
                    Address = "ArdELgam3ia",
                    Type = "Women"
                };
                #endregion

                // add trainers to database
                #region Add New Trainers
                Trainer trainer1 = new Trainer
                {
                    Name = "Kimo",
                    Phone = "0123456789"
                };
                Trainer trainer2 = new Trainer
                {
                    Name = "Seif"
                };
                Trainer trainer3 = new Trainer
                {
                    Name = "Abdulla",
                    Phone = "0147852369"
                };
                Trainer trainer4 = new Trainer
                {
                    Name = "Ziad",
                    Phone = "0124567893"
                };
                Trainer trainer5 = new Trainer
                {
                    Name = "Ola",
                };
                Trainer trainer6 = new Trainer
                {
                    Name = "Noha"
                };

                #endregion

                //trainer1.GymTrainers.Add(new GymTrainer { Gym = gym1, Shift = "AM" });

                // Add New trainees 
                #region Add New Trainers
                Trainee trainee1 = new Trainee
                {
                    Name = "ZoZ",
                    Phone = "01234567",
                    Age = 21,
                    Gym = gym1,
                    Trainer = trainer1,
                };
                Trainee trainee2 = new Trainee
                {
                    Name = "Sayed",
                    Phone = "011144778",
                    Age = 18,
                    Gym = gym1,
                    Trainer = trainer2
                };
                Trainee trainee3 = new Trainee
                {
                    Name = "Eslam",
                    Phone = "01288513225",
                    Age = 20,
                    Gym = gym2,
                    Trainer = trainer3
                };
                Trainee trainee4 = new Trainee
                {
                    Name = "Abdo",
                    Phone = "0122335566",
                    Age = 30,
                    Gym = gym2,
                    Trainer = trainer4
                };
                Trainee trainee5 = new Trainee
                {
                    Name = "Noha",
                    Phone = "014578132",
                    Age = 17,
                    Gym = gym3,
                    Trainer = trainer5
                };
                Trainee trainee6 = new Trainee
                {
                    Name = "Soha",
                    Phone = "0123698745",
                    Age = 30,
                    Gym = gym3,
                    Trainer = trainer6
                };


                // with the same trainer 
                Trainee trainee7 = new Trainee
                {
                    Name = "Tata",
                    Age = 21,
                    Phone = "012457896",
                    Gym = gym1,
                    Trainer = trainer1
                };

                Trainee trainee8 = new Trainee
                {
                    Name = "Lokka",
                    Age = 19,
                    Phone = "0125896374",
                    Gym = gym2,
                    Trainer = trainer1
                };
                Trainee trainee9 = new Trainee
                {
                    Name = "Ali",
                    Age = 26,
                    Phone = "0124578852",
                    Gym = gym1,
                    Trainer = trainer1
                };

                #endregion

                // add Gym_Trainer Table with Shifts

                trainer1.GymTrainers.Add(new GymTrainer { Gym = gym1,GymName=gym1.Name, Shift = "AM", TrainerName=trainer1.Name });
                
                trainer1.GymTrainers.Add(new GymTrainer { Gym = gym2, Shift = "PM",GymName=gym2.Name ,TrainerName=trainer1.Name});
                

                trainer2.GymTrainers.Add(new GymTrainer { Gym = gym1,GymName=gym1.Name, Shift = "AM", TrainerName=trainer2.Name});
                trainer2.GymTrainers.Add(new GymTrainer { Gym = gym2,GymName=gym2.Name, Shift = "PM", TrainerName = trainer2.Name });
                

                trainer3.GymTrainers.Add(new GymTrainer { Gym = gym1,GymName=gym1.Name, Shift = "AM", TrainerName = trainer3.Name });
                trainer3.GymTrainers.Add(new GymTrainer{ Gym = gym2,GymName=gym2.Name, Shift = "PM", TrainerName = trainer3.Name });

                trainer4.GymTrainers.Add(new GymTrainer { Gym = gym1,GymName=gym1.Name ,Shift = "PM", TrainerName = trainer4.Name });

                trainer5.GymTrainers.Add(new GymTrainer { Gym = gym3, GymName = gym3.Name, Shift = "PM", TrainerName = trainer5.Name });

                trainer6.GymTrainers.Add(new GymTrainer { Gym = gym3, GymName=gym3.Name ,Shift = "AM", TrainerName = trainer6.Name });
               
               /* gym1.GymTrainers.Add(new GymTrainer { Trainer = trainer1, Shift = "AM" });
                gym1.GymTrainers.Add(new GymTrainer { Trainer = trainer1, Shift = "PM" });
                gym1.GymTrainers.Add(new GymTrainer { Trainer = trainer2, Shift = "AM" });
                gym1.GymTrainers.Add(new GymTrainer { Trainer = trainer3, Shift = "AM" });
                gym1.GymTrainers.Add(new GymTrainer { Trainer = trainer4, Shift = "PM" });

                gym2.GymTrainers.Add(new GymTrainer { Trainer = trainer1, Shift = "AM" });
                gym2.GymTrainers.Add(new GymTrainer { Trainer = trainer1, Shift = "PM" });
                gym2.GymTrainers.Add(new GymTrainer { Trainer = trainer2, Shift = "AM" });
                gym2.GymTrainers.Add(new GymTrainer { Trainer = trainer2, Shift = "PM" });
                gym2.GymTrainers.Add(new GymTrainer { Trainer = trainer3, Shift = "PM" });

                gym3.GymTrainers.Add(new GymTrainer { Trainer = trainer5, Shift = "PM" });
                gym3.GymTrainers.Add(new GymTrainer { Trainer = trainer6, Shift = "AM" });
*/
                
                // add to database memory 
               
                con.AddRange(new Gym[] { gym1, gym2, gym3 });
               
                con.AddRange(new Trainer[] { trainer1, trainer2, trainer3, trainer4, trainer5, trainer6 });
                con.AddRange(new Trainee[] { trainee1, trainee2, trainee3, trainee4, trainee5, trainee6, trainee7, trainee8, trainee9 });
                con.SaveChanges();
                Console.WriteLine("Done Ya zmiilyy");
                
            }

        }
    }
}
