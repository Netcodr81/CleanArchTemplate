using Ardalis.Result;
using MediatR;

namespace CleanArchTemplate.BlazorWebApp.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}