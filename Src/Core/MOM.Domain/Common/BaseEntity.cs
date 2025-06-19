using System.ComponentModel.DataAnnotations;

namespace MOM.Domain.Common
{
    /// <summary>
    /// ģ�͵ĳ������
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// ���ݿ�Ψһ����
        /// </summary>
        [Key]
        public Guid DtId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// ���
        /// ����ID������������صĽ�����Ϣ����ȷ�ϸö��󡣶���ID���Բ���ȫ�ֵĶ���ID��Ҳ�������ݿ��������ԡ�
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ���������ݿ�Ψһ��ʶ
        /// </summary>
        public Guid CreatedBy { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// ����޸������ݿ�Ψһ��ʶ
        /// </summary>
        public Guid? LastModifiedBy { get; set; }
        /// <summary>
        /// ����޸�ʱ��
        /// </summary>
        public DateTime? LastModified { get; set; }
        /// <summary>
        /// �Ƿ�ɾ��
        /// </summary>
        public bool IsDelete { get; set; }
        /// <summary>
        /// ��ɾ��
        /// </summary>
        public virtual void Delete()
        {
            this.IsDelete = true;
        }
    }
}