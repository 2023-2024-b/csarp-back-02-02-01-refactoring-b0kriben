using Kreta.Shared.Dtos;
using Kreta.Shared.Models.Datas.Entities;

namespace Kreta.Shared.Converters
{
    public static class TeacherConverter
    {
        public static TeacherDto ToDto(this Teacher teacher)
        {
            return new TeacherDto
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                BirthsDay = teacher.BirthsDay,
                IsWoman = teacher.IsWoman,
                IsHeadTeacher = teacher.IsHeadTeacher,
            };
        }

        public static Teacher ToModel(this TeacherDto teacher)
        {
            return new Teacher
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                BirthsDay = teacher.BirthsDay,
                IsWoman = teacher.IsWoman,
                IsHeadTeacher = teacher.IsHeadTeacher,
            };
        }

        public static List<TeacherDto> GetTeachersDtos(this List<Teacher> teacher)
        {
            return teacher.Select(teacher => ToDto(teacher)).ToList();
        }

        public static List<Teacher> GetTeachers(this List<TeacherDto> teacherDtos)
        {
            return teacherDtos.Select(teacherDto => ToModel(teacherDto)).ToList();
        }
    }
}
