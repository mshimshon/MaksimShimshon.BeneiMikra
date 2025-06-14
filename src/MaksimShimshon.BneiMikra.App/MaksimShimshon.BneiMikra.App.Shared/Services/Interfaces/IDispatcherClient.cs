namespace MaksimShimshon.BneiMikra.App.Shared.Services.Interfaces;
public interface IDispatcherClient
{

    Task DispatchApi(Func<IHttpClient, Task<HttpResponseMessage>> OnCall, Func<HttpResponseMessage, Task> whenSuccess, Func<Task> whenAnyFailure, Func<HttpResponseMessage, Task>? overrideLoginRequired = default, Func<HttpResponseMessage, Task>? overridePermissionDenied = default, Func<HttpResponseMessage, Task>? overrideException = default);
}
