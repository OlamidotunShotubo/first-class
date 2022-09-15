

//variable initialization
var num = 0;

//variable declaration, compiler auto initializes to zero
int num2 = 0;

//simple statement
num = num2 + 10;

//data types
//value types: values are stored directly in the memory location on the stack
//numeric
//integer types
byte b = 0;
short s = 0;
int i = 0;
long l = 0;

//floating point types
float f = 2.0f;
double d = 2.0;
decimal de = 2.0m;

//single alphanumeric and symbols character
char alpha = 'a';

//series of alphanumeric and symbols characters
string name = "Dotun";

//true or false values
bool lightOn = true;

//operators
//binary, unary and tenary
//arithmetic operators
// + - / * % ()
int integer = 5 / 2;
int modulo = 5 % 2;
double floating = 5d / 2;
Console.WriteLine($"Integer division: {integer}");
Console.WriteLine($"Modulo division: {modulo}");
Console.WriteLine($"Floating point division: {floating}");

//increament and decreament
Console.WriteLine($"Post Increament: {(integer++) + 1}");
Console.WriteLine($"Pre Increament: {(++integer) + 1}");
Console.WriteLine($"Post Increament: {(integer--) + 1}");
Console.WriteLine($"Pre Increament: {(--integer) + 1}");

//equality operators
//== != > >= < <= 
Console.WriteLine($"Equals: {integer == modulo}");
Console.WriteLine($"Not Equals: {integer != modulo}");
Console.WriteLine($"Greater Than: {integer > modulo}");
Console.WriteLine($"Greater Than Equals: {integer >= modulo}");
Console.WriteLine($"Less Than: {integer < modulo}");
Console.WriteLine($"Less Than Equals: {integer <= modulo}");


//logical operators
// && || !
Console.WriteLine($"Logical And: {integer == modulo && lightOn}");
Console.WriteLine($"Logical Or: {integer == modulo || lightOn}");
Console.WriteLine($"Not: {!(integer == modulo)}");
Console.Read();


