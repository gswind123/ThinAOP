﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ThinAOP.Metadata
{
    public class ResultMetadata
    {
        private object _result;

        public ResultMetadata(object result)
        {
            _result = result;
        }

        public virtual object Result
        {
            get;
            set;
        }
    }
}
