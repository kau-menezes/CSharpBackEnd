using System.ComponentModel.DataAnnotations;
using Server.Validations;

namespace Server.Models;

public record AccountData(
    [Required]
    [MinLength(8)]
    string Name, 

    [Required]
    [EmailAddress]
    string Email,

    [Required]
    [StrongPassword]
    string Password,
    
    Guid InvitedBy
);