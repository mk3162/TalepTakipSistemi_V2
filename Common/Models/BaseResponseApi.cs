using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models
{
    public class BaseResponseApi<T>
    {
        public bool Status { get; set; }
        public string StatusMessage { get; set; }
        public List<T> Data { get; set; }
    }
}
