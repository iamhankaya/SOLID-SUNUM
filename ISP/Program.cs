/*
 public interface IWorker
{
    void Work();
    void Eat();
}

public class Worker : IWorker
{
    public void Work()
    {
        // Çalışma davranışı
    }

    public void Eat()
    {
        // Yeme davranışı
    }
}

public class Robot : IWorker
{
    public void Work()
    {
        // Çalışma davranışı
    }

    public void Eat()
    {
        throw new NotImplementedException();
    }
}
ISP'YE UYGUN DEGIL
 */

public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public class Worker : IWorkable, IEatable
{
    public void Work()
    {
        // Çalışma davranışı
    }

    public void Eat()
    {
        // Yeme davranışı
    }
}

public class Robot : IWorkable
{
    public void Work()
    {
        // Çalışma davranışı
    }
}
