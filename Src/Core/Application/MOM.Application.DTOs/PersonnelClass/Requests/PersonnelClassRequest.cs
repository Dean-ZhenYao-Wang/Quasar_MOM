using Json.More;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.PersonnelClass.Requests
{
    public class PersonnelClassRequest
    {
        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }
    }
}
