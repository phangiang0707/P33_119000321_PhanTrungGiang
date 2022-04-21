using System.ComponentModel.DataAnnotations;
namespace P33_119000321_PhanTrungGiang.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Author { get; set; }=string.Empty;
        [Required]
        public string Content { get; set; }=string.Empty;
    }
}