﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteeApplication
{
    public enum LoginResult
    {
        None = -1,
        LoggedIn = 0,
        Failed = 1,
        NotExist = 2,
        NoPermissions = 3
    }
}
