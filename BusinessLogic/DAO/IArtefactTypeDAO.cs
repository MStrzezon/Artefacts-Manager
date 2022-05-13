﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.Data.Models;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public interface IArtefactTypeDAO
    {
        IEnumerable<ArtefactType> GetAll();
        ArtefactType GetById(int artefactTypeId);
        void Insert(ArtefactType artefactType);
        void Update(ArtefactType artefactType);
        void Delete(int artefactTypeId);
        void Save();

        ArtefactType GetByName(string name);
    }
}
