// See https://aka.ms/new-console-template for more information
Console.WriteLine("Teto weather report");
int temp = 60;
string wheatherStat = "rainy";
float friction = 1f;
if (temp==10)
{
    friction= 1.8f;
    Console.WriteLine("today is a sunny day and the road friction is: " + friction);
}

else if (temp<50)
{
    friction= 0.1f;
    Console.WriteLine("today is rainy day and the road friction is: " + friction);
}
else
{
    Console.WriteLine("weather is cold");
}

// I hate you VScode <3