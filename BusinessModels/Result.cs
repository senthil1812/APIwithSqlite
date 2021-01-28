using System;

namespace BusinessModels
{
    public class Result<T> : BaseResult
    {
        public T Data { get; set; }
    }
}
