using System.ComponentModel.DataAnnotations;

namespace DataContext.Entities;

public class BaseEntity
{
    [Required]
    public DateTime CreatedDate { get; set; }
}