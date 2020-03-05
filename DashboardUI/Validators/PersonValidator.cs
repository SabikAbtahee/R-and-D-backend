using FluentValidation;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardUI.Validators
{
    public class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator() {
            //rulefor(p => p.lastname).cascade(cascademode.stoponfirstfailure)
            //  .must(validationhelper.ispositivevalue).withmessage("err_msg_minimum_value_zero")
            //  .must(validationhelper.isvaluemaxeighteendigit).withmessage("err_msg_maximum_value_eighteen_digit")
            // .when(p => !double.isnan(p.accountbalance))
            // .must(validationhelper.ispositivevalue).withmessage("double hoise")
            // .when(p => double.isnan(p.lastname));
            //RuleFor(p => p.LastName).Cascade(CascadeMode.StopOnFirstFailure)
            //    .Must(ValidationHelper.isString).WithMessage("ASSIGN DOUBLE")
            //    .When(p => !string.IsNullOrEmpty(p.LastName))
            //    .WithMessage("dddd")
            //    .When(p=> string.IsNullOrEmpty(p.LastName));
            //.Other; ;


            When(customer => string.IsNullOrEmpty(customer.LastName), () => { 
                RuleFor(customer => customer.LastName).Cascade(CascadeMode.StopOnFirstFailure)
                .Must(ValidationHelper.isNotString)
                .WithMessage("NULL AND EMPTY")
                .NotEmpty().WithMessage("Empty string");
            }).Otherwise(() => {

                RuleFor(customer => customer.LastName)
                .Must(ValidationHelper.isNotString)
                .WithMessage("STRING na");
            });


        }


    }
}
