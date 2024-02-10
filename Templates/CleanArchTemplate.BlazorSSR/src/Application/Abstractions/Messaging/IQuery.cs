﻿using Ardalis.Result;
using MediatR;

namespace CleanArchTemplate.BlazorSSR.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}