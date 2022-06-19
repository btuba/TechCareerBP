using LogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementLib
{
    public class User : Observable
    {
        public Department department;
        public string CompanyName { get; set; }
        public string Name { get; set; }
        private Logger Logger { get; set; }

        public User(string companyName,Department department,string name, Logger logger)
        {
            this.CompanyName = companyName;
            this.department = department;
            this.Name = name;
            this.Logger = logger;
            this.AddObserver(Report.Instance);
            this.NotifyObserver(this);
        }

        public void LoadDocument(string documentName)
        {
            // File operation
            Document document = new Document();
            if(document.Create(this, documentName))
            {
                Logger.Message = "Success";
                Logger.User = Name;
                Logger.Date = DateTime.Now;
                Logger.LogLevel = "0";
                Logger.Log(messageTag: "info");
            }
            else
            {
                Logger.Message = "Error";
                Logger.User = Name;
                Logger.Date = DateTime.Now;
                Logger.LogLevel = "0";
                Logger.Log();
            }
            
        }

        public void ChangeDocumentName(Document document, string name)
        {
            if (document.UpdateName(name))
            {
                Logger.Message = "Success - Changed Document Name";
                Logger.User = Name;
                Logger.Date = DateTime.Now;
                Logger.LogLevel = "0";
                Logger.Log(arg: document.Name);
            }
            else
            {
                Logger.Message = "Error - Unchanged Document Name";
                Logger.User = Name;
                Logger.Date = DateTime.Now;
                Logger.LogLevel = "0";
                Logger.Log(arg: document.Name);
            }
        }

        public void UndoDocumentName(Document document)
        {
            if (document.Undo())
            {
                Logger.Message = "Success - Undo Document Name";
                Logger.User = Name;
                Logger.Date = DateTime.Now;
                Logger.LogLevel = "0";
                Logger.Log(arg: document.Name);
            }
            else
            {
                Logger.Message = "Error - Undo Document Name";
                Logger.User = Name;
                Logger.Date = DateTime.Now;
                Logger.LogLevel = "0";
                Logger.Log(arg: document.Name);
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
