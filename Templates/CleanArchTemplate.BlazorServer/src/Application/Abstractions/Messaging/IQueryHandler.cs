using Ardalis.Result;
using MediatR;

namespace CleanArchTemplate.BlazorServer.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}