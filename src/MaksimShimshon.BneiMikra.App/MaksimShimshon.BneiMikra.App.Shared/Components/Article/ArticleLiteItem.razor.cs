using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Contracts.Responses;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Article;
public partial class ArticleLiteItem : ComponentBase
{
    [Parameter] public ArticleLiteResponse Data { get; set; } = default!;
}
