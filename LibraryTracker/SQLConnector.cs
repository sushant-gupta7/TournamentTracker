﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTracker
{
    public class SQLConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;

            return model;
        }
    }
}
