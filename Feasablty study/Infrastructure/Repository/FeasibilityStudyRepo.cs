using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;

namespace Feasablty_study.Infrastructure.Repository
{
    public class FeasibilityStudyRepo : BaseRepository<Feasibility_study>, IFeasibilityStudyRepo
    {
        public FeasibilityStudyRepo(AppDbContext context) : base(context)
        {

        }
    }
}
