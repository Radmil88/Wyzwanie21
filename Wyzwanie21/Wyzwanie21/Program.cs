string name = "Ewa";
bool female = false;
var age =17;

if (female)
{
    if (age < 30)
        Console.WriteLine("Kobieta poniżej 30 lat");
    else if (age == 33 && name == "Ewa")
        Console.WriteLine("Ewa, lat 33");
    else
        Console.WriteLine("Inna kobieta");
}

else
{
    if (!female && age < 18)
        Console.WriteLine("Niepełnoletni mężczyzna");
    else
        Console.WriteLine("Inny mężczyzna)");
}