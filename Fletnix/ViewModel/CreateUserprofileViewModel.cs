using Fletnix.Messages;
using Fletnix.Model;
using Fletnix.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fletnix.ViewModel
{
    public class CreateUserprofileViewModel: ViewModelBase
    {
        private readonly IUserprofileService _userprofileService;

        private RelayCommand _addUserprofileCommand;

        public Userprofile NewUserprofile { get; set; } 

        public RelayCommand AddUserprofileCOmmand =>
            _addUserprofileCommand ??= new RelayCommand(AddUserprofile);

        public CreateUserprofileViewModel(IUserprofileService userprofileService)
        {
            _userprofileService = userprofileService;
            NewUserprofile = new Userprofile();
        }

        private void AddUserprofile()
        {
            _userprofileService.SaveUserprofile(NewUserprofile);
            MessengerInstance.Send(new UserprofileCreatedMessage(NewUserprofile));
        }

    }
}
