using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// 基于Sha1的自定义加密字符串方法：输入一个盐字符串，返回一个由40个字符组成的16进制的哈希散列（字符串）
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <param name="tick">盐</param>
        /// <returns>加密后的16进制的哈希散列（字符串）</returns>
        public static string Sha1Signature(this string str, string? tick = null)
        {
            if (!string.IsNullOrWhiteSpace(tick))
                str += tick;
            var buffer = Encoding.UTF8.GetBytes(str);
            var data = SHA1.HashData(buffer);
            StringBuilder sub = new();
            foreach (var t in data)
            {
                sub.Append(t.ToString("X2"));
            }
            return sub.ToString();
        }
    }
}
}
