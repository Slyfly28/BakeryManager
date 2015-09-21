using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BakeryManager.Models
{
    public class UserInfoModel
    {
        public UserInfo GetUserInformation(string guid)
        {
            BakeryDBEntities db = new BakeryDBEntities();
            UserInfo info = (from x in db.UserInfoes
                where x.GUID == guid
                select x).FirstOrDefault();
            return info;
        }

        public void InsertUserInformation(UserInfo info)
        {
            BakeryDBEntities db = new BakeryDBEntities();
            db.UserInfoes.Add(info);
            db.SaveChanges();
        }

    }
}