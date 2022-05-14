using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;

namespace ArtefactsManager.BusinessLogic
{
    public class ElementService
    {
        private readonly IArtefactTypeDAO artefactTypeDAO;
        private readonly IAttributeDAO attributeDAO;
        private readonly IArtefactDAO artefactDAO;

        public ElementService()
        {
            artefactTypeDAO = new ArtefactTypeDAO();
            attributeDAO = new AttributeDAO();
            artefactDAO = new ArtefactDAO();
        }

        public IEnumerable<ArtefactType> getAllArtefactsTypes()
        {
            return artefactTypeDAO.GetAll();
        }

        private IEnumerable<Data.Models.Attribute> getAllAttributesByArtefactType(string ArtefactTypeName)
        {
            int artefactTypeId = artefactTypeDAO.GetByName(ArtefactTypeName).ArtefactTypeId;
            return attributeDAO.GetByArtefactType(artefactTypeId);

        }

        public List<TextBox> loadTextBoxes(string ArtefactTypeName)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            TextBox tmpTextBox;
            int start = 27;
            foreach (var att in getAllAttributesByArtefactType(ArtefactTypeName))
            {
                tmpTextBox = new TextBox();
                tmpTextBox.Tag = att;
                tmpTextBox.Location = new System.Drawing.Point(start, 10);
                textBoxes.Add(tmpTextBox);
                start += 30;
            }
            return textBoxes;
        }

        public List<Label> loadLabels(string ArtefactTypeName)
        {
            List<Label> labels = new List<Label>();
            Label tmpLabel;
            int start = 10;
            foreach (var att in getAllAttributesByArtefactType(ArtefactTypeName))
            {
                tmpLabel = new Label();
                tmpLabel.Text = att.Name;
                tmpLabel.Tag = att;
                tmpLabel.Location = new System.Drawing.Point(start, 10);
                labels.Add(tmpLabel);
                start += 30;
            }
            return labels;
        }

        public bool saveElement(ArtefactType type, string name, Dictionary<Data.Models.Attribute, string> attributes, Category category)
        {
            Artefact artefact = new Artefact();
            artefact.Name = name;
            artefact.Created = DateTime.Now;
            artefactDAO.Insert(artefact);
            artefact.ArtefactType = type;
            artefact.Category = category;
            List<ArtefactAttribute> attributesList = new List<ArtefactAttribute>();
            foreach (KeyValuePair<Data.Models.Attribute, string> entry in attributes)
            {
                attributesList.Add(new ArtefactAttribute { Attribute = entry.Key, Value = entry.Value });
            }
            artefact.ArtefactAttributes = attributesList;
            artefactDAO.Save(); 
            return true;
        }
    }
}
