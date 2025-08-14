namespace MOM.Application.DTOs.MaterialDefinition.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateMaterialDefinitionRequest : AddMaterialDefinitionRequest
    {
        /// <summary>
        /// 物料定义唯一标识
        /// </summary>
        public Guid DtId { get; set; }
    }
}
