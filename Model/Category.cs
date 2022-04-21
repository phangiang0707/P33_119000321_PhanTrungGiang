using System.ComponentModel.DataAnnotations;
namespace P33_119000321_PhanTrungGiang.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Required]
        public string Name { get; set; }=string.Empty;
    }
}