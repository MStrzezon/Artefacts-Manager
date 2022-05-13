using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.Data;
using Microsoft.EntityFrameworkCore;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public class AttributeDAO : IAttributeDAO
    {
        private readonly ArtefactsManagerDatabaseContext _context;

        public AttributeDAO()
        {
            _context = new ArtefactsManagerDatabaseContext();
        }

        public AttributeDAO(ArtefactsManagerDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Data.Models.Attribute> GetAll()
        {
            return _context.Attributes.ToList();
        }

        public Data.Models.Attribute GetById(int attributeId)
        {
            return _context.Attributes.Find(attributeId);
        }

        public void Insert(Data.Models.Attribute attribute)
        {
            _context.Attributes.Add(attribute);
        }

        public void Update(Data.Models.Attribute attribute)
        {
            _context.Entry(attribute).State = EntityState.Modified;
        }

        public void Delete(int attributeId)
        {
            Data.Models.Attribute attribute = _context.Attributes.Find(attributeId);
            _context.Attributes.Remove(attribute);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
