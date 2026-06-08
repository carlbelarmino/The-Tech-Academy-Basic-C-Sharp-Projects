using System;

namespace MethodClassAssignment
{
    //requirement 1: create a class.
    public class MathOperation
    {
        //requirement 1: create a void method that takes two integers as parameters.
        public void ExecuteOperation(int firstNum, int secondNum)
        {
            int result = firstNum * 5;

            Console.WriteLine($"The second integer value is: {secondNum}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOp = new MathOperation();
            Console.WriteLine("Calling method passing numbers positionally:");
            mathOp.ExecuteOperation(10, 25);

            Console.WriteLine("Calling method specifying parameters by name:");
            mathOp.ExecuteOperation(firstNum: 50, secondNum: 100);

            Console.Readline();
        }
    }
}

