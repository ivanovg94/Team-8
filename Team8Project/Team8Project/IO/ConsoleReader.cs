﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team8Project.Contracts;

namespace Team8Project.IO
{
    public class ConsoleReader: IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
