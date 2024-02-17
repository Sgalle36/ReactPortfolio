using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Server.Data.Models
{
    public class Project : BaseModel
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
