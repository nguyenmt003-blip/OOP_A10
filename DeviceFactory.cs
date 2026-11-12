/* 
 Mã sinh viên: 202419010
 Họ tên: Nguyễn Minh Tuấn
*/

public static class DeviceFactory
{
    public static IDevice Create(string type, string name)
    {
        // chuyển hướng tạo thiết bị dựa trên loại thiết bị
        return type.Trim().ToLowerInvariant() switch
        {
            "light" => new SmartLight(name),
            "fan" => new SmartFan(name),
            "door" => new SmartDoor(name),
            _ => throw new ArgumentException($"Unsupported device type: {type}")
        };
    }
}
