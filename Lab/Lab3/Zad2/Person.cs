using System;

namespace Lab3.Zad2
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public string Pesel;

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        } 
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
        
        public void SetPesel(string pesel)
        {
            Pesel = pesel;
        }   

        public int GetAge()
        {
            return (DateTime.Today - getBirthDate()).Days / 365;
        }

        private DateTime getBirthDate()
        {
            var year = int.Parse(Pesel.Substring(0, 2));
            var month = int.Parse(Pesel.Substring(2, 2));
            var day = int.Parse(Pesel.Substring(4, 2));

            if (month > 80)
            {
                year = year + 1800;
                month = month - 80;
            }
            else if (month > 60)
            {
                year = year + 2200;
                month = month - 60;
            }
            else if (month > 40)
            {
                year = year + 2100;
                month = month - 40;
            }
            else if (month > 20)
            {
                year = year + 2000;
                month = month - 20;
            }
            else
            {
                year += 1900;
            }

            return new DateTime(year, month, day);
        }

        public string GetGender()
        { 
            return int.Parse(Pesel[9].ToString()) % 2 == 0? "Woman": "Man"; 
        }

        public abstract string GetEducationInfo();
        public abstract string GetFullName();
        public abstract bool CanGoAloneToHome();
    }
}
