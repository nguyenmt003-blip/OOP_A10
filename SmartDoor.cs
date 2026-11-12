/* 
 Mã sinh viên: 202419010
 Họ tên: Nguyễn Minh Tuấn
*/

// cua implement ca idevice va ilockable vi vua bat/tat duoc vua co chot khoa
public class SmartDoor : IDevice, ILockable
{
    public string Name { get; }
    public bool IsOn { get; private set; }
    public bool IsLocked { get; private set; }

    public SmartDoor(string name)
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

    // hanh vi rieng cua ilockable
    public void Lock()
    {
        IsLocked = true;
        Console.WriteLine($"{Name}: LOCKED");
    }

    public void Unlock()
    {
        IsLocked = false;
        Console.WriteLine($"{Name}: UNLOCKED");
    }
}
