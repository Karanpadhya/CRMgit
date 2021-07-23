using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class ProfileDataModel
    {
        public int UserId { get; set; }

        public int FName { get; set; }

        public int LName { get; set; }

        public string Name => $"{FName} {LName}";

    }
}