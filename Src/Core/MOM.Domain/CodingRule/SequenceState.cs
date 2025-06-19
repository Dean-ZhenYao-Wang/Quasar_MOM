using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOM.Domain.CodingRule
{
    /// <summary>
    /// 序列状态
    /// </summary>
    public class SequenceState
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// 模型类型
        /// </summary>
        public required string ModelTypeName { get; set; }
        /// <summary>
        /// 序列名称
        /// </summary>
        public required string SequenceName { get; set; }
        /// <summary>
        /// 当前序列值
        /// </summary>
        public required int CurrentValue { get; set; }
    }

}
