/* 
 Mã sinh viên: 202419010
 Họ tên: Nguyễn Minh Tuấn
*/

public sealed class HomeConfiguration
{
    // khởi tạo lưới đa luồng bằng lazy
    private static readonly Lazy<HomeConfiguration> lazy =
        new(() => new HomeConfiguration());

    // điểm truy cập duy nhất lấy thể hiện singleton
    public static HomeConfiguration Instance => lazy.Value;
    public string HomeName { get; set; } = "My Home";
    public int NightLightLevel { get; set; } = 30;
    private HomeConfiguration()
    {
    }
}
