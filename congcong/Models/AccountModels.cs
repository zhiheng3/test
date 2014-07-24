using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace congcong.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
     //   public DbSet<ExternalUserInformation> ExternalUsers { get; set; }
    }

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

    public class RegisterExternalLoginModel
    {
        [Required]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        public string ExternalLoginData { get; set; }
    }

    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "当前密码")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "新密码")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认新密码")]
        [Compare("NewPassword", ErrorMessage = "新密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [Display(Name = "记住我?")]
        public bool RememberMe { get; set; }
    }

    [NotMapped]
    public class RegisterModel
    {
        [Required]
        [Display(Name = "注册邮箱")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "真实姓名")]
        public string name { get; set; }

        [Required]
        [Display(Name = "密保问题")]
        public string securityQuestion { get; set; }

        [Required]
        [Display(Name = "密保答案")]
        public string securityAnswer { get; set; }
    }

    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }

    /*[Table("ExtraUserInformation")]
    public class ExternalUserInformation
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        /// <summary>
        /// 用户组Id
        /// </summary>
        [Display(Name = "用户组Id")]
        public int GroupId { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        [Display(Name = "Email", Description = "请输入您常用的Email。")]
        [Required(ErrorMessage = "×")]
        public string Email { get; set; }
        /// <summary>
        /// 密保问题
        /// </summary>
        [Display(Name = "密保问题", Description = "请正确填写，在您忘记密码时用户找回密码。4-20个字符。")]
        [Required(ErrorMessage = "×")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "×")]
        public string SecurityQuestion { get; set; }
        /// <summary>
        /// 密保答案
        /// </summary>
        [Display(Name = "密保答案", Description = "请认真填写，忘记密码后回答正确才能找回密码。2-20个字符。")]
        [Required(ErrorMessage = "×")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "×")]
        public string SecurityAnswer { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime? RegTime { get; set; }
        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }
    
    }*/
}
