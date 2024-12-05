using MudBlazor;

namespace Store1.Data.Models
{
    public class MessageModel
    {
        public string? Message { get; set; }
        public Severity Severity { get; set; } = Severity.Info;
    }
}
