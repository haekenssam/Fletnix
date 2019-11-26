using Fletnix.Messages;
using Fletnix.Model;
using Fletnix.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Fletnix.ViewModel
{
    public class UserprofileViewModel : ViewModelBase
    {
        private readonly IUserprofileService _userprofileSerivce;
        private Userprofile _selectedUserprofile;
        private RelayCommand _removeUserprofileCommand;
        private RelayCommand _loginCommand;

        public ObservableCollection<Userprofile> Userprofile {get;set;}
        public RelayCommand RemoveUserprofileCommand =>
            _removeUserprofileCommand ??= new RelayCommand(RemoveUserprofile);
        public RelayCommand LoginCommand =>
            _loginCommand ??= new RelayCommand(LoginSelectedProfile, CheckCanExecute);

        public Userprofile SelectedUserprofile
        {
            get => _selectedUserprofile;
            set
            {
                _selectedUserprofile = value;
                LoginCommand.RaiseCanExecuteChanged();
                MessengerInstance.Send(new UserprofileDetailsMessage(_selectedUserprofile));
            }
        }

        public UserprofileViewModel(IUserprofileService userprofileService)
        {
            _userprofileSerivce = userprofileService;
            IList<Userprofile> userprofile = _userprofileSerivce.GetUserprofiles();
            Userprofile = new ObservableCollection<Userprofile>(userprofile);

            MessengerInstance.Register<UserprofileCreatedMessage>(this, OnUserprofileCreated);
        }

        private void LoginSelectedProfile()
        {
            MessengerInstance.Send(new UserprofileDetailsMessage(_selectedUserprofile));
        }

        private bool CheckCanExecute()
        {
            bool check = true;

            if (_selectedUserprofile == null)
            {
                check = false;
            }
            return check;
        }

        private void RemoveUserprofile()
        {
            _userprofileSerivce.DeleteUserprofile(_selectedUserprofile);
            Userprofile.Remove(_selectedUserprofile);
        }

        private void OnUserprofileCreated(UserprofileCreatedMessage msg)
        {
            Userprofile.Add(msg.NewUserprofile);
        }
    }
}
