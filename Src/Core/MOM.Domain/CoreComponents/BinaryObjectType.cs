using MOM.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Domain.CoreComponents
{
    /// <summary>
    /// 用于定义表示图形、图片、声音、视频或其他形式的数据的数据类型，这些数据可以表示为二进制八位字节的有限长度序列
    /// </summary>
    internal class BinaryObjectType : BaseEntity
    {
        private BinaryObjectType() : base()
        {

        }
        public BinaryObjectType(string name, byte[] content) : this()
        {
            Id = name;
            Content = content;
        }
        [NotMapped]
        public string Name { get{ return Id; } }
        public byte[] Content { get; set; }

        internal void UpdateContent(byte[] content)
        {
            Content = content ?? [];
        }
    }
}
