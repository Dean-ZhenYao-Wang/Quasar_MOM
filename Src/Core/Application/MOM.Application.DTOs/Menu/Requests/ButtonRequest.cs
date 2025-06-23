namespace MOM.Application.DTOs.Menu.Requests
{
    /// <summary>
    ///
    /// </summary>
    public class ButtonRequest
    {
        /// <summary>
        ///
        /// </summary>
        public Guid DtId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string? Icon { get; set; }
    }
}