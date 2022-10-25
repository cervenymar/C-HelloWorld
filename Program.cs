using System;
using System.Diagnostics;
using System.Reflection;

namespace HelloWorld{
    class Program{
        static void Main (string[]args){  
          //This repository follows the https://www.w3resource.com/csharp-exercises/basic/index.php exercises              
          //FirstExercise();
          //SecondExercise();
          //ThirdExercise();
          //FourthExercise();
          //FifthExercise(5,6);
          SixthExercise();          
        }
        static void FirstExercise(){            
            var getName = System.Reflection.MethodBase.GetCurrentMethod()!.Name;
            Console.WriteLine(getName+":");
            string name = "Jacob";
            Console.WriteLine("Hello "+name+"!");    
        }
        static void SecondExercise(){
            var getName = System.Reflection.MethodBase.GetCurrentMethod()!.Name;
            Console.WriteLine(getName+":");
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine(num1+num2);    
        }  
        static void ThirdExercise(){
            var getName = System.Reflection.MethodBase.GetCurrentMethod()!.Name;
            Console.WriteLine(getName+":");
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine(num2/num1);
        }     
        static void FourthExercise(){
            var getName = System.Reflection.MethodBase.GetCurrentMethod()!.Name;
            Console.WriteLine(getName+":");
            Console.WriteLine(-1+4*6);
            Console.WriteLine((35+5)%7);
            Console.WriteLine(14+-4*6/11);
            Console.WriteLine(2+15/6*1-7/2);
        } 
        static void FifthExercise(int num1, int num2){
            var getName = System.Reflection.MethodBase.GetCurrentMethod()!.Name;
            Console.WriteLine(getName+":");  
            Console.WriteLine("First number pre = "+num1);
            Console.WriteLine("Second number pre= "+num2);          
            int temp = num1;
            num1=num2;
            num2=temp;
            Console.WriteLine("First number post = "+num1);
            Console.WriteLine("Second number post = "+num2);
        }
        static void SixthExercise(){
            int num1, num2, num3;
            Console.Write("Input first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            int output = num1*num2*num3;
            Console.WriteLine("Output: "+num1+" x "+num2+" x "+num3+ " = "+output);
        } 

       
    }
}