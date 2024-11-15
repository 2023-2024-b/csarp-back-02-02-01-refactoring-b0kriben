using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            List<Teacher> teachers = new()
            {
                new Teacher
                {
                    Id = Guid.NewGuid(),
                    FirstName="Feri",
                    LastName="Földrajz",
                    BirthsDay=new DateTime(1999,01,01),
                    IsHeadTeacher=true,
                    IsWoman=false,
                },
                new Teacher
                {
                    Id = Guid.NewGuid(),
                    FirstName="Fruzsina",
                    LastName="Fizika",
                    BirthsDay=new DateTime(1993,01,01),
                    IsHeadTeacher=false,
                    IsWoman=true,
                }
            };

            List<Felhasznalo> felhsznalok = new()
            {
                new Felhasznalo
                {
                    Id = Guid.NewGuid(),
                    FirstName="Mária",
                    LastName="Farkas",
                    BirthsDay=new DateTime(1979,06,01),
                    IsWoman=false,
                    Phonenumber="06705463278",
                    Email="farkasmari@gmail.com"
                },
                new Felhasznalo
                {
                    Id = Guid.NewGuid(),
                    FirstName="Márton",
                    LastName="Tél",
                    BirthsDay=new DateTime(1989,02,01),
                    IsWoman=true,
                    Phonenumber="06307459201",
                    Email="telMarton@gmail.com"
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);
            //Teachers
            modelBuilder.Entity<Teacher>().HasData(teachers);
            //Felhszanalok
            modelBuilder.Entity<Felhasznalo>().HasData(felhsznalok);
        }
    }
}
