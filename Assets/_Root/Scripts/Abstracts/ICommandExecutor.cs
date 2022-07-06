﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public interface ICommandExecutor
    {
        void ExecuteCommand(object command);
    }
}
