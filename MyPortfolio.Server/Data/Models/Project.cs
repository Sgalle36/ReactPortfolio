using MyPortfolio.Server.Utility;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortfolio.Server.Data.Models
{
    public class Project : BaseModel
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        // single category
        // multiple tags
    }
}
