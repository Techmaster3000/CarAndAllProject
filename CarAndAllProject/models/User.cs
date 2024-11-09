
using System.ComponentModel.DataAnnotations;
namespace CarAndAllProject.models;

public class User
{
    public int Id { get; set; }
    [MaxLength(20)]
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Email { get; set; }
    public string Phone { get; set; }

}