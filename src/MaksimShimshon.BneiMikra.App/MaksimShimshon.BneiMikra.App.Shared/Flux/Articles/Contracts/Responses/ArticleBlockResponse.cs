namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
public record ArticleBlockResponse
{
    private string __component = default!;
    public string Component { get => __component; }

    public int Id { get; set; }
    public string Body { get; set; }
}
