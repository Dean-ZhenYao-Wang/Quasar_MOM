using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.Common
{
    /// <summary>
    /// 虽然关系可以自定义架构，但所有关系实例都应包含以下基础属性。该基类可确保自定义关系具备必要的基础属性。
    /// </summary>
    /// <remarks>
    /// <para>
    /// 此辅助类仅适用于 <see cref="System.Text.Json"/> 序列化库。当与 <see cref="Azure.Core.Serialization.ObjectSerializer"/> 
    /// （通过 <see cref="DigitalTwinsClientOptions"/> 参数传入）一起使用时，仅支持默认的 <see cref="Azure.Core.Serialization.JsonObjectSerializer"/>。
    /// </para>
    /// <para>
    /// 更多示例请参考 <see href="https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/digitaltwins/Azure.DigitalTwins.Core/samples">官方代码库示例</see>。
    /// </para>
    /// </remarks>
    /// <example>
    /// 以下示例演示如何使用 BasicRelationship 类序列化并创建楼宇数字孪生到楼层数字孪生的关系：
    ///
    /// <code snippet="Snippet:DigitalTwinsSampleCreateBasicRelationship" language="csharp">
    /// var buildingFloorRelationshipPayload = new BasicRelationship
    /// {
    ///     Id = &quot;buildingFloorRelationshipId&quot;,
    ///     SourceId = &quot;buildingTwinId&quot;,
    ///     TargetId = &quot;floorTwinId&quot;,
    ///     Name = &quot;contains&quot;,
    ///     Properties =
    ///     {
    ///         { &quot;Prop1&quot;, &quot;Prop1 value&quot; },
    ///         { &quot;Prop2&quot;, 6 }
    ///     }
    /// };
    ///
    /// Response&lt;BasicRelationship&gt; createBuildingFloorRelationshipResponse = await client
    ///     .CreateOrReplaceRelationshipAsync&lt;BasicRelationship&gt;(&quot;buildingTwinId&quot;, &quot;buildingFloorRelationshipId&quot;, buildingFloorRelationshipPayload);
    /// Console.WriteLine($&quot;Created a digital twin relationship &apos;{createBuildingFloorRelationshipResponse.Value.Id}&apos; &quot; +
    ///     $&quot;from twin &apos;{createBuildingFloorRelationshipResponse.Value.SourceId}&apos; to twin &apos;{createBuildingFloorRelationshipResponse.Value.TargetId}&apos;.&quot;);
    /// </code>
    ///
    /// 以下示例演示如何使用 BasicRelationship 类获取并反序列化关系：
    ///
    /// <code snippet="Snippet:DigitalTwinsSampleGetBasicRelationship" language="csharp">
    /// Response&lt;BasicRelationship&gt; getBasicRelationshipResponse = await client.GetRelationshipAsync&lt;BasicRelationship&gt;(
    ///     &quot;buildingTwinId&quot;,
    ///     &quot;buildingFloorRelationshipId&quot;);
    /// if (getBasicRelationshipResponse.GetRawResponse().Status == (int)HttpStatusCode.OK)
    /// {
    ///     BasicRelationship basicRelationship = getBasicRelationshipResponse.Value;
    ///     Console.WriteLine($&quot;Retrieved relationship &apos;{basicRelationship.Id}&apos; from twin {basicRelationship.SourceId}.\n\t&quot; +
    ///         $&quot;Prop1: {basicRelationship.Properties[&quot;Prop1&quot;]}\n\t&quot; +
    ///         $&quot;Prop2: {basicRelationship.Properties[&quot;Prop2&quot;]}&quot;);
    /// }
    /// </code>
    /// </example>
    public abstract class BasicRelationship : BaseEntity
    {
        /// <summary>
        /// 目标数字孪生的唯一标识符。该属性存在于所有关系中。
        /// </summary>
        [JsonPropertyName("targetId")]
        public Guid TargetId { get; set; }

        /// <summary>
        /// 源数字孪生的唯一标识符。该属性存在于所有关系中。
        /// </summary>
        [JsonPropertyName("sourceId")]
        public Guid? SourceId { get; set; }

        /// <summary>
        /// 关系名称，定义链接类型（例如"contains"）。该属性存在于所有关系中。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}