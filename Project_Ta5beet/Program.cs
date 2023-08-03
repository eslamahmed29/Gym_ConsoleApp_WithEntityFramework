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
                /*  Gym gym1 = new Gym
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
                  };*/
                #endregion

                // add trainers to database
                #region Add New Trainers
                /* Trainer trainer1 = new Trainer
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
                 };*/

                #endregion



                // Add New trainees 
                #region Add New Trainees
                /* Trainee trainee1 = new Trainee
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
                 };*/

                #endregion

                // add Gym_Trainer Table with Shifts
                #region Add GymTrainer
                /* trainer1.GymTrainers.Add(new GymTrainer { Gym = gym1, GymName = gym1.Name, Shift = "AM", TrainerName = trainer1.Name });

                 trainer1.GymTrainers.Add(new GymTrainer { Gym = gym2, Shift = "PM", GymName = gym2.Name, TrainerName = trainer1.Name });


                 trainer2.GymTrainers.Add(new GymTrainer { Gym = gym1, GymName = gym1.Name, Shift = "AM", TrainerName = trainer2.Name });
                 trainer2.GymTrainers.Add(new GymTrainer { Gym = gym2, GymName = gym2.Name, Shift = "PM", TrainerName = trainer2.Name });


                 trainer3.GymTrainers.Add(new GymTrainer { Gym = gym1, GymName = gym1.Name, Shift = "AM", TrainerName = trainer3.Name });
                 trainer3.GymTrainers.Add(new GymTrainer { Gym = gym2, GymName = gym2.Name, Shift = "PM", TrainerName = trainer3.Name });

                 trainer4.GymTrainers.Add(new GymTrainer { Gym = gym1, GymName = gym1.Name, Shift = "PM", TrainerName = trainer4.Name });

                 trainer5.GymTrainers.Add(new GymTrainer { Gym = gym3, GymName = gym3.Name, Shift = "PM", TrainerName = trainer5.Name });

                 trainer6.GymTrainers.Add(new GymTrainer { Gym = gym3, GymName = gym3.Name, Shift = "AM", TrainerName = trainer6.Name });
 */
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

                #endregion

                // add to database memory 
                #region Add to memory
                /* con.AddRange(new Gym[] { gym1, gym2, gym3 });

                con.AddRange(new Trainer[] { trainer1, trainer2, trainer3, trainer4, trainer5, trainer6 });
                con.AddRange(new Trainee[] { trainee1, trainee2, trainee3, trainee4, trainee5, trainee6, trainee7, trainee8, trainee9 });
               */
                #endregion

                Console.WriteLine("Enter What category you want ?");
                Console.WriteLine("1 : Gym \n" +
                    "2 : Trainers \n" +
                    "3 : Trainees \n"+
                    "4: View Trainers Gym and Shifts "
                    
                    );
                int n=int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("What do you need ? \n");
                    Console.WriteLine("1 : Add New Gym \n"+
                        "2 : View A list Of Gyms \n ");
                    int x=int.Parse(Console.ReadLine());
                    if(x == 1)
                    {
                        string gname,add,typ;
                        Console.Write("Please Enter Gym Name : "); gname = Console.ReadLine();
                        Console.Write("Please Enter Gym Address : "); add=Console.ReadLine();
                        Console.Write("Please Enter Gym Type : ");typ=Console.ReadLine() ;
                        Gym gym = new Gym()
                        {
                            Name = gname,
                            Address = add,
                            Type = typ
                        };
                        con.Add(gym);
                        con.SaveChanges();
                    }
                    if (x == 2)
                    {
                        var list = (from gy in con.Gyms
                                   
                                   select gy).ToList();
                        
                        foreach (var item in list)
                        {
                            
                            Console.Write(item.Id+" ");
                            Console.Write(item.Name+" ");
                            Console.Write(item.Address + " ");
                            Console.Write(item.Type + " ");
                            Console.WriteLine();
                        }
                    }
                }


                if (n == 2)
                {
                    Console.WriteLine("What do you need ? \n");
                    Console.WriteLine("1 : Add New Trainer \n" +
                        "2 : View A list Of Trainers \n"
                        );
                    int y=int.Parse(Console.ReadLine());
                    if (y == 1)
                    {
                        string trname, trphone;
                        Console.Write("Please Enter Trainer Name : "); trname= Console.ReadLine();
                        Console.Write("Please Enter Trainer Phone : "); trphone = Console.ReadLine();
                        Trainer tr = new Trainer()
                        {
                            Name = trname,
                            Phone = trphone
                        };
                        con.Add(tr);
                        con.SaveChanges();

                    }

                    if(y == 2)
                    {
                        var lst = (from tr in con.Trainers
                                  select tr).ToList();
                        foreach (var item in lst)
                        {
                            Console.Write(item.Id + " ");
                            Console.Write(item.Name + " ");
                            Console.Write(item.Phone + " ");
                            Console.WriteLine();
                        }
                    }
                   
                }



                if (n == 3)
                {
                    Console.WriteLine("What do you need ? \n");
                    Console.Write("1 : Add New Trainee \n" +
                        "2 : View A list Of Trainees \n"
                        );
                    int z=int.Parse(Console.ReadLine());
                    if (z == 1)
                    {
                        //var tename, tephone,age,trid,gymid;
                        string tename, tephone;
                        int teage;
                        Console.Write("Enter The Trainee Name : "); tename= Console.ReadLine();
                        Console.Write("Enter The Trainee Phone : "); tephone= Console.ReadLine();
                        Console.Write("Enter the Trainee Age : ");teage = int.Parse(Console.ReadLine());

                        Trainee te = new Trainee()
                        {
                            Name = tename,
                            Phone=tephone,
                            Age=teage
                           
                        };
                        con.Add(te);
                        con.SaveChanges();
                    }
                    if (z == 2)
                    {
                        var lista = (from te in con.Trainees
                                     select te).ToList();
                        foreach(var item in lista)
                        {
                            Console.Write(item.Id+" ");
                            Console.Write(item.Name+" ");
                            Console.Write(item.Phone+ " ");
                            Console.Write(item.Age + " ");
                            Console.WriteLine();
                        }
                    }
                }
                if (n == 4)
                {
                    var listaia = (from gt in con.GymTrainers
                                   select gt).ToList();
                    foreach (var item in listaia)
                    {
                        Console.Write("Trainer ID: "+item.TrainerID+" ,");
                        Console.Write("Trainer Name: "+item.TrainerName+" ,");
                        Console.Write("GymID: "+item.GymID+" ,");
                        Console.Write("Gym Name: "+item.GymName+" ,");
                        Console.Write("Shift: "+item.Shift+" ,");
                        Console.WriteLine();
                    }
                }

            }

        }
    }
}
