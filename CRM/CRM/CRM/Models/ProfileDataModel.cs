using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using CRM.Resources;


namespace CRM.Models
{
    public class ProfileDataModel : IEnumerable
    {
        
            [Required]
            public int UserId { get; set; }

            [Required]
            [Display(ResourceType = typeof(Resource), Name = "FName")]
            public string FName { get; set; }
            [Required]
            [Display(ResourceType = typeof(Resource), Name = "LName")]
            public string LName { get; set; }
            [Required]
            [Display(ResourceType = typeof(Resource), Name = "PhoneNumber")]
            public long PhoneNo { get; set; }

            [Required]
            [Display(ResourceType = typeof(Resource), Name = "Email")]
            public string Email { get; set; }


            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        



    }
}