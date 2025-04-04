using System.Xml.Linq;

namespace MOM.Application.Wrappers
{
    public static class TranslatorMessages
    {
        public static string NotFound() => nameof(NotFound);
        public static class AccountMessages
        {
            /// <summary>
            /// 用户名或密码错误
            /// </summary>
            /// <param name="userName"></param>
            /// <returns></returns>
            public static string TheUserNameOrPasswordIsIncorrect => nameof(TheUserNameOrPasswordIsIncorrect);
            public static TranslatorMessageDto Account_NotFound_with_UserName(string userName) => new(nameof(Account_NotFound_with_UserName), [userName]);
            public static TranslatorMessageDto Username_is_already_taken(string userName) => new(nameof(Username_is_already_taken), [userName]);
            public static string Invalid_password() => nameof(Invalid_password);
            /// <summary>
            /// 账户已锁定,5次错误登录后锁定30分钟
            /// </summary>
            /// <returns></returns>
            public static string AccountLockoutOnFailure() => nameof(AccountLockoutOnFailure);
        }
        public static class ProductMessages
        {
            public static TranslatorMessageDto Product_NotFound_with_id(long id)
                => new(nameof(Product_NotFound_with_id), [id.ToString()]);
        }
    }
}
