﻿namespace MOM.Application.DTOs.PersonnelClass.Requests
{
    /// <summary>
    ///
    /// </summary>
    public class AddTeamRequest : PersonnelClassRequest
    {
        /// <summary>
        /// 负责人唯一标识
        /// </summary>
        public Guid? ResponsibleDtId { get; set; }

        /// <summary>
        /// 所属班组唯一标识
        /// </summary>
        public Guid? SourceDtId { get; set; }

        /// <summary>
        /// 所属组织唯一标识
        /// </summary>
        public Guid OrgDtId { get; set; }

        /// <summary>
        ///
        /// </summary>
        public override Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass ToPersonnelClass(string description)
        {
            var returnClass = base.ToPersonnelClass(description);
            returnClass.ResponsibleDtId = this.ResponsibleDtId;
            returnClass.HierarchyScopeRelDtId = OrgDtId;
            return returnClass;
        }
    }
}