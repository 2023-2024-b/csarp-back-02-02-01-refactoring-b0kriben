using Kreta.Shared.Models.Datas.Enums;

namespace Kreta.Shared.Models.Datas.Entities
{
    public class Felhasznalo
    {
        public Felhasznalo()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            IsWoman = false;
            Phonenumber = string.Empty;
            Email = string.Empty;

        }
        public Felhasznalo(string firstName, string lastName, DateTime birthsDay, bool isWoman, string phonenumber, string email)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            IsWoman = isWoman;
            Phonenumber = phonenumber;
            Email = email;
        }
        public Felhasznalo(Guid id, string firstName, string lastName, DateTime birthsDay, bool isWoman, string phonenumber, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            IsWoman = isWoman;
            Phonenumber = phonenumber;
            Email = email;
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public bool IsWoman { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
