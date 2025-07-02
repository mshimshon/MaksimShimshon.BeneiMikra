using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Articles.Components;
public partial class ArticleLiteItem : ComponentBase
{
    [Parameter] public ArticleEntity Data { get; set; } = default!;
}
