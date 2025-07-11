namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Interfaces;
public interface ILinkProtocolHandler<in TRequest> where TRequest : ILinkProtocolRequest
{
    Task Handle(TRequest command, CancellationToken cancellationToken = default);
}
