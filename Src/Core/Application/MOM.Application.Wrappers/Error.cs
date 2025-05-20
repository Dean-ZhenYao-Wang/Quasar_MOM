namespace MOM.Application.Wrappers
{
    public class Error(ErrorCode errorCode, string description = null, string fieldName = null)
    {
        /// <summary>
        /// ´íÎó±àºÅ
        /// </summary>
        public ErrorCode ErrorCode { get; set; } = errorCode;

        /// <summary>
        /// ×Ö¶ÎÃû³Æ
        /// </summary>
        public string FieldName { get; set; } = fieldName;

        /// <summary>
        /// ËµÃ÷
        /// </summary>
        public string Description { get; set; } = description;
    }
}