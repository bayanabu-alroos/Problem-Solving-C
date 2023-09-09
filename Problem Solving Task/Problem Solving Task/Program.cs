///*
// **1-	Write a C# Sharp program to read 10 numbers and find their average and sum.
// *
// */

//using System;
//using System.Reflection;
//using System.Runtime.ConstrainedExecution;
//using System.Runtime.Intrinsics.X86;

//int[] arr = new int[10];
//float sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine("Please enter number :");
//    int.TryParse(Console.ReadLine(), out arr[i]);
//    sum += arr[i];
//}
//float avg = sum / 10;
//Console.Write("This sum number = ");
//Console.WriteLine(sum);
//Console.Write("This avarage number = ");
//Console.Write(avg);

///*
// * 2-	Write a C# Sharp program to display the cube of an integer up to given number.
// */

//int num2;
//Console.WriteLine("please enter number counter :");
//int.TryParse(Console.ReadLine(), out num2);
//int[] array = new int[num2];
//for (int i = 0; i < array.Length; i++)
//{
//    int number = array[i] ^ 2;
//    Console.WriteLine(number);
//}

//int num9;
//Console.Write("Input number of terms : ");
//int.TryParse(Console.ReadLine(), out num9);
//for (int i = 1; i <= num9; i++)
//{
//    Console.Write("Number is : {0}  and cube of the {1} is :{2} \n", i, i, (i * i * i));
//}

///*
// * *3-	Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
//The pattern like :
//1
//12
//123
//1234
// */


//int row;
//int.TryParse(Console.ReadLine(), out row);
//for (int i = 1; i <= row; i++)
//{
//    for (int j = 1; j <= i; j++)
//        Console.Write("{0}", j);
//    Console.Write("\n");
//}

///*
// * *
//4-	Write a program in C# Sharp to find the sum of the series
// [ 1-X^2/2!+X^4/4!- .........]

// */

//int x, n, sum1 = 1;
//Console.WriteLine("please enter number of x");
//int.TryParse(Console.ReadLine(), out x);
//Console.WriteLine("please enter  counter number");
//int.TryParse(Console.ReadLine(), out n);
//for (int i = 1; i < n; i++)
//{
//    int number = (2 * i) * (2 * i - 1);
//    int nubers = -1 * x * x / number;
//    sum1 += nubers;
//}
//Console.Write("\nthe sum = {0}\nNumber of terms = {1}\nvalue of x = {2}\n", sum, n, x);


///*
// *5-	Write a C# Sharp program to find the largest of three numbers
// */

//int[] num3 = new int[3];
//for (int i = 0; i < num3.Length; i++)
//{
//    Console.WriteLine("please enter number  {0}", i);
//    int.TryParse(Console.ReadLine(), out num3[i]);

//}
//Console.WriteLine("The Maximum number = ", num3.Max());

///*
// * *6-	Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
// */

//int[] side = new int[3];
//for (int i = 0; i < side.Length; i++)
//{
//    Console.WriteLine("please enter side of triangle");
//    int.TryParse(Console.ReadLine(), out side[i]);
//}
//if (side[0] == side[1] && side[1] == side[2])
//{
//    Console.Write("This is an Equilateral triangle.");
//}
//else if (side[0] == side[1] || side[0] == side[2] || side[2] == side[1])
//{
//    Console.Write("This is an Isosceles triangle.");
//}
//else
//{
//    Console.WriteLine("This is an Scalene triangle.");
//}


///**
// *7-	Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
// */

//int day;
//Console.WriteLine("please enter number day ");
//int.TryParse(Console.ReadLine(), out day);
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Sunday");
//        break;
//    case 2:
//        Console.WriteLine("Monday");
//        break;
//    case 3:
//        Console.WriteLine("Tuesday");
//        break;
//    case 4:
//        Console.WriteLine("Wednesday");
//        break;
//    case 5:
//        Console.WriteLine("Thursday ");
//        break;
//    case 6:
//        Console.WriteLine("Friday ");
//        break;
//    case 7:
//        Console.WriteLine("Saturday ");
//        break;
//    default:
//        Console.WriteLine("Invalid day number. \nPlease try again ....\n");
//        break;
//}


//int month;
//Console.WriteLine("please enter number month ");
//int.TryParse(Console.ReadLine(), out month);
//switch (month)
//{
//    case 1:
//    case 3:
//    case 5:
//    case 7:
//    case 8:
//    case 10:
//    case 12:
//        Console.WriteLine("Month  have 31 days.");
//        break;
//    case 2:
//        Console.WriteLine("The 2nd month is a February and have 28 days.");
//        Console.WriteLine("in leap year The February month  Have 29 days.");
//        break;
//    case 4:
//    case 6:
//    case 9:
//    case 11:
//        Console.WriteLine("Month  have 31 days.");
//        break;
//}



//int[] mark = new int[10];
//float sum6 = 0;
//for (int i = 0; i < mark.Length; i++)
//{
//    Console.WriteLine("Please enter your mark {0}", i + 1);
//    if (int.TryParse(Console.ReadLine(), out mark[i]))
//    {
//        sum6 += mark[i];
//        continue;
//    }
//    else
//    {
//        i--;
//        continue;
//    }
//}
//float avg3 = sum6 / mark.Length;

//Console.Write("This sum number = ");
//Console.WriteLine(sum6);
//Console.Write("This avarage number = ");
//Console.Write(avg3);



//float[,] student = new float [5, 5];

//float sum  = 0 ,avg = 0;
//for (int i = 0;i <student.Length; i++)
//{
//    for (int j = 0;j < student.Length; j++)
//    {
//        if (float.TryParse(Console.ReadLine(),out student[i,j]))
//        {
//            sum += student[i,j];
//            continue;
//        }
//        else
//        {
//            i--;
//            continue;
//        }
//    }
//}
//Console.Write("This sum number =  {0}" , sum);
//Console.Write("This avarage number = {0}", avg);

//int[,] arr = new int[3, 3]{ {1, 2,3}, { 4,5,6},  {7, 8,9} };
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for(int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write(arr[i,j] + "\n");
//    }
//}



