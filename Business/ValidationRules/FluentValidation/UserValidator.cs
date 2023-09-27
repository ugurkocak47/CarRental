using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u=>u.FirstName).NotEmpty();
            RuleFor(u=>u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email.Length).GreaterThanOrEqualTo(11);
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).Must(IncludesSymbols);
            RuleFor(u => u.Password).Must(IncludeUpperAndLower);
            RuleFor(u=>u.Password.Length).GreaterThanOrEqualTo(6);
        }
        private bool IncludesSymbols(string arg)
        {
            // Regular expression to check if password contains at least one symbol character.
            string symbolPattern = @"[!@#$%^&*()\-_=+[\]{}|;:',.<>/?]";

            // Use Regex.IsMatch to check if the password matches the symbol pattern.
            bool containsSymbol = Regex.IsMatch(arg, symbolPattern);

            // You can add more conditions here to check for minimum length, uppercase, lowercase, digits, etc.

            return containsSymbol;
        }
        private bool IncludeUpperAndLower(string arg)
        {
            string uppercasePattern = @"[A-Z]";
            string lowercasePattern = @"[a-z]";
            bool containsUpperAndLower = Regex.IsMatch(arg, uppercasePattern) && Regex.IsMatch(arg,lowercasePattern);
            return containsUpperAndLower;

        }
    }
}
