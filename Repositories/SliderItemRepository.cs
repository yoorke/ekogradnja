﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ekogradnjaBE;
using RepositoryInterfaces;

namespace Repositories
{
    public class SliderItemRepository : GenericRepository<SliderItem>, ISliderItemRepository
    {
        public SliderItemRepository()
        {

        }
    }
}
