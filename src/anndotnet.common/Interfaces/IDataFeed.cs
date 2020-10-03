﻿using NumSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnnDotNET.Common
{
    public interface IDataFeed 
    {
        IEnumerable<(NDArray xBatch, NDArray yBatch)> GetNextBatch();
        (NDArray xBatch, NDArray yBatch) GetFullBatch();
    }
}
