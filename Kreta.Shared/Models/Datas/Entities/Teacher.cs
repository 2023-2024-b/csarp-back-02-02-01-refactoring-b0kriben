﻿using Kreta.Shared.Models.Datas.Enums;

namespace Kreta.Shared.Models.Datas.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            IsWoman = false;
            IsHeadTeacher = false;
        }
        public Teacher(string firstName, string lastName, DateTime birthsDay, bool isWoman, bool isHeadTeacher)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            IsWoman = isWoman;
            IsHeadTeacher = isHeadTeacher;
        }
        public Teacher(Guid id, string firstName, string lastName, DateTime birthsDay, bool isWoman, bool isHeadTeacher)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            IsWoman = isWoman;
            IsHeadTeacher = isHeadTeacher;
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public bool IsWoman { get; set; }
        public bool IsHeadTeacher { get; set; }
        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }

    }
}
