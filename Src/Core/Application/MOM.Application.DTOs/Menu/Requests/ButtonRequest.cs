namespace MOM.Application.DTOs.Menu.Requests
{
    public class ButtonRequest
    {
        public Guid DtId { get; set; } = Guid.NewGuid();
        /// <summary>
        /// 编号
        /// </summary>
        public required string Id { get; set; }
        public required string Name { get; set; }
        public string? Icon { get; set; }

    }
}