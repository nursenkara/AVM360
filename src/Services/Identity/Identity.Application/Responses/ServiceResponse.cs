using Identity.Application.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Responses
{
    public class ServiceResponse<TKey> : ResponseBase
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TKey Data { get; }
        public ServiceResponse(ResultTypeEnum resultType, string message, TKey data) : base(message, resultType)
        {
            Data = data;
        }
    }
}
