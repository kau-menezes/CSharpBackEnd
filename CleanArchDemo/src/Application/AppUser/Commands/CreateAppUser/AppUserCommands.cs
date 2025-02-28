using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Server.Application.AppUser.Commands;

public record CreateUserCommand
(
    [Required]
    string Name,

    [EmailAddress]
    [Required]
    string Email,

    [Required]
    [MinLength(8)]
    string Password
) : IRequest;