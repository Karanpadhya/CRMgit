using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models.Mapping
{
    public static class ProfileMapper
    {
        public static ProfileDataModel Map(this ProfileDataModel entities)
        {
            return new ProfileDataModel()
            {
                UserId = entities.UserId,
                FName = entities.FName,
                LName = entities.LName,
            };
        }
    }
}