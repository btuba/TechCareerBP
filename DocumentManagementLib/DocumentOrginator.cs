using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementLib
{
    public class DocumentOrginator
    {
        public string Name { get; set; }
        public string Path { get; set; }
        private DocumentCareTaker _documentCareTaker;

        public DocumentOrginator()
        {
            _documentCareTaker = new DocumentCareTaker();
        }

        public void Save()
        {
            _documentCareTaker.Document = new Document
            {
                Name = this.Name,
                Path = this.Path
            };
        }

        public void Undo()
        {
            Document previousDocument = _documentCareTaker.Document;

            Name = previousDocument.Name;
            Path = previousDocument.Path;
        }

        public override string ToString()
        {
            return $"{Name} {Path}";
        }
    }
}
