// See https://aka.ms/new-console-template for more information
using DI.Basic.Explore.Me;
using DI.Basic.Explore.Me.Implementation;

Console.WriteLine("Hello, World!");
Console.WriteLine("File Logger Calling - ctor Example");
BussinessLogic bussinessLogic1 = new BussinessLogic(new FileLogger());
bussinessLogic1.Calculate();
Console.WriteLine("Console Logger Calling - ctor Example");
BussinessLogic bussinessLogic2 = new BussinessLogic(new ConsoleLogger());
bussinessLogic2.Calculate();
