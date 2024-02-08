﻿using Ardalis.Result;
using MediatR;

namespace CleanArchTemplate.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}