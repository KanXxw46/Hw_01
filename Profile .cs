using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_01
{
    public class Profile
    {
        public string Password { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public int Number { get; set; }
        public int Age { get; set; }
        public string NickName { get; set; }
        public string Сommunication { get; set; }
        public int Data { get; set; }
        public string Status { get; set; }
        public string Calls { get; set; }

    }

    public class User
    {
        private string firstname;

        public string Name
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }
    }
}
