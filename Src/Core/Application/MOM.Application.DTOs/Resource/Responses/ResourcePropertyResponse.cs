using MOM.Application.DTOs.Resource.Requests;
using MOM.Domain.Common.Relationship.isa95.PersonProperty;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Application.DTOs.Resource.Responses
{
    public class ResourcePropertyResponse : ResourcePropertyRequest
    {
        /// <summary>
        /// 主键：数据库唯一
        /// </summary>
        public Guid key { get; set; }

        /// <summary>
        /// 为Key的值
        /// </summary>
        public Guid dtId
        { get { return key; } }

        /// <summary>
        /// 子自定义属性清单
        /// </summary>
        public virtual List<ResourcePropertyResponse> children { get; set; }

        public ResourcePropertyResponse()
        { }

        public ResourcePropertyResponse(PersonProperty dbModel)
        {
            Id = dbModel.Id;
            Description = dbModel.Description;
            Value = dbModel.Value;
            ValueUnitOfMeasure = dbModel.ValueUnitOfMeasure;
            key = dbModel.DtId;
            children = dbModel.Contains.Select(x => new ResourcePropertyResponse(x.Target)).ToList();
        }

        //public ResourcePropertyResponse(EquipmentProperty dbModel)
        //{
        //    Id = dbModel.Id;
        //    Description = dbModel.Description;
        //    Value = dbModel.Value;
        //    ValueUnitOfMeasure = dbModel.ValueUnitOfMeasure;
        //    key = dbModel.DtId;
        //    children = dbModel.Contains.Select(x => new ResourcePropertyResponse(x.Target)).ToList();
        //}

        public PersonProperty ToPersonProperty()
        {
            var parentProperty = new PersonProperty()
            {
                Id = Id,
                Description = Description ?? string.Empty,
                Value = Value,
                ValueUnitOfMeasure = ValueUnitOfMeasure
            };
            parentProperty.DtId = key;
            if (mapToDtId != null)
                parentProperty.MapsTo.Add(new PersonPropertyMapsToRelationship(parentProperty.DtId, mapToDtId.Value));
            if (children != null)
            {
                children.ForEach(x =>
                {
                    parentProperty.ContainsAddTarget(x.ToPersonProperty());
                });
            }
            return parentProperty;
        }

        //public EquipmentProperty ToEquipmentProperty()
        //{
        //    var equipmentProperty = new EquipmentProperty()
        //    {
        //        Id = Id,
        //        Description = Description ?? string.Empty,
        //        Value = Value,
        //        ValueUnitOfMeasure = ValueUnitOfMeasure
        //    };
        //    equipmentProperty.DtId = key;
        //    if (mapToDtId != null)
        //        equipmentProperty.MapsTo.Add(new Domain.Common.Relationship.isa95.EquipmentProperty.EquipmentPropertyMapsToRelationship(equipmentProperty.DtId, mapToDtId.Value));
        //    if (children != null)
        //    {
        //        children.ForEach(x =>
        //        {
        //            equipmentProperty.ContainsAddTarget(x.ToEquipmentProperty());
        //        });
        //    }
        //    return equipmentProperty;
        //}
    }
}