using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Zad2
{
    public class Student : Person
    {
        public string School { get; set; }
        private bool _canGoAloneToHome { get; set; }

        public string Info()
        {
            if (GetAge() >= 12)
                return "Ma wiecej niż 12 lat";
            if (_canGoAloneToHome)
                return "Ma zgodę";
            return "Nie ma zgody i ma mniej niż 12 lat";
        }

        public override bool CanGoAloneToHome()
        {
            return base.GetAge() >= 12 || _canGoAloneToHome; 
        }

        public override string GetEducationInfo()
        {
            return School;
        }

        public override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void SetSchool(string school)
        {
            School = school;
        } 
        
        public void ChangeSchool(string school)
        {
            School = school;
        } 
        
        public void SetCanGoHomeAlone(bool canGoAloneToHome)
        {
            _canGoAloneToHome = canGoAloneToHome;
        }

    }
}
