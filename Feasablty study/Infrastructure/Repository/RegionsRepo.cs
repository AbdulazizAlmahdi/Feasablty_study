using Feasablty_study.Domin.Entites;
using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Feasablty_study.Infrastructure.Repository
{
    public class RegionsRepo: BaseRepository<Regions>,IRegionsRepo
    {
        public RegionsRepo(AppDbContext context):base(context)
        {
    
        }

        public IEnumerable<object> Users => throw new System.NotImplementedException();

        public Task FindAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public string GetUserId(ClaimsPrincipal user)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
