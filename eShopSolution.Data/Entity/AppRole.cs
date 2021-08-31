﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { set; get; }
    }
}
