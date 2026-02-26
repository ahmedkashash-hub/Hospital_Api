using Hospital.Domain;
using Hospital.Domain.Enyities;
using Hospital.Domain.Enyities.PatientInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Hospital.Infrastructure.Persistence.Database
{
  




    public class HospitalDbContex : DbContext
    {
        private readonly AuditInterceptor? _auditInterceptor;

        public HospitalDbContex(DbContextOptions<HospitalDbContex> options, AuditInterceptor? auditInterceptor = null) : base(options)
        {
            _auditInterceptor = auditInterceptor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.OwnsOne(p => p.AddressInformation);
                entity.OwnsOne(typeof(ContactInfo), nameof(Person.ContactInformation));
            });
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_auditInterceptor is not null)
                optionsBuilder.AddInterceptors(_auditInterceptor);

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Surgery> Surgeries  { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Disase> Disases { get; set; }


    }
}
