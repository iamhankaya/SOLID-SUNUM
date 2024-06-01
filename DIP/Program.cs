/*
  public class LightBulb
{
    public void TurnOn()
    {
        // Ampulü açma
    }

    public void TurnOff()
    {
        // Ampulü kapama
    }
}

public class Switch
{
    private LightBulb _lightBulb;

    public Switch(LightBulb lightBulb)
    {
        _lightBulb = lightBulb;
    }

    public void Operate(bool on)
    {
        if (on)
        {
            _lightBulb.TurnOn();
        }
        else
        {
            _lightBulb.TTurnOff();
        }
    }
}
    DIP'E UYGUN DEGIL
 */

public interface ISwitchable
{
    void TurnOn();
    void TurnOff();
}

public class LightBulb : ISwitchable
{
    public void TurnOn()
    {
        // Ampulü açma
    }

    public void TurnOff()
    {
        // Ampulü kapama
    }
}

public class Switch
{
    private ISwitchable _device;

    public Switch(ISwitchable device)
    {
        _device = device;
    }

    public void Operate(bool on)
    {
        if (on)
        {
            _device.TurnOn();
        }
        else
        {
            _device.TurnOff();
        }
    }
}

    //DIP'E UYGUN
