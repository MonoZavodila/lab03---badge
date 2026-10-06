
Random rng = new Random();
rng.Next(100000, 999999);

Console.Write("Type your full name here. ");

string fullName = Console.ReadLine();
fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

Console.WriteLine($"Name on badge: {fullName}");
Console.WriteLine($"Username: {firstName[0] + lastName}");
Console.WriteLine($"Initials: {firstName[0]}.{lastName[0]}.");
Console.WriteLine($"Letters in last name: {lastName + 0}");
//Console.WriteLine($"Initials: {firstName[0] + lastName[0]}");

Console.Write(Convert.ToInt32($"Student ID: {rng}"));


// string studentName = Console.ReadLine();

// Console.WriteLine($"Name on badge: {studentName}");
// Console.WriteLine($"Name on badge: {studentName}");
//Console.WriteLine($"Hello, {studentName}");