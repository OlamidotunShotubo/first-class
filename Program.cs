

// //variable initialization
// var num = 0;

// //variable declaration, compiler auto initializes to zero
// int num2 = 0;

// //simple statement
// num = num2 + 10;

// //data types
// //value types: values are stored directly in the memory location on the stack
// //numeric
// //integer types
// byte b = 0;
// short s = 0;
// int i = 0;
// long l = 0;

// //floating point types
// float f = 2.0f;
// double d = 2.0;
// decimal de = 2.0m;

// //single alphanumeric and symbols character
// char alpha = 'a';

// //series of alphanumeric and symbols characters
// string name = "Dotun";

// //true or false values
// bool lightOn = true;

// //operators
// //binary, unary and tenary
// //arithmetic operators
// // + - / * % ()
// int integer = 5 / 2;
// int modulo = 5 % 2;
// double floating = 5d / 2;
// Console.WriteLine($"Integer division: {integer}");
// Console.WriteLine($"Modulo division: {modulo}");
// Console.WriteLine($"Floating point division: {floating}");

// //increament and decreament
// Console.WriteLine($"Post Increament: {(integer++) + 1}");
// Console.WriteLine($"Pre Increament: {(++integer) + 1}");
// Console.WriteLine($"Post Increament: {(integer--) + 1}");
// Console.WriteLine($"Pre Increament: {(--integer) + 1}");

// //equality operators
// //== != > >= < <= 
// Console.WriteLine($"Equals: {integer == modulo}");
// Console.WriteLine($"Not Equals: {integer != modulo}");
// Console.WriteLine($"Greater Than: {integer > modulo}");
// Console.WriteLine($"Greater Than Equals: {integer >= modulo}");
// Console.WriteLine($"Less Than: {integer < modulo}");
// Console.WriteLine($"Less Than Equals: {integer <= modulo}");


// //logical operators
// // && || !
// Console.WriteLine($"Logical And: {integer == modulo && lightOn}");
// Console.WriteLine($"Logical Or: {integer == modulo || lightOn}");
// Console.WriteLine($"Not: {!(integer == modulo)}");

// //Unary Operators
// // ! - +

// //Assignment operators
// // = += -= *= /= %=
// num += 2; // num=num+2
// num *= 2;

// //Operator precedence
// //&& || !
// //< >...
// // * / %
// //+ -
// //d = num + num2 * s / l;

// //Ternary if..else
// // condition? true statement : false statement
// Console.WriteLine(num > num2 ? "Num is greater" : "Num2 is greater");

// //Selection statement
// // if else
// if (num > num2)
// {
//     Console.WriteLine("Num is greater");
// }
// else if (num == num2)
// {
//     Console.WriteLine("Num and Num2 are equal");
// }
// else
// {
//     Console.WriteLine("Num2 is greater");
// }

// //enum
// var date = DateTime.Now;
// if (date.DayOfWeek == DayOfWeek.Thursday)
// {
//     Console.WriteLine("Today is Thursday");
// }

// Console.WriteLine("Choose a shape");
// Shapes shapeOption;
// try
// {
//     shapeOption = (Shapes)int.Parse(Console.ReadLine()); //type casting 
//     switch (shapeOption)
//     {
//         case Shapes.Circle:
//             Console.WriteLine("It's a circle");
//             break;
//         case Shapes.Rectangle:
//             Console.WriteLine("It's a rectangle");
//             break;
//         default:
//             Console.WriteLine("Option not available");
//             break;
//     }
// }
// catch (System.Exception)
// {
//     Console.WriteLine("Supply a valid option");
// }


// Console.WriteLine("Choose another shape");
// shapeOption = Enum.Parse<Shapes>(Console.ReadLine()); //type casting 
// switch (shapeOption)
// {
//     case Shapes.Circle:
//         Console.WriteLine("It's a circle");
//         break;
//     case Shapes.Rectangle:
//         Console.WriteLine("It's a rectangle");
//         break;
//     default:
//         Console.WriteLine("Option not available");
//         break;
// }

// Console.WriteLine("Pick from the list of shapes below");
// Console.WriteLine(Shapes.Circle);
// Console.WriteLine(Shapes.Rectangle);
// Console.WriteLine(Shapes.Square);
// Console.WriteLine(Shapes.Triangle);
// shapeOption = Enum.Parse<Shapes>(Console.ReadLine()); //type casting 
// switch (shapeOption)
// {
//     case Shapes.Circle:
//         Console.WriteLine("It's a circle");
//         break;
//     case Shapes.Rectangle:
//         Console.WriteLine("It's a rectangle");
//         break;
//     default:
//         Console.WriteLine("Option not available");
//         break;
// }


// Console.WriteLine("Pick from the list of shapes below");
// foreach (var item in Enum.GetNames<Shapes>())
// {
//     Console.WriteLine(item);
// }

// shapeOption = Enum.Parse<Shapes>(Console.ReadLine()); //type casting 
// switch (shapeOption)
// {
//     case Shapes.Circle:
//         Console.WriteLine("It's a circle");
//         break;
//     case Shapes.Rectangle:
//         Console.WriteLine("It's a rectangle");
//         break;
//     default:
//         Console.WriteLine("Option not available");
//         break;
// }

// //array: set of values of the same type
// //0 based index
// Console.WriteLine("One dimensional Array");
// string[] names = { "One", "Two", "Three" };
// names = new string[10];
// names = new string[] { "One", "Two", "Three" };
// for (int indx = 0; indx < names.Length; indx++)
// {
//     Console.WriteLine(names[indx]);
// }
// Console.WriteLine("Multi-dimensional Array");
// string[,] students = { { "One", "Two", "Three" }, { "Four", "Five", "Six" } };
// for (int r = 0; r < students.GetLength(0); r++)
// {
//     for (int c = 0; c < students.GetLength(1); c++)
//     {
//         Console.WriteLine(students[r, c]);
//     }
// }   
var shape=new Shape();
shape.Name="Rectangular";
Console.WriteLine(shape.Scramble(true));

Console.Read();