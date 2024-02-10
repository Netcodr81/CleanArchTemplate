using Ardalis.Result;
using MediatR;

namespace CleanArchTemplate.Api.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}