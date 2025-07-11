using MaksimShimshon.BneiMikra.App.Shared.Domain.Exceptions;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Exceptions;
public class AppUnknownException : DomainCodedException
{
    public AppUnknownException(string code, string message) : base(code, message)
    {
    }
}
