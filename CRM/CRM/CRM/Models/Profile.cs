using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using CRM.Resources;

namespace CRM.Models
{
    public class Profile : IEnumerable
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(ResourceType = typeof(Resource), Name = "Fname")]
        public string Fname { get; set; }
        [Required]
        [Display(ResourceType = typeof(Resource), Name = "Lname")]
        public string Lname { get; set; }
        [Required]
        [Display(ResourceType = typeof(Resource), Name = "Phonenumber")]
        public int Phonenumber { get; set; }

        [Required]
        [Display(ResourceType = typeof(Resource), Name = "Emailaddress")]
        public string Emailaddress { get; set; }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}