
//-------------------------------------------------------------------------
//This is a comment line

/*----------------------------
Comment block!
What ever we write is a
COMMENT!!!!
 --------------------------*/

//-----------              Variable types  &         ----------------------
//-----------    Arithmetic operations on values and variables   ----------
/// <see cref="https://www.tutorialsteacher.com/csharp/csharp-data-types"/>
/// Full table of primitive types
/// </summary>
long l1 = 3874618764876238746; // 8 bytes
int i1 = -529; // 4 bytes
uint i2 = 29; // 4 bytes  - un-signed (אין התייחסות לסימן)
short s1 = -127; // 2 bytes
s1 = +112; // same as: s1 = 112
ushort us1 = 29; // 2 bytes
byte b1 = 129;  // 1 byte

//מספרים עשרוניים
double d1 = 5.1237;
Console.WriteLine(d1);
Console.WriteLine(58.618);

//true or false
bool bool1 = true;
bool1 = false;


//--------------------------------------------------------------------------------
//==========  Chaining output before we know we can use the + operatot on strings
//--------------------------------------------------------------------------------
Console.WriteLine("Please enter first name");
string firstName = Console.ReadLine();

string lastName = "Yeruslav";
Console.Write(firstName);
Console.Write(" ");
Console.WriteLine(lastName);

int age1 = 29;
Console.Write(" and your age is ");
Console.WriteLine(age1);


//-------------         Changing variable value ----------------
int x = 0, y; // defult value of int is 0
y = -65012;
y = 12;
y = 87 - 7; // 80
Console.WriteLine(y); // 80
Console.WriteLine(y * 2); //160
Console.WriteLine(y);// 80 (We did no change the value of y)
int z = y * (x + 3); // z = 80 * (0+3) = 80 * 3 = 240
Console.WriteLine(z); // 240
y = y * x; // y = 80 * 0 = 0
Console.WriteLine(y); // 0

int numberOfExams = 2; //Console.ReadLine();
int grade = (95 + 100) / numberOfExams;  // = 195 / 2 = 97.5 ==> 97
/*In the above line, because we have int (literals) involvd in the calculation,
    we have implicit (automatic) conversion to int, although the value is a a decimal
       final result is 97 */


//------------     Conversions of all types to string ----------------
int age = 29;
string ageString = age.ToString();
ageString = (99 + 5).ToString();

double ageDouble = 6.5;
ageString = ageDouble.ToString();

bool myBool = false;
string myBoolValueString = myBool.ToString();

//=================================================================
Console.WriteLine("Enter any key to exit!");
Console.ReadKey();
