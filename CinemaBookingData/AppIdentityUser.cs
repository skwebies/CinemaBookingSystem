﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingData
{
    public class AppIdentityUser : IdentityUser
    {
        public int Age { get; set; }
    }
}
