/*
* Name: La'Shaye Etheridge
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: October 6, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

Random rng = new Random();
//rng.Next(100000, 999999);
int num = rng.Next(100000, 1000000);

Random locker = new Random();
int lockNum = rng.Next(1, 501);

Console.Write("Type your full name here. ");

string fullName = Console.ReadLine();
fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

Console.WriteLine("Dorm X?");
double dormX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dorm Y?");
double dormY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Classroom X?");
double classroomX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Classroom Y?");
double classroomY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is your walking speed in feet per second?");
double walkSpeed = Convert.ToDouble(Console.ReadLine());

double walkP1 = (classroomX - dormX);
Math.Pow(walkP1, 2);
double walkP2 = (classroomY - dormY);
Math.Pow(walkP2, 2);
double walkDistance = Math.Sqrt((walkP1 + walkP2));


Console.WriteLine($"Name on badge: {fullName}");
//Console.WriteLine($"Username: {firstName[0] + lastName}");
Console.WriteLine($"Username: {firstName.ToLower()[0] + lastName.ToLower()}");
Console.WriteLine($"Initials: {firstName.ToUpper()[0]}.{lastName.ToUpper()[0]}.");
Console.WriteLine($"Letters in last name: {lastName.Length}");
//Console.WriteLine($"Initials: {firstName[0] + lastName[0]}");

//Console.Write(Convert.ToInt32($"Student ID: {num}"));
Console.WriteLine($"Student ID: {num}");
Console.WriteLine($"Locker: {lockNum}");
Console.WriteLine($"Distance: {walkDistance} feet");
Console.WriteLine($"Walk Time: ");

Console.WriteLine($"==================================");
Console.WriteLine("\tETSU STUDENT BADGE");
Console.WriteLine($"==================================");
Console.WriteLine($"NAME\t {fullName.ToUpper()}");
Console.WriteLine($"USERNAME {firstName.ToLower()[0] + lastName.ToLower()}");
Console.WriteLine($"ID\t {num}");
Console.WriteLine($"LOCKER\t {lockNum}");