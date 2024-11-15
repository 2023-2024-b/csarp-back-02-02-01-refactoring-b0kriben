using Kreata.Backend.Context;
using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class FelhasznaloRepo : IFelhasznaloRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public FelhasznaloRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Felhasznalo>> GetAll()
        {
            return await _dbContext.Felhasznalok.ToListAsync();
        }

        public async Task<Felhasznalo?> GetBy(Guid id)
        {
            return await _dbContext.Felhasznalok.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<ControllerResponse> UpdateFelhasznaloAsync(Felhasznalo felhasznalo)
        {
            ControllerResponse response = new ControllerResponse();
            _dbContext.ChangeTracker.Clear();
            _dbContext.Entry(felhasznalo).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                response.AppendNewError(e.Message);
                response.AppendNewError($"{nameof(FelhasznaloRepo)} felhasználó, {nameof(UpdateFelhasznaloAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{felhasznalo} frissítése nem sikerült!");
            }
            return response;
        }
    }
}
