﻿using Ardalis.Result;
using MediatR;

namespace CleanArchTemplate.BlazorWebApp.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}