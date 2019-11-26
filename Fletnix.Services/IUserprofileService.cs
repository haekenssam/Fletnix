using Fletnix.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fletnix.Services
{
    public interface IUserprofileService
    {
        IList<Userprofile> GetUserprofiles();

        void DeleteUserprofile(Userprofile user);

        void SaveUserprofile(Userprofile user);
    }
}
