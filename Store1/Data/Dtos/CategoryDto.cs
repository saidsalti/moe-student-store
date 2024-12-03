using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace Store1.Data.Dtos
{
    public class CategoryDto
    {
        public int? Id { get; set; }
        public string? NameAr { get; set; }
        public string? ImagePath { get; set; }
        public int? OrderIndex { get; set; }
        [Label("فعّال")]
        public bool? IsActive { get; set; }
        public IBrowserFile?   file { get; set; }

    }
}
