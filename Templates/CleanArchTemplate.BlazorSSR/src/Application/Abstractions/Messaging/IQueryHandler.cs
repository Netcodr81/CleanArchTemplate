﻿using Ardalis.Result;
using MediatR;

namespace CleanArchTemplate.BlazorSSR.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}