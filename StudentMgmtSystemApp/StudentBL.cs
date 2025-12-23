using System;
namespace StudentMngmtSystem
{
    public class StudentBL
    {
        Student sObj;
        public StudentBL()
        {
            sObj = new Student();
        }
        public void AcceptStudentDetails()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("Student Management System");
            System.Console.WriteLine("========================");

            try
            {
                System.Console.WriteLine("Enter Roll No:");
                sObj.RollNo = Int32.Parse(Console.ReadLine() ?? "0");

                System.Console.WriteLine("Enter Your Name:");
                sObj.Name = Console.ReadLine();

                System.Console.WriteLine("Enter Your Address:");
                sObj.Address = Console.ReadLine();

                System.Console.WriteLine("Enter Your Physics Marks:");
                sObj.Phy = Int32.Parse(Console.ReadLine() ?? "0");

                System.Console.WriteLine("Enter Your Chemistry Marks:");
                sObj.Chem = Int32.Parse(Console.ReadLine() ?? "0");

                System.Console.WriteLine("Enter Your Maths Marks:");
                sObj.Math = Int32.Parse(Console.ReadLine() ?? "0");

                // compute derived values
                sObj.Calculate();
            }
            catch(InvalidMarkException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public int CalcTotal()
        {
            return sObj.Total;
        }

        public float CalcAvg()
        {
            return sObj.Perc;
        }
    }
}
