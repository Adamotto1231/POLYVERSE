// See https://aka.ms/new-console-template for more information
string command = " system is hacked ";
command = command.Trim();
command = command.Replace("system is hacked","system is secure");
Console.WriteLine(command);
bool issystemsecure = command.Contains("system is secure");
Console.WriteLine(issystemsecure);
int dead = 2140000000;
int alive = 214000000;
double a = 12.5;
float b = 5.02f;
Console.WriteLine(a / b);
int totaldead = checked(dead + alive);
Console.WriteLine(totaldead);
