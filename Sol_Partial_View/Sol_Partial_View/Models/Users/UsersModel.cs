using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Partial_View.Models.Users
{
    public class UsersModel
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public UserCommunicationModel UserCommunication { get; set; }

        public UsersLoginModel UsersLogin { get; set; }
    }
}
