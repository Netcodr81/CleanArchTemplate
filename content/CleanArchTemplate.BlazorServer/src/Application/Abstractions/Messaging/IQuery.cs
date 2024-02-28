using Ardalis.Result;
using MediatR;

namespace CleanArchTemplate.BlazorServer.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}