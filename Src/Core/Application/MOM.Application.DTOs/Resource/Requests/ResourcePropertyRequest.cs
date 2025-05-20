namespace MOM.Application.DTOs.Resource.Requests
{
    public class ResourcePropertyRequest
    {
        /// <summary>
        /// 名称
        /// 对象ID仅仅用于在相关的交换信息集中确认该对象。对象ID属性不是全局的对象ID，也不是数据库索引属性。
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string? Value { get; set; }

        /// <summary>
        /// 值的度量单位
        /// </summary>
        public string? ValueUnitOfMeasure { get; set; }

        /// <summary>
        /// 映射自哪个类属性
        /// </summary>
        public Guid? mapToDtId { get; set; }
    }
}