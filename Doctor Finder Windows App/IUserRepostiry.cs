using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_Finder_Windows_App
{
   public interface IUserRepostiry
    {
        Task<bool> Insert(User user);
    }
}
