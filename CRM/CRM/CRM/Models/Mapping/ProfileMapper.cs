using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRM.Data;

namespace CRM.Models.Mapping
{
    public static class ProfileMapper
    {
        public static ProfileDataModel Map(this Profile profile)
        {
            return new ProfileDataModel()
            {
                UserId = profile.UserId,
                FName = profile.FName,
                LName = profile.LName,
                PhoneNo = profile.PhoneNo,
                Email = profile.Email
            };
        }

        public static Profile Map(this ProfileDataModel profileDataModel)
        {
            return new Profile()
            {
                UserId = profileDataModel.UserId,
                FName = profileDataModel.FName,
                LName = profileDataModel.LName,
                PhoneNo = profileDataModel.PhoneNo,
                Email = profileDataModel.Email
            };
        }
    }
}