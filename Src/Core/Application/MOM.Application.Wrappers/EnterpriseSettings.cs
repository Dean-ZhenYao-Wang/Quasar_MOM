namespace MOM.Application.Wrappers
{
    public class EnterpriseSettings
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        public string Name { get; set; }

        public string Description { get; set; }
        public string Address { get; set; }

        /// <summary>
        /// 本网站外网根目录
        /// </summary>
        public string Host { get; set; }
    }
}