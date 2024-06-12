﻿using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository: ICatergoryRepository
    {
        public List<Category> GetCategories()
            => CategoryDAO.GetCategories();
    }
}
