// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using StudentMngmtSystem;
StudentBL sBLobj = new StudentBL();
sBLobj.AcceptStudentDetails();
sBLobj.CalcTotal();
sBLobj.CalcAvg();

System.Console.WriteLine($"Total{sBLobj.CalcTotal()}");
System.Console.WriteLine($"Percentage{sBLobj.CalcAvg()}");

