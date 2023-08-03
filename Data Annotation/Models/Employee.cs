using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Data_Annotation.Models
{

    public class Employee
    {
        [DisplayName("ID")]
        [Required(ErrorMessage ="Id is Mandatory")]
        public int EmpId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is Mandatory")]
        [StringLength(20,MinimumLength=5,ErrorMessage ="Name should be in between 5 and 20")]
        public string EmpName { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is Mandatory")]
        [Range(20,60,ErrorMessage ="Age should be in Between 20 to 60")]
        public int? EmpAge { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is Mandatory")]
        public string EmpGender { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is Mandatory")]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$", ErrorMessage ="Invalid Email")]
        public string EmpEmail { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage ="Employee Password is Mandatory")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Hint:UpperCase, LowerCase, Numbers, Symbols, 8 Characters")]
        [DataType(DataType.Password)]
        public string EmpPassword { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Employee Confirm Password is Mandatory")]
        [Compare("EmpPassword",ErrorMessage ="Password is Not Identical")]
        [DataType(DataType.Password)]
        public string EmpConfirmPassword { get; set; }

        [DisplayName("Organization Name")]
        [ReadOnly(true)]
        public string EmpOrganization { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage ="Address is mandatory")]
        [DataType(DataType.MultilineText)]
        public string EmpAddress { get; set; }

        [DisplayName("JoiningDate")]
        [Required(ErrorMessage = "Date is mandatory")]
        [DataType(DataType.Date)]
        public string EmpJoiningDate { get; set; }


        [DisplayName("JoiningTime")]
        [Required(ErrorMessage = "Time is mandatory")]
        [DataType(DataType.Time)]
        public string EmpJoiningTime { get; set; }
    }

}