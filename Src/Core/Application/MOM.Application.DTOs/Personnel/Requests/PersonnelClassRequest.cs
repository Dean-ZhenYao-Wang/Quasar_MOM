using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.Personnel.Requests
{
    public class PersonnelClassRequest
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
