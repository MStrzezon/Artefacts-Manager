﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;

namespace ArtefactsManager.BusinessLogic.Catalog
{
    public class AddCategoryService
    {
        private readonly ICategoryDAO categoryDAO;

        public AddCategoryService()
        {
            categoryDAO = new CategoryDAO();
        }

        public bool saveCategory(string categoryName)
        {
            if (categoryDAO.GetByName(categoryName) == null)
            {
                Category category = new Category();
                category.CategoryName = categoryName;
                categoryDAO.Insert(category);
                categoryDAO.Save();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
