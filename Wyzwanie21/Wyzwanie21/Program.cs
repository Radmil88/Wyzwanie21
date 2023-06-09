using System.Runtime.CompilerServices;

string name = "Ewa";
bool female = true;
var age = 33;

if (female == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (female == true && age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
if(!(female == true) && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
