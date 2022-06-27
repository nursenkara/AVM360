using Identity.Application.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Responses
{
    public class ErrorResponse : ResponseBase
    {
        public ErrorResponse(ResultTypeEnum resultType, string message) : base(message,resultType)
        {

        }
    }
}
