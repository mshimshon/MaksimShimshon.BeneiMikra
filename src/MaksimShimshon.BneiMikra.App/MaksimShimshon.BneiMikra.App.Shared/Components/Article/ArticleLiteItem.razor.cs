using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Article;
public partial class ArticleLiteItem : ComponentBase
{
    [Parameter] public ArticleLiteResponse Data { get; set; } = default!;
}
