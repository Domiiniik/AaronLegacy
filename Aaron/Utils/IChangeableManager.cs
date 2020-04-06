﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aaron.Utils
{
    public interface IChangeableManager
    {
        bool HasAnyChanges();

        List<ITracksChanges> GetChangedItems();
    }
}
