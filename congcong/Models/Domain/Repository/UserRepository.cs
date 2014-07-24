using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congcong.Models
{
 /*   public class UserRepository : RepositoryBase<RegisterModel>
    {
        private UsersContext db = new UsersContext();
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns></returns>
        public override bool Add(RegisterModel user)
        {
            bool isSuccess = false;
            if (user != null)
            {
                //dbContext.UserProfiles.Add(new UserProfile { UserName = user.UserName });
                //dbContext.SaveChanges();
                ExternalUserInformation newExtUser = new ExternalUserInformation
                {
                    UserId = user.UserId,
                    GroupId = user.GroupId,
                    Email = user.Email,
                    SecurityQuestion = user.SecurityQuestion,
                    SecurityAnswer = user.SecurityAnswer,
                    RegTime = user.RegTime,
                    LastLoginTime = user.LastLoginTime
                };
                db.ExternalUsers.Add(newExtUser);
                isSuccess = db.SaveChanges() > 0;
            }
            return isSuccess;
        }
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public override bool Update(RegisterModel user)
        {
            var userObj = dbContext.ExternalUsers.SingleOrDefault(u => u.UserId == user.UserId);
            if (userObj == null) return false;
            userObj = user;
            if (dbContext.SaveChanges() > 0) return true;
            else return false;
        }
    }*/
}

/*
namespace congcong.Models
{
    public class UserRepository : RepositoryBase<RegisterModel>
    {
       
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns></returns>
        public override bool Add(RegisterModel user)
        {
            bool isSuccess = false;
            if (user != null)
            {
                //dbContext.UserProfiles.Add(new UserProfile { UserName = user.UserName });
                //dbContext.SaveChanges();
                ExternalUserInformation newExtUser = new ExternalUserInformation
                {
                    UserId = user.UserId,
                    GroupId = user.GroupId,
                    Email = user.Email,
                    SecurityQuestion = user.SecurityQuestion,
                    SecurityAnswer = user.SecurityAnswer,
                    RegTime = user.RegTime,
                    LastLoginTime = user.LastLoginTime
                };
                dbContext.ExternalUsers.Add(newExtUser);
                isSuccess = dbContext.SaveChanges() > 0;
            }
            return isSuccess;
        }
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public override bool Update(RegisterModel user)
        {
            var userObj = dbContext.ExternalUsers.SingleOrDefault(u => u.UserId == user.UserId);
            if (userObj == null) return false;
            userObj = user;
            if (dbContext.SaveChanges() > 0) return true;
            else return false;
        }
    }
}
*/