using FluentValidation;
using MediatR;

namespace Twitter.Clone.Messenger.Common.Behaviours
{
    public class ValidationBehaviour<TRequest, TResponse>(IEnumerable<IValidator<TRequest>> validators) : IPipelineBehavior<TRequest, TResponse> 
        where TRequest : notnull
    {
        private readonly IEnumerable<IValidator<TRequest>> _validator = validators;
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validator.Any())
            {
                var context = new ValidationContext<TRequest>(request);
                var validationResults = await Task.WhenAll(
                    _validator.Select(v =>
                    v.ValidateAsync(context, cancellationToken)));

                var failures = validationResults
                    .Where(r => r.Errors.Count != 0)
                    .SelectMany(r => r.Errors)
                    .ToList();
                if (failures.Count > 0)
                    throw new ValidationException(failures);
            }
            return await next();
        }
    }
}
