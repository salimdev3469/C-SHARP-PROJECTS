using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISA_PERMISSION_FORM_APP
{
    internal class TurkishCitizen
    {
        public long SSN { get; set; }
        public string NameSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }

        public TurkishCitizen()
        {
            RegisterDate = DateTime.Now;
        }
        public string HaveVisa()
        {
            int age = AgeCalculator(BirthDate);
            if (age >= 18)
            {
                return "You can apply.";

            }
            else
            {
                return "Parental permission required.";
            }
        }

        public int AgeCalculator(DateTime birthdate)
        {
            return DateTime.Today.Year - birthdate.Year;
        }
    }
}
