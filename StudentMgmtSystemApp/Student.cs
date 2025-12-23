using System;

namespace StudentMngmtSystem
{
    public class Student
    {
        private int rollNo;
        private int phy;
        private int chem;
        private int math;
        private int total;
        private float perc;

        // Full Property
        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        // Auto Properties
        public string? Name { get; set; }
        public string? Address { get; set; }

        public int Phy
        {
            get { return phy; }
            set
            {
                if (value >= 0 && value <= 100)
                    phy = value;
                else
                    throw new InvalidMarkException("Invalid Marks");
            }
        }

        public int Chem
        {
            get { return chem; }
            set
            {
                if (value >= 0 && value <= 100)
                    chem = value;
                else
                    throw new InvalidMarkException("Invalid Marks");
            }
        }

        public int Math
        {
            get { return math; }
            set
            {
                if (value >= 0 && value <= 100)
                    math = value;
                else
                    throw new InvalidMarkException("Invalid Marks");
            }
        }

        public int Total
        {
            get { return total; }
        }

        public float Perc
        {
            get { return perc; }
        }

        
        public void Calculate()
        {
            total = phy + chem + math;
            perc = total / 3.0f;
        }
    }

    
    public class InvalidMarkException : ApplicationException
    {
        public InvalidMarkException(string msg) : base(msg)
        {
        }
    }
}
