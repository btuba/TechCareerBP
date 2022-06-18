using LogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementLib
{
    public class User
    {
        public Department department;
        public string CompanyName { get; set; }
        public string Name { get; set; }

        Logger Logger { get; set; }
        public User(string companyName,Department department,string name, Logger logger)
        {
            Report report = Report.Instance;
            report.UserCount++;
            this.CompanyName = companyName;
            this.department = department;
            this.Name = name;
            this.Logger = logger;
        }

        public void LoadDocument(/*FileStream fileStream,*/ string documentName)
        {
            // File operation
            Document document = new Document();
            if(document.Create(this, documentName))
            {
                Logger.Log("Success", Name, DateTime.Now, "level");
            }
            else
            {
                Logger.Log("Error", Name, DateTime.Now, "level");
            }
            
        }

        public void ChangeDocumentName(Document document, string name)
        {
            if (document.UpdateName(name))
            {
                Logger.Log(message:"Success Changed Document Name",
                    user: Name, 
                    date: DateTime.Now,
                    logLevel: "level",
                    arg: document.Name);
            }
            else
            {
                Logger.Log("Error", Name, DateTime.Now, "level");
            }
        }

        public void UndoDocumentName(Document document)
        {
            if (document.Undo())
            {
                Logger.Log("Undo Success", Name, DateTime.Now, "level");
            }
            else
            {
                Logger.Log("Undo Error", Name, DateTime.Now, "level");
            }
        }
    }

    public enum Department
    {
        HRM,
        IT,
        SALE
    }
}
