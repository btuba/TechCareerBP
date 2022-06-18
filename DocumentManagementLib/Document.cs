using LogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementLib
{
    public class Document
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public DocumentOrginator DocumentOrginator = new DocumentOrginator();

        public bool Create(User user, string name)
        {
            try
            {
                Name = name;
                Path = user.CompanyName + user.department + name;
                DocumentOrginator.Name = name;
                DocumentOrginator.Path = user.CompanyName + user.department + name;
                DocumentOrginator.Save();
                Report report = Report.Instance;
                report.DocumentCount++;
                // create document
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
                Path = Path + name;
                DocumentOrginator.Name = name;
                DocumentOrginator.Path = Path + name;
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
                Name = DocumentOrginator.Name;
                Path = DocumentOrginator.Path;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
