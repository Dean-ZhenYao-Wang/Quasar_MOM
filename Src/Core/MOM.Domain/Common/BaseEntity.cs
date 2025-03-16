using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public string DtId { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// ����
        /// ����ID������������صĽ�����Ϣ����ȷ�ϸö��󡣶���ID���Բ���ȫ�ֵĶ���ID��Ҳ�������ݿ��������ԡ�
        /// </summary>
        [JsonPropertyName("Id")]
        public string Id { get; set; }
    }
}
