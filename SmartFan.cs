/* 
 Mã sinh viên: 202419010
 Họ tên: Nguyễn Minh Tuấn
*/

public class SmartFan : IDevice
{
    public string Name { get; }
    public bool IsOn { get; private set; }

    public SmartFan(string name)
    {
        Name = name;
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Name}: ON");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Name}: OFF");
    }
}
