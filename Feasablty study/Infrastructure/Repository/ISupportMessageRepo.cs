using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Feasablty_study.Infrastructure.Repository
{
    public interface ISupportMessageRepo : IBaseRepository<Support_Messages>
    {
        
    }
}
