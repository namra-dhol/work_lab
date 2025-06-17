using System.ComponentModel.DataAnnotations;

namespace SEM5.Models
{
    public class StateModel
    {
        public int? StateID { get; set; }

        [Required]
        public int CountryID { get; set; }

        [Required]
        public string StateName { get; set; }

        [Required]
        public string StateCode { get; set; }


          public class StateDropDownModel
        {
            public int StateID { get; set; }
            public string StateName { get; set; }
        }
    }
  
}
