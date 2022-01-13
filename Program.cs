// See https://aka.ms/new-console-template for more information
using OOPS.Polymorphism.Method_Overriding;
using OOPS.Inheritance;
using OOPS.Polymorphism.Method_OverLoading;
using OOPS.Encapsulation;
using OOPS.Abstraction;
using OOPS.PassByValue;
using OOPS.PassByValueAndRef;


Console.WriteLine("Hello, World!");


//creating car class object and then calling it
Car car1 = new Car();
car1.start();
car1.stop();
Console.WriteLine(car1.CarName = "BMW" );
Console.WriteLine(car1.CarNumber=1998);

//creating engin obj and then calling it
Engine engine1 = new Engine();
engine1.EngineRunning();

Collage clg1 = new Collage();
clg1.CollageName();
clg1.CollageLocation();
Students stdnt1 = new Students();
stdnt1.CollageLocation();
stdnt1.Details();


Calculation clc1 = new Calculation();
Console.WriteLine(clc1.add());
Console.WriteLine(clc1.add(5.2f, 6.33333));


Acount acnt1 = new Acount();
acnt1.AddAmount(5.2);

Circle clr = new Circle();
clr.DrawShape();

int i = 10;
PassByValue p1 = new PassByValue();
Console.WriteLine(i);
p1.PassValue(i);
Console.WriteLine("after passing value is" + i);


int x = 10;
PassByRef p2 = new PassByRef();
Console.WriteLine(x);
p2.PassRef(ref x);
Console.WriteLine("after passing value is" + x);
