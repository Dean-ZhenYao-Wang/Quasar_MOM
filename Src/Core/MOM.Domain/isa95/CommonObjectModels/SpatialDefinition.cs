namespace MOM.Domain.isa95.CommonObjectModels
{
    using Microsoft.EntityFrameworkCore;
    using System.Text.Json.Serialization;
    /// <summary>
    /// �ռ䶨���ṩ��һ�ֹ�ͨ��ά�㡢һά�ߡ���ά��״����ά�������ռ�λ�����ݵķ��������ڹ滮/���ȡ�ʵ�ʡ���Դ�ͷ���
    /// </summary>
    [Owned]
    public class SpatialDefinition
    {
        /// <summary>
        /// Ψһ��ʶ�ռ䶨����ַ�����<br/>
        /// UN/CEFACT CCTS: ��TextType���ĵ���ռ���Ϣ����ʽ��format����ָ����
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        /// <summary>
        /// ȷ��value���Ը�ʽ��ö����������GPX�� WKT����
        /// </summary>

        [JsonPropertyName("format")]
        public string? Format { get; set; }
        /// <summary>
        /// SRID�ǿռ�ο���ʶ����Spatial Reference Identifier������ͨ��ʶ������ο�ϵͳ��ʶ��һ��Ԥ��������ꡣ
        /// </summary>
        [JsonPropertyName("SRID")]
        public string? SRID { get; set; }
        /// <summary>
        /// SRID��Ȩ������ʶ����SRID��ʶ������ο�ϵ����Ȩ������
        /// </summary>
        [JsonPropertyName("SRIDauthority")]
        public string? SRIDauthority { get; set; }
    }
}