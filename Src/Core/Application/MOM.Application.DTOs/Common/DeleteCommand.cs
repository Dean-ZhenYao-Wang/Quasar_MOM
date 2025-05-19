using MediatR;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.DTOs.Common
{
    public class DeleteCommand : IRequest<BaseResult>
    {
        /// <summary>
        /// 需要被删除的对象的DtId清单
        /// </summary>
        public Guid[] DtIds { get; set; }
    }
}
