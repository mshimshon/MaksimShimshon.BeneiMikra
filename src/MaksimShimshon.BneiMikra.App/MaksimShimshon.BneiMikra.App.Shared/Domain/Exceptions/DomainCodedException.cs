namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Exceptions;
public abstract class DomainCodedException : Exception
{

    protected DomainCodedException(string code, string message) : base(message)
    {
    }
}
