using LogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementLib
{
    public class Document : Observable
    {
        public string Name { get; set; }
        public string Path { get; set; }

        private DocumentOrginator DocumentOrginator = new DocumentOrginator();

        public bool Create(User user, string name)
        {
            try
            {
                Name = name;
                Path = user.CompanyName + user.department;

                DocumentOrginator.Name = name;
                DocumentOrginator.Path = Path;
                DocumentOrginator.Save();
                // create document
                this.AddObserver(Report.Instance);
                this.NotifyObserver(this);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateName(string name)
        {
            try
            {
                Name = name;
                DocumentOrginator.Name = name;
                DocumentOrginator.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Undo()
        {
            try
            {
                DocumentOrginator.Undo();
                DocumentOrginator.Undo();
                Name = DocumentOrginator.Name;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
