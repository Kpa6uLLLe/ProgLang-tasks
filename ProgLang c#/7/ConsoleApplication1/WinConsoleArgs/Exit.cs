﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsApp
{
    //[0]
    public class Exit : Task
    {
        public Exit()
        {
            Environment.Exit(0);
        }
    }
}
