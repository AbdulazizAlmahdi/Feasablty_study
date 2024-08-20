using Feasablty_study.Controllers;
using Feasablty_study.Models;

using System.Collections.Generic;

namespace Feasablty_study.Domin.ViewModels
{
    public class ViewModelAllOpreation
    {
       public   CreateUserViewModel CreateUserViewModel { get; set; }
      public IEnumerable<User> Users { get; set; }
        public object UserList { get; internal set; }
    }
}
