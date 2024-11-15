using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;

namespace Kreata.Backend.Repos
{
    public interface IFelhasznaloRepo
    {
        Task<List<Felhasznalo>> GetAll();
        Task<Felhasznalo?> GetBy(Guid id);
        Task<ControllerResponse> UpdateFelhasznaloAsync(Felhasznalo felhasznalo);
    }
}
