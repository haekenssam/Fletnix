using System;
using System.Collections.Generic;
using System.Text;
using Fletnix.Model;
using Fletnix.Repositories;

namespace Fletnix.Services
{
    public class UserprofileService : IUserprofileService
    {
        private readonly IRepository<Userprofile> _userRepository;

        public UserprofileService(IRepository<Userprofile> userRepository)
        {
            _userRepository = userRepository;
        }
        public void DeleteUserprofile(Userprofile user)
        {
            _userRepository.Delete(user);
        }

        public IList<Userprofile> GetUserprofiles()
        {
            return _userRepository.Get();
        }

        public void SaveUserprofile(Userprofile user)
        {
            _userRepository.Create(user);
        }
    }
}
