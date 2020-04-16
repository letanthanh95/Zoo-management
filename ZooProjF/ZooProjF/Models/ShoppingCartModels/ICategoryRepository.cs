﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooProjF.Models.ShoppingCartModels
{
    interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; set; }
    }
}
