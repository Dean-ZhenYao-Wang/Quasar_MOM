namespace MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateEquipmentRequest : AddEquipmentRequest
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        public Guid DtId { get; set; }
    }
}