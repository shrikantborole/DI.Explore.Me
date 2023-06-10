// See https://aka.ms/new-console-template for more information
using DI.Basic.Explore.Me;
using DI.Basic.Explore.Me.Implementation;

Console.WriteLine("Hello, World!");

//Ctor Injection
Console.WriteLine("File Logger Calling - Ctor Injection Example");
BussinessLogicInjection bussinessLogic1 = new BussinessLogicInjection(new FileLogger());
bussinessLogic1.Calculate();

Console.WriteLine("Console Logger Calling - Ctor Injection Example");
BussinessLogicInjection bussinessLogic2 = new BussinessLogicInjection(new ConsoleLogger());
bussinessLogic2.Calculate();


//Property Injection
Console.WriteLine("File Logger Calling - Property Example");
BussinessLogicPropertyInjection bussinessLogicPropertyInjection = new BussinessLogicPropertyInjection();
bussinessLogicPropertyInjection.LoggerInstance = new ConsoleLogger();
bussinessLogicPropertyInjection.Calculate();

Console.WriteLine("File Logger Calling - Property Example");
BussinessLogicPropertyInjection bussinessLogicPropertyInjection2 = new BussinessLogicPropertyInjection();
bussinessLogicPropertyInjection2.LoggerInstance = new FileLogger();
bussinessLogicPropertyInjection2.Calculate();


//Method Injection
Console.WriteLine("File Logger Calling - Method Example");
BussinessLogicMethodInjection bussinessLogicMethodInjection = new BussinessLogicMethodInjection();
bussinessLogicMethodInjection.Calculate(new ConsoleLogger());

Console.WriteLine("File Logger Calling - Method Example");
BussinessLogicMethodInjection bussinessLogicMethodInjection2 = new BussinessLogicMethodInjection();
bussinessLogicMethodInjection2.Calculate(new FileLogger());