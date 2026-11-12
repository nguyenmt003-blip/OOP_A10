/* 
 Mã sinh viên: 202419010
 Họ tên: Nguyễn Minh Tuấn
*/

public sealed class HomeConfiguration
{
    // khoi tao luoi va an toan da luong bang lazy
    private static readonly Lazy<HomeConfiguration> lazy =
        new(() => new HomeConfiguration());

    // diem truy cap duy nhat lay the hien singleton
    public static HomeConfiguration Instance => lazy.Value;

    public string HomeName { get; set; } = "My Home";
    public int NightLightLevel { get; set; } = 30;

    // chan tao the hien tu ben ngoai
    private HomeConfiguration()
    {
    }
}
