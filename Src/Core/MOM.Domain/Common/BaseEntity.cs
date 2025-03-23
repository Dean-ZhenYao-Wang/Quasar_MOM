using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid DtId { get; set; } = Guid.NewGuid();
        /// <summary>
        /// ����
        /// ����ID������������صĽ�����Ϣ����ȷ�ϸö��󡣶���ID���Բ���ȫ�ֵĶ���ID��Ҳ�������ݿ��������ԡ�
        /// </summary>
        [JsonPropertyName("Id")]
        public string Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IsDelete { get; set; }
    }
}
