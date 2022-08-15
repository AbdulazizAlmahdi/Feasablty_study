using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Feasablty_study.Infrastructure.Repository
{
    public interface IFeasibilityStudyRepo : IBaseRepository<Feasibility_study>
    {
        Task AddAsync(CreateFeasibilityStudyViewModel model, string UserId);
         /*Task<IEnumerable<Feasibility_study>> GetAllAsync(string userId);
        Task<IEnumerable<Feasibility_study>> GetAllAsync(params Expression<Func<Feasibility_study, object>>[] includeProperties,string userId);*/

    }
}
