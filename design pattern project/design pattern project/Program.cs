// See https://aka.ms/new-console-template for more information
using design_pattern_project;

Console.WriteLine("Hello, World!");
Branch branch = new Branch();
Folder folder = new Folder();
MyFile file = new MyFile();
branch.Add(folder);
branch.Add(file);
folder.Add(file);
branch.Add(new Branch());
branch.print();