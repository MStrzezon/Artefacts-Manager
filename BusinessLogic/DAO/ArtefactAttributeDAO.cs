using ArtefactsManager.Data;
using ArtefactsManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public class ArtefactAttributeDAO : IArtefactAttributeDAO
    {
        private readonly ArtefactsManagerDatabaseContext _context;

        public ArtefactAttributeDAO()
        {
            _context = new ArtefactsManagerDatabaseContext();
        }

        public ArtefactAttributeDAO(ArtefactsManagerDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<ArtefactAttribute> GetAll()
        {
            return _context.ArtefactsAttributes.ToList();
        }

        public ArtefactAttribute GetById(int artefactId, int attributeId)
        {
            return _context.ArtefactsAttributes.Find(artefactId, attributeId);
        }

        public void Insert(ArtefactAttribute artefactAttribute)
        {
            _context.ArtefactsAttributes.Add(artefactAttribute);
        }

        public void Update(ArtefactAttribute artefactAttribute)
        {
            _context.Entry(artefactAttribute).State = EntityState.Modified;
        }

        public void Delete(int artefactId, int attributeId)
        {
            ArtefactAttribute artefactAttribute = _context.ArtefactsAttributes.Find(artefactId, attributeId);
            _context.ArtefactsAttributes.Remove(artefactAttribute);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
