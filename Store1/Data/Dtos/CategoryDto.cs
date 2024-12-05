using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System.ComponentModel.DataAnnotations;

namespace Store1.Data.Dtos
{
    public class CategoryDto
    {
        public int? Id { get; set; }
        [Label("Category name")]
        public string? NameAr { get; set; }
        public string? ImagePath { get; set; }
        public int? OrderIndex { get; set; }
        [Label("Is Active")]
       
        public bool? IsActive { get; set; }
        public IBrowserFile?   file { get; set; }

    }
}
