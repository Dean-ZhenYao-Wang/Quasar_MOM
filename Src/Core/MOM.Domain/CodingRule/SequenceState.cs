namespace MOM.Domain.CodingRule
{
    /// <summary>
    /// 序列状态
    /// </summary>
    public class SequenceState
    {
        public int Id { get; set; }
        public string ModelTypeName { get; set; }
        public string SequenceName { get; set; }
        public int CurrentValue { get; set; }
    }

}
