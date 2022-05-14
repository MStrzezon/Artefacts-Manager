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
    public class ArtefactTypeDAO : IArtefactTypeDAO
    {
        private readonly ArtefactsManagerDatabaseContext _context;

        public ArtefactTypeDAO()
        {
            _context = new ArtefactsManagerDatabaseContext();
        }

        public ArtefactTypeDAO(ArtefactsManagerDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<ArtefactType> GetAll()
        {
            return _context.ArtefactsTypes.ToList();
        }

        public ArtefactType GetById(int artefactTypeId)
        {
            return _context.ArtefactsTypes.Find(artefactTypeId);
        }

        public void Insert(ArtefactType artefactType)
        {
            _context.ArtefactsTypes.Add(artefactType);
        }

        public void Update(ArtefactType artefactType)
        {
            _context.Entry(artefactType).State = EntityState.Modified;
        }

        public void Delete(int artefactTypeId)
        {
            ArtefactType artefactType = _context.ArtefactsTypes.Find(artefactTypeId);
            _context.ArtefactsTypes.Remove(artefactType);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public ArtefactType GetByName(string name)
        {
            return _context.ArtefactsTypes.Where(c => c.TypeName == name).FirstOrDefault();
        }

        public IEnumerable<ArtefactType> GetByCategory(int categoryId)
        {
            var artefactsByCategory = _context.Artefacts.Where(a => a.Category.CategoryId == categoryId).Include("ArtefactType").ToList();
            return artefactsByCategory.Select(c => c.ArtefactType).Distinct().ToList();
        }
    }
}
