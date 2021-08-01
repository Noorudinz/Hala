using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HALA.DL.BO;

namespace HALA.DL.BL.Repositories
{
    public interface IUser
    {
        BO.AuthenticationResult IsUserValid(string userName, string password);
        string[] GetUserRoles(string userName);
        void TrackLogin(LoginAudit audit);
    }
}   
