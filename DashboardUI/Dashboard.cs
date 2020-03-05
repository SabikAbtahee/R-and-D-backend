using DashboardUI.Validators;
using FluentValidation.Results;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardUI
{
  public partial class Dashboard : Form
  {
    BindingList<string> errors = new BindingList<string>();

    public Dashboard()
    {
      InitializeComponent();
      errorListBox.DataSource = errors;
    }

    private void createButton_Click(object sender, EventArgs e)
    {
      errors.Clear();

     // if (!double.TryParse(accountBalanceText.Text, out double accountBalance))
     // {
     //   errors.Add("Account Balance: Invalid Amount");
     //   return;
     // }

      PersonModel person = new PersonModel();
      person.FirstName = firstNameText.Text;
      person.LastName = lastNameText.Text;
      //person.AccountBalance = accountBalanceText.Text;
      person.DateOfBirth = dateOfBirthPicker.Value;

            PersonValidator validator = new PersonValidator();

            ValidationResult x= validator.Validate(person);

            if (x.IsValid == false) {
                foreach (ValidationFailure err in x.Errors) {
                    errors.Add($"{err.PropertyName}:{err.ErrorMessage}");
                }
            }
      // Insert into the database

            MessageBox.Show("Operation Complete");
    }
  }
}
