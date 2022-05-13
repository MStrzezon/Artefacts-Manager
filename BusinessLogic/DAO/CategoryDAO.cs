using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.Data;
using ArtefactsManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public class CategoryDAO : ICategoryDAO
    {
        private readonly ArtefactsManagerDatabaseContext _context;

        public CategoryDAO()
        {
            _context = new ArtefactsManagerDatabaseContext();
        }

        public CategoryDAO(ArtefactsManagerDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
        public Category GetById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }
        public void Insert(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Update(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
        }

        public void Delete(int categoryId)
        {
            Category category = _context.Categories.Find(categoryId);
            _context.Categories.Remove(category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Category GetByName(string name)
        {
            return _context.Categories.Where(c => c.CategoryName == name).FirstOrDefault(); 
        }

    }
}
