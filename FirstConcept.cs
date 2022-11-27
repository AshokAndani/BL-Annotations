using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Annotations
{
    public class Student
    {
        [Required,StringLength(100,MinimumLength =4,ErrorMessage ="minmum lenght required is 4")]
        public string Name { get; set; }
        [Required,Range(18,99,ErrorMessage ="Age should be between 18 and 99")]
        public int Age { get; set; }
    }
    public class BuiltInAnnotationTest
    {
        public static void Run()
        {
            Student student = new Student
            {
                Age=10,
                Name="Ash"
            };
            var validationContext = new ValidationContext(student);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            var flag=Validator.TryValidateObject(student,validationContext,validationResults,true);
            foreach(ValidationResult result in validationResults)
            {
                Console.WriteLine($"Variable Name: {result.MemberNames.First()} Error: {result.ErrorMessage}");
            }
        }
    }
}
