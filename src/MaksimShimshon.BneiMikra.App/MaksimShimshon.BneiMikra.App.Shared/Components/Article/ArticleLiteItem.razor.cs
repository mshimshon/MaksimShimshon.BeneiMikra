using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Article;
public partial class ArticleLiteItem : FluxorComponent
{
    [Parameter] public ArticleLiteResponse Data { get; set; } = default!;
}
