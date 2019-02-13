using HW1002_MyCanvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1. Button 1 created: {MyCanvas.CreateNewButton(3, 3, 6, 6)}");
            Console.WriteLine($"2. Button 2 created: {MyCanvas.CreateNewButton(8, 8, 15, 15)}");
            Console.WriteLine($"3. Button 3 created: {MyCanvas.CreateNewButton(30, 30, 60, 60)}");            
            Console.ReadKey();

            MyCanvas.MoveButton(2, 6, 6);
            Console.WriteLine($"Current Number Of existing Buttons: {MyCanvas.GetCurrentNumberOfButtons()}");
            bool deleteLast = MyCanvas.DeleteLastButton();
            Console.WriteLine($"Last delete Succeed {deleteLast}");
            Console.WriteLine($"Current Number Of existing Buttons: {MyCanvas.GetCurrentNumberOfButtons()}");            
            Console.WriteLine($"MaxNumberOfButtons: {MyCanvas.GetMaxNumberOfButtons()}");            
            Console.WriteLine($"MaxWidthOfAButton: {MyCanvas.GetTheMaxWidthOfAButton()}");            
            Console.WriteLine($"MaxHeightOfAButton: {MyCanvas.GetTheMaxHeightOfAButton()}");            
            Console.WriteLine($"Checking if the Point x= 10, y = 15 inside a button: {MyCanvas.IsPointInsideAButton(10, 15)}");            
            Console.WriteLine($"AnyButtonIsOverlapping: { MyCanvas.CheckIfAnyButtonIsOverlapping()}");            
            Console.ReadKey();
        }
    }
}
