using design_pattern_project;
using design_pattern_project.Observer;
using design_pattern_project.State;

var mainBranch = new Branch("main");
var serverBranch = new Branch("server");
var clientBranch = new Branch("client");
var DBBranch = new Branch("DB");

mainBranch.Add(serverBranch);
mainBranch.Add(clientBranch);
mainBranch.Add(DBBranch);

var newfoldder = new Folder("newfoldder");
var newfoldder1 = new Folder("newfoldder1");
var program = new MyFile("program");
clientBranch.Add(newfoldder);
clientBranch.Add(newfoldder1);
clientBranch.Add(program);


var img = new Folder("img");
var documents = new Folder("documents");
var document = new MyFile("documents");
clientBranch.Add(img);
clientBranch.Add(document);
clientBranch.Add(documents);
//Compossite and Prototype
Console.WriteLine("The original branch:");
mainBranch.print();
var cloneBranch = mainBranch.clone();
Console.WriteLine("The clone branch:");
cloneBranch.print();



//observer and state
var user = new User("1234");
var user2 = new User("356");
document._status.ChangeStatus(document, user);
document._status.PrintStatus();
document._status.ChangeStatus(document, user);
document._status.PrintStatus();
document._status.ChangeStatus(document, user);
document._status.PrintStatus();
document._status.ChangeStatus(document, user);
document._status.PrintStatus();
document._status.ChangeStatus(document, user);
document._status.PrintStatus();

program._status.ChangeStatus(program, user2);
program._status.PrintStatus();
program._status.ChangeStatus(program, user2);
program._status.PrintStatus();
program._status.ChangeStatus(program, user2);
program._status.PrintStatus();
program._status.ChangeStatus(program, user2);
program._status.PrintStatus();
program._status.ChangeStatus(program, user2);
program._status.PrintStatus();

//memento
program.ShowHistory();  
document.ShowHistory();
document.Undo();
document.ShowHistory();