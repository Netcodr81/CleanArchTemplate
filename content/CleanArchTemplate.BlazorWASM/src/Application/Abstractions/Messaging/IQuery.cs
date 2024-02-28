using Ardalis.Result;
using MediatR;

namespace CleanArchTemplate.BlazorWASM.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}