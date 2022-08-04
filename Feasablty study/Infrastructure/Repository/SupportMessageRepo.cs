using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;

namespace Feasablty_study.Infrastructure.Repository
{
    public class SupportMessageRepo: BaseRepository<Support_Messages>,ISupportMessageRepo
    {
        public SupportMessageRepo(AppDbContext context):base(context)
        {

        }
    }
}
