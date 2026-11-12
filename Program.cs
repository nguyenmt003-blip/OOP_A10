/* 
 Mã sinh viên: 202419010
 Họ tên: Nguyễn Minh Tuấn
*/

// t1: tạo thiết bị qua factory và kiểm tra kiểu đối tượng
IDevice light = DeviceFactory.Create("light", "Living room light");
IDevice fan = DeviceFactory.Create("fan", "Living room fan");
IDevice door = DeviceFactory.Create("door", "Main door");

Console.WriteLine("--- T1: Kiểm tra Factory ---");
Console.WriteLine($"Light tạo thành công: {light.GetType().Name}");
Console.WriteLine($"Fan tạo thành công: {fan.GetType().Name}");
Console.WriteLine($"Door tạo thành công: {door.GetType().Name}");

// t2: kiểm tra tạo loại thiết bị chưa hỗ trợ
Console.WriteLine("\n--- T2: Kiểm tra ngoại lệ Factory ---");
try
{
    DeviceFactory.Create("camera", "Front camera");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Bắt ngoại lệ thành công: {ex.Message}");
}

// t3: kiểm tra singleton chỉ có một thể hiện duy nhất
Console.WriteLine("\n--- T3: Kiểm tra Singleton ---");
HomeConfiguration config1 = HomeConfiguration.Instance;
HomeConfiguration config2 = HomeConfiguration.Instance;
Console.WriteLine($"Hai biến cùng tham chiếu một đối tượng: {ReferenceEquals(config1, config2)}");

// t4: kiểm tra facade kích hoạt chế độ đi làm
// ép kiểu door sang ilockable để truyền vào facade
var facade = new SmartHomeFacade(light, fan, (ILockable)door);

Console.WriteLine("\n--- T4: GoToWork ---");
facade.GoToWork();

// t5: kiểm tra facade kích hoạt chế độ đi ngủ
Console.WriteLine("\n--- T5: GoToSleep ---");
facade.GoToSleep();
