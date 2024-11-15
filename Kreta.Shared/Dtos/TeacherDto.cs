using Kreta.Shared.Models.Datas.Enums;

namespace Kreta.Shared.Dtos
{
    public class TeacherDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthsDay { get; set; }
        public bool IsWoman { get; set; }
        public bool IsHeadTeacher { get; set; }
    }
}
