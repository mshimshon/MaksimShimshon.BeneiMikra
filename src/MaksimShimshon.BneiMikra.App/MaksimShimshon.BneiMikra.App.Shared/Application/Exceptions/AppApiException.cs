using MaksimShimshon.BneiMikra.App.Shared.Domain.Errors.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Exceptions;
public class AppApiException : Exception
{
    public List<ValidationErrorEntity> Errors { get; }
    public AppApiException(params ValidationErrorEntity[] errors) : base("Validation Error Entitys")
    {
        Errors = errors.ToList();
    }
}
