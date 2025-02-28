using MediatR;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Server.Application.AppUser.Commands;
using Server.Application.Common.Interfaces;
using Server.Domain.Entities;

namespace Server.Application.AppUser;

public class CreateUserHandler : IRequestHandler<CreateUserCommand>
{
    private readonly IApplicationDbContext _context;

    public Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var entity = new ApplicationUser {
            Name = request.Name,
            Email = request.Email,
            Password = request.Password,
            Id = Guid.NewGuid()
        };

        return null;
    }
}