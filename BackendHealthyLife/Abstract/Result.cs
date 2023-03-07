using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public class Result : IResult
    {
        public Result(bool success) 
        {
            Success = success ; 
        }
        public bool Success { get; }

        public string Message { get; }

    }
}
