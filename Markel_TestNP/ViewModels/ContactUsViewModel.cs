using FluentValidation;
using Markel_TestNP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Markel_TestNP.ViewModels
{

    public class ContactUsViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        [MinLength(5)]
        [MaxLength(500)]
        public string Body { get; set; }

        public PageContent PageContent { get; set; }
    }

    public class ContactUsViewModelValidator : AbstractValidator<ContactUsViewModel>
    {
        public ContactUsViewModelValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Required");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Required").EmailAddress().WithMessage("Invalid Email address");
            RuleFor(p => p.Subject).NotEmpty().WithMessage("Required")
                .MaximumLength(50).WithMessage("You have exceeded the limit of 50 characters"); ;
            RuleFor(p => p.Body).NotEmpty().WithMessage("Required").MaximumLength(500).WithMessage("You have exceeded the limit of 500 characters");
        }
    }
}
