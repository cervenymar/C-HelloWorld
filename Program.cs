﻿using System;
using System.Diagnostics;
using System.Reflection;

namespace HelloWorld{
    class Program{
        static void Main (string[]args){  
          //This repository follows the https://www.w3resource.com/csharp-exercises/basic/index.php exercises              
          TenthExercise();        
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
        static void SeventhExercise(){
            int num1, num2;
            Console.Write("Input first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1+" + "+num2+" = "+num1 + num2);
            Console.WriteLine(num1+" - "+num2+" = "+(num1 - num2));
            Console.WriteLine(num1+" x "+num2+" = "+num1 * num2);
            Console.WriteLine(num1+" / "+num2+" = "+num1 / num2);
            Console.WriteLine(num1+" mod "+num2+" = "+num1 % num2);
        }
        static void EighthExercise(){
            int num1;
            Console.Write("Input first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=10;i++){
                Console.WriteLine(num1+" x "+i+" = "+num1*i);
            }            
        }
        static void NinthExercise(){
            int num1, num2, num3, num4;
            Console.Write("Input first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Fourth number: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            int output = (num1+num2+num3+num4)/4;
            Console.WriteLine("The average is "+output);
        }   
        static void TenthExercise(){
            int x, y, z;
            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third number: ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n", x, y, z, ((x+y)*z), (x*y+y*z));
        }  
    }
}