using System;


namespace MyCalculatorConsoleApp
{
    class Program
    { 
        static void Main(string[] args)
        {
int = numbervalue1, numbervalue2;
int = action

 Console.WriteLine("What Mathematical operation would you love to perform");  
             Console.WriteLine("Press 1 if you want Addition");  
             Console.WriteLine("Press 2 for Subtraction");  
             Console.WriteLine("Press 3 for Multiplication");  
             Console.WriteLine("Press 4 for Division");  
              Console.WriteLine("Press 5 to square. but ensure to type in your first value as your second value to get the right result");  



// This enables you enter the mathematical operation and prompts you to enter your numbervalue1
int action = Convert.ToInt32(Console.ReadLine());  
          Console.WriteLine("Enter numbervalue1");
// The Readline code below enables you to enter numbervalue1 and the console message prompts you to enter numbervalue2
          int numbervalue1= Convert.ToInt32(Console.ReadLine());  
          Console.WriteLine("Enter numbervalue2");
          
 //This readline code enables you to enter second number         
          int numbervalue2= Convert.ToInt32(Console.ReadLine());  
          //Here, the result is set to zero
          int result = 0;


// switch enables you to execute different parts of a the mathematical operations
switch (action) 
{
case 1: {
result = Addition(numbervalue1 + numbervalue2);
break;
}

case 2: {
result = Subtraction(numbervalue1 - numbervalue2);
break;
}


case 3:{
result=Multiplication(numbervalue1 * numbervalue2);
break;
}

//case 4 ensures that no number is divided by zero
case 4:{
if(numbervalue2 == 0)
Console.WriteLine("Oops! Sorry but this operation cannot be performed because zero is an invalid divisor")
else 
result = Division (numbervalue1 / numbervalue2);

}


case 5:{
result = Square (numbervalue1^numbervalue2);
break;
}



default:
Console.WriteLine("Invalid Operation");
break;
}
Console.WriteLine("The result is {0}", result);
Console.ReadKey();

}

        //This will return Added numbers
public static int Addition(int numbervalue1, int numbervalue2) 
{  
                 int result = numbervalue1 + numbervalue2;  
           return result; 
    
        }
    
  //This will return subtracted numbers  
          public static int Subtraction(int numbervalue1, int numbervalue2) 
          {  
       int result = numbervalue1 - numbervalue2;  
             return result;  
         }     
 //  This will return Multiplied numbers   
 public static int Multiplication(int numbervalue1, int numbervalue2) 
          {  
       int result = numbervalue1 * numbervalue2;  
             return result;  
         } 

//This will return divided numbers
 public static int Division(int numbervalue1, int numbervalue2) 
          {  
       int result = numbervalue1 + numbervalue2;  
             return result;  
         } 


// This will multiply a number by itself
         public static int Square(int numbervalue1, int numbervalue2) 
          {  
       int result = numbervalue1 ^ numbervalue2;  
             return  result;  
         }       


    }
}

//My Visual studio code did not allow me create another class that is why I put everything in program.cs, I still dont understand why it keeps saying extensions initializing.
//Also I was getting this error>....   C:\Users\ofoezie ezichi fav\Desktop\week8\calculatorapp\MyCalculatorConsoleApp\Program.cs(11,13): error CS1002: Identifier expected [C:\Users\ofoezie ezichi fav\Desktop\week8\calculatorapp\MyCalculatorConsoleApp\MyCalculatorConsoleApp.csproj]
// i checked for my access specifiers and i thought they were all good. There is also no way I can cd into a csproj file. 
//Because of power and for me not to miss the deadline, i have submitted this. Hopefully, I will find out the problem and push to my repo before you access it. Thank you.


//If you can see these comments please I would love to know why I am getting those errors. 


