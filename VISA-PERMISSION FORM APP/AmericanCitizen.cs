using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISA_PERMISSION_FORM_APP
{
    internal class AmericanCitizen
    {
        public string NameSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Language { get; set; }
        public int age
        {
            get
            {
                return DateTime.Today.Year - BirthDate.Year;

            }
        }
    }
}
