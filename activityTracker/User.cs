﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activityTracker
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string MainViewUserInfo
        {
            get
            {
                return $"{ username }: { FirstName } {LastName} ({ Email })";
            }
        }
    }
}
