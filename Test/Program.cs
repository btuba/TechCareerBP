using LogLib;
using DocumentManagementLib;

LoggerFactory Factory = new LoggerFactory("config.json", Format.JSON);
Logger logger = Factory.CreateLogger();

IViewable viewable = logger;
IViewable colorDecorator = new ColoredLoggerDecorator(viewable).SetColor(Color.Red);
IViewable sizeDecorator = new SizedLoggerDecorator(viewable).SetFontSize(FontSize.Medium);

logger.View();

Document document = new Document();
User user = new User("inc", Department.IT,"Susan", logger);

user.LoadDocument("YENİ");
user.ChangeDocumentName(document,"Yeni1");
user.ChangeDocumentName(document, "yeni2");
user.UndoDocumentName(document);

Console.WriteLine(document.Name);

Report report = Report.Instance;

Console.WriteLine();

/*
 * factory
 * singleton
 * visitor
 * memento
 * builder
 * observer 
 * decorator
 */