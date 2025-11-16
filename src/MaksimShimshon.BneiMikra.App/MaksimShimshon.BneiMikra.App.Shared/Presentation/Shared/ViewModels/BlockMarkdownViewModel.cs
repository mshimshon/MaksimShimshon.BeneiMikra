namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
internal class BlockMarkdownViewModel
{
    public string Body { get; set; } = default!;
    public Task Initialize()
    {
        Body = Body.Replace("\n", "<br/>");
        return Task.CompletedTask;
    }
}
