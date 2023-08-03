using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project_Ta5beet.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ta5beet.Context
{
    public class Gymanzioum:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("data source=.;initial catalog=Gymanzioum;Encrypt=False;integrated security=True;Trusted_Connection=True;TrustServerCertificate=true");
        public override int SaveChanges()
        {
            var entites = from e in ChangeTracker.Entries()
                          where e.State == EntityState.Added || e.State == EntityState.Modified
                          select e.Entity;

            foreach (var e in entites)
            {
                ValidationContext validation = new ValidationContext(e);
                Validator.ValidateObject(e, validation, true);
            }

            return base.SaveChanges();
        }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Gym> Gyms { get; set; }
        public virtual DbSet<GymTrainer> GymTrainers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainee>()
                .HasOne(tr => tr.Trainer)
                .WithMany(te => te.Trainees);

            modelBuilder.Entity<Trainer>()
                .HasMany(te => te.Trainees)
                .WithOne(tr => tr.Trainer);

            modelBuilder.Entity<Gym>()
                .HasMany(tr => tr.Trainees)
                .WithOne(g => g.Gym);

            modelBuilder.Entity<Trainee>()
                .HasOne(g => g.Gym)
                .WithMany(te => te.Trainees);


            modelBuilder.Entity<Gym>()
                .HasMany(gt => gt.GymTrainers)
                .WithOne(g => g.Gym);

            modelBuilder.Entity<Trainer>()
                .HasMany(gt => gt.GymTrainers)
                .WithOne(gt => gt.Trainer);

            modelBuilder.Entity<Trainer>(Ent =>
            {
                Ent.HasKey(e => e.Id);

            });

            modelBuilder.Entity<Gym>(Ent =>
            {
                Ent.HasKey(e => e.Id); 
            });

            modelBuilder.Entity<Trainee>(Ent =>
            {
                Ent.HasKey(e => e.Id);

                
            });

            modelBuilder.Entity<GymTrainer>(Ent =>
            {
                Ent.HasKey(k => new { k.TrainerID, k.GymID });
            });
               

            
            base.OnModelCreating(modelBuilder);
        }
        


    }
}
