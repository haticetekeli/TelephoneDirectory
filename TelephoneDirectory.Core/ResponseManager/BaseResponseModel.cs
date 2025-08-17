using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TelephoneDirectory.Core.ResponseManager
{

    public class BaseResponseModel<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }

        public BaseResponseModel()
        {
            Errors = new List<string>();
        }
    }
}