using Identity.Application.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Responses
{
    public class ResponseBase
    {
        public ResultTypeEnum ResultType { get; }
        public string Message { get; }
        public string ResponseType { get; set; }

        public ResponseBase(string message, ResultTypeEnum resultType)
        {
            Message = message;
            ResultType = resultType;
            ResponseType = resultType.ToString();
        }
    }
}
