/*
 public class Bird
{
    public virtual void Fly()
    {
        // Uçuş davranışı
    }
}

public class Sparrow : Bird
{
    public override void Fly()
    {
        // Serçenin uçuş davranışı
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotSupportedException("Ostriches can't fly");
    }
}
    LSP'YE AYKIRI
 */

public abstract class Bird
{
    public abstract void Move();
}

public class FlyingBird : Bird
{
    public override void Move()
    {
        Fly();
    }

    public void Fly()
    {
        // Uçuş davranışı
    }
}

public class Sparrow : FlyingBird
{
    public override void Fly()
    {
        // Serçenin uçuş davranışı
    }
}

public class Ostrich : Bird
{
    public override void Move()
    {
        // Devekuşunun koşma davranışı
    }
}
