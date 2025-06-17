using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SEM5.Models
{
    public class CountryModel
    {
        public int? CountryID { get; set; }

        [Required]
        public string CountryName { get; set; }

        public class CountryDropDownModel
        {
            public int CountryID { get; set; }
            public string CountryName { get; set; }
        }
    }
    
}

