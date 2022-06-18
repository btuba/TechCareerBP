using LogLib;
using DocumentManagementLib;

LoggerFactory Factory = new LoggerFactory("config.json", Format.JSON);
Logger logger = Factory.CreateLogger();

Document document = new Document();
User user = new User("inc", Department.IT,"Susan", logger);

user.LoadDocument("YENİ");
user.ChangeDocumentName(document,"Yeni1");
user.ChangeDocumentName(document, "yeni2");
user.UndoDocumentName(document);
Console.WriteLine(document.Name);

Report report = Report.Instance;

Console.WriteLine();