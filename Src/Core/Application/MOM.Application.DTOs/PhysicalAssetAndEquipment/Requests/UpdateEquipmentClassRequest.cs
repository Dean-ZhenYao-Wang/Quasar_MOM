namespace MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateEquipmentClassRequest : AddEquipmentClassRequest
    {
        /// <summary>
        /// 设备类别ID
        /// </summary>
        public Guid DtId { get; set; }
    }
}