﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesAlipio.BookingSystem.Windows.Helpers
{
    public class Operation
    {
        public Guid? ReferenceId { get; set; }
        public string Code { get; set; }

        public string Message { get; set; }
    }
}
