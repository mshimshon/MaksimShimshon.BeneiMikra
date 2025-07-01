using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Article;
public partial class ArticleLiteItem : ComponentBase
{
    [Parameter] public ArticleEntity Data { get; set; } = default!;
}
