﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deparments.Exceptions;

public class CapacityLimitException:Exception
{
    public CapacityLimitException(string message) : base(message)
    {
    }
}
