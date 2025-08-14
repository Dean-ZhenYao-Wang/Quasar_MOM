namespace MOM.Application.DTOs.MaterialClass.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateMaterialClassRequest:AddMaterialClassRequest
    {
        public Guid DtId { get; set; }
    }
}