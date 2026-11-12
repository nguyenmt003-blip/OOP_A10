/* 
 Mã sinh viên: 202419010
 Họ tên: Nguyễn Minh Tuấn
*/

public sealed class SmartHomeFacade
{
    private readonly IDevice light;
    private readonly IDevice fan;
    private readonly ILockable door;

    public SmartHomeFacade(IDevice light, IDevice fan, ILockable door)
    {
        this.light = light;
        this.fan = fan;
        this.door = door;
    }

    public void GoToWork()
    {
        // gọi đến từng cái khi đi lm
        light.TurnOff();
        fan.TurnOff();
        door.Lock();
    }

    public void GoToSleep()
    {
        // gọi đến từng cái khi ngủ
        fan.TurnOff();
        door.Lock();
        light.TurnOn();

        // lấy cấu hình mức sáng ban đêm từ singleton
        int level = HomeConfiguration.Instance.NightLightLevel;
        Console.WriteLine($"Night light level: {level}%");
    }
}
