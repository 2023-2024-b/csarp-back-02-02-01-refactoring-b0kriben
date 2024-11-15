using Kreta.Shared.Dtos;
using Kreta.Shared.Models.Datas.Entities;
using System.ComponentModel.DataAnnotations;

namespace Kreta.Shared.Converters
{
    public static class FelhasznaloConverter
    {
        public static FelhasznaloDto ToDto(this Felhasznalo felhasznalo)
        {
            return new FelhasznaloDto
            {
                Id = felhasznalo.Id,
                FirstName = felhasznalo.FirstName,
                LastName = felhasznalo.LastName,
                BirthsDay = felhasznalo.BirthsDay,
                IsWoman = felhasznalo.IsWoman,
                Phonenumber = felhasznalo.Phonenumber,
                Email = felhasznalo.Email,
            };
        }

        public static Felhasznalo ToModel(this FelhasznaloDto felhasznalo)
        {
            return new Felhasznalo
            {
                Id = felhasznalo.Id,
                FirstName = felhasznalo.FirstName,
                LastName = felhasznalo.LastName,
                BirthsDay = felhasznalo.BirthsDay,
                IsWoman = felhasznalo.IsWoman,
                Phonenumber = felhasznalo.Phonenumber,
                Email = felhasznalo.Email,
            };
        }

        public static List<FelhasznaloDto> GetFelhasznalokDtos(this List<Felhasznalo> felhasznalo)
        {
            return felhasznalo.Select(felhasznalo => ToDto(felhasznalo)).ToList();
        }

        public static List<Felhasznalo> GetFelhasznalok(this List<FelhasznaloDto> felhasznaloDtos)
        {
            return felhasznaloDtos.Select(felhasznaloDto => ToModel(felhasznaloDto)).ToList();
        }
    }
}
