﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Configuration
{
    public interface IConfiguration
    {
        string SectionName { get; }
    }
}