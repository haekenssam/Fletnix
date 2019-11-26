using Fletnix.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fletnix.Messages
{
    public class UserprofileCreatedMessage
    {
        public Userprofile NewUserprofile { get; set; }

        public UserprofileCreatedMessage(Userprofile newUserprofile)
        {
            NewUserprofile = newUserprofile;
        }
    }
}
