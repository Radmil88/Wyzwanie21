using Wyzwanie21;

Employee employee1 = new Employee("Jan", "Nowak", 25);
Employee employee2 = new Employee("Krzysztof", "Kowalski", 30);
Employee employee3 = new Employee("Mateusz", "Baran", 35);


employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(5);

employee2.AddScore(5);
employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(8);
employee2.AddScore(9);

employee3.AddScore(2);
employee3.AddScore(4);
employee3.AddScore(9);
employee3.AddScore(9);
employee3.AddScore(1);

List<Employee> employess = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employess)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
};
Console.WriteLine("Dane pracownika z najwyższą liczbą punktów: ");
Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname);
Console.WriteLine("Wiek " + employeeWithMaxResult.Age);
Console.WriteLine(employeeWithMaxResult.Result);