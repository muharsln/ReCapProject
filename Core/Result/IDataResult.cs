﻿namespace Core.Result
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}