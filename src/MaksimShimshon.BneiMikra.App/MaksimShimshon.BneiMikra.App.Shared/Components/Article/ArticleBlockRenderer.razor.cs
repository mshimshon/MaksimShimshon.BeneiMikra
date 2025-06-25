using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Article;
public partial class ArticleBlockRenderer
{
    [Parameter]
    public List<BlockResponse> Blocks { get; set; } = default!;
}
