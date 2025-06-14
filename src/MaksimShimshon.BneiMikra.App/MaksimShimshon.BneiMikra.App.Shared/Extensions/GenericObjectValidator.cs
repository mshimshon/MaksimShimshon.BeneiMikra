using FluentValidation;
using FluentValidation.Results;

namespace MaksimShimshon.BneiMikra.App.Shared.Extensions;
public abstract class GenericObjectValidator<TData> : AbstractValidator<TData>, IObjectValidation<TData>
{
    public IValidator<TData> GetValidator() => this;
    public async Task<ValidationResult> ValidateDataAsync(TData data, CancellationToken cancellationToken = default)
     => await ValidateAsync(data, cancellationToken);
}

public interface IObjectValidation<TData>
{
    IValidator<TData> GetValidator();
    Task<ValidationResult> ValidateDataAsync(TData data, CancellationToken cancellationToken = default);

}
