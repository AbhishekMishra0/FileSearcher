﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher
{
     public interface IDriveFinder
    {
        List<string> GetDrives();
    }
}
