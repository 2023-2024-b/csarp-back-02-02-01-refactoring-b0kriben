using Kreta.Shared.Models.Datas.Enums;

namespace Kreta.Shared.Dtos
{
    public class FelhasznaloDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthsDay { get; set; }
        public bool IsWoman { get; set; }
        public string Phonenumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
