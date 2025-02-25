using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Server.Validations;

public class StrongPasswordAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is not string password)
            return false;

        return 
            password.Any( c => c is >= '0' and <= '9') &&
            password.Any( c => c is >= 'A' and <= 'Z') &&
            password.Any( c => c is >= 'a' and <= 'z');
    }
}