﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team8Project.Contracts
{
    public interface IReader
    {
        string ConsoleReadLine();
        string ConsoleReadKey();
    }
}