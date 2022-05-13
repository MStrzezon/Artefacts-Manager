﻿using ArtefactsManager.Data;
using ArtefactsManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public class ArtefactDAO : IArtefactDAO
    {
        private readonly ArtefactsManagerDatabaseContext _context;

        public ArtefactDAO()
        {
            _context = new ArtefactsManagerDatabaseContext();
        }

        public ArtefactDAO(ArtefactsManagerDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Artefact> GetAll()
        {
            return _context.Artefacts.ToList();
        }

        public Artefact GetById(int artefactId)
        {
            return _context.Artefacts.Find(artefactId);
        }

        public void Insert(Artefact artefact)
        {
            _context.Artefacts.Add(artefact);
        }

        public void Update(Artefact artefact)
        {
            _context.Entry(artefact).State = EntityState.Modified;
        }

        public void Delete(int artefactId)
        {
            Artefact artefact = _context.Artefacts.Find(artefactId);    
            _context.Artefacts.Remove(artefact);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}