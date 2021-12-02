using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProject
{
    public class AnnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee Class Validation");
            Console.WriteLine("---------------------------\n");

            Employee objEmployee = new Employee();

            objEmployee.Name = null;
            objEmployee.Age = 30;
            objEmployee.PhoneNumber = "7083280401";
            objEmployee.Email = "shitalbramhe@gmail.com";

            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name: {0}", Totalresult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Message :: {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name :" + objEmployee.Name + "\n" + "Age:" + objEmployee.Age + "\n" + "PhoneNumber" + objEmployee.PhoneNumber);
            }
        }
    }
}
