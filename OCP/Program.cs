public abstract class Employee
{
    public abstract decimal CalculateSalary();
}

public class Developer : Employee
{
    public override decimal CalculateSalary()
    {
        return 1000;
    }
}

public class Manager : Employee
{
    public override decimal CalculateSalary()
    {
        return 2000;
    }
}

//YENI CALISAN TURU EKLERKEN:
public class Intern : Employee
{
    public override decimal CalculateSalary()
    {
        return 500;
    }
}
