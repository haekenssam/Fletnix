using Fletnix.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fletnix.Messages
{
    public class UserprofileDetailsMessage
    {
        public Userprofile Userprofile { get; set; }

        public UserprofileDetailsMessage(Userprofile userprofile)
        {
            Userprofile = userprofile;
        }
    }
}
