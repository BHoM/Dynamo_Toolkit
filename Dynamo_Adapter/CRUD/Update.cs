﻿using BH.Adapter.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Adapter.DynamoBIM
{
    public partial class DynamoBIMAdapter
    {
        public override int UpdateProperty(FilterQuery filter, string property, object newValue, Dictionary<string, object> config = null)
        {
            throw new NotImplementedException();
        }
    }
}