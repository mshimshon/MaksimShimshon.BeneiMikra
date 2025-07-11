﻿using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Queries.Handlers;
internal class GetArticleHandler : IRequestHandler<GetArticleQuery, ArticleEntity>
{
    private readonly IArticleReadRepository _articleReadRepository;

    public GetArticleHandler(
        IArticleReadRepository articleReadRepository
        )
    {
        _articleReadRepository = articleReadRepository;
    }
    public async Task<ArticleEntity> Handle(GetArticleQuery request, CancellationToken cancellationToken)
    {
        return await _articleReadRepository.GetById(request.Id);

    }
}
