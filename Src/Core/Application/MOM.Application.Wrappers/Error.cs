namespace MOM.Application.Wrappers
{
    public class Error(ErrorCode errorCode, string description = null, string fieldName = null)
    {
        /// <summary>
        /// ������
        /// </summary>
        public ErrorCode ErrorCode { get; set; } = errorCode;

        /// <summary>
        /// �ֶ�����
        /// </summary>
        public string FieldName { get; set; } = fieldName;

        /// <summary>
        /// ˵��
        /// </summary>
        public string Description { get; set; } = description;
    }
}