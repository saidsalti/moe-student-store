namespace Store1.Data.Services
{
    public interface IAppTempData
    {
        object? data { get;set; }
       
    }
    public class AppTempData : IAppTempData
    {
        public object? data { get; set; }

       
    }
}
