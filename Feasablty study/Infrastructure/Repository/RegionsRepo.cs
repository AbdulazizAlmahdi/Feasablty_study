using Feasablty_study.Domin.Entites;
using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;

namespace Feasablty_study.Infrastructure.Repository
{
    public class RegionsRepo: BaseRepository<Regions>,IRegionsRepo
    {
        public RegionsRepo(AppDbContext context):base(context)
        {
    
        }
    }
}
