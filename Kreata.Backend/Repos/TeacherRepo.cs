using Kreata.Backend.Context;
using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public TeacherRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Teacher>> GetAll()
        {
            return await _dbContext.Teachers.ToListAsync();
        }

        public async Task<Teacher?> GetBy(Guid id)
        {
            return await _dbContext.Teachers.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<ControllerResponse> UpdateTeacherAsync(Teacher teacher)
        {
            ControllerResponse response = new ControllerResponse();
            _dbContext.ChangeTracker.Clear();
            _dbContext.Entry(teacher).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                response.AppendNewError(e.Message);
                response.AppendNewError($"{nameof(TeacherRepo)} tanár, {nameof(UpdateTeacherAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{teacher} frissítése nem sikerült!");
            }
            return response;
        }
    }
}
