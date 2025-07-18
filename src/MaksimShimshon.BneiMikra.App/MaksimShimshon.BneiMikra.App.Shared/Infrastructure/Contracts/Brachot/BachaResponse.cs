﻿using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Brachot;
public record BrachaResponse : BrachaLiteResponse
{
    public string Hebrew { get; set; } = default!;
    public string? Translated { get; set; }
    public List<TanakhReferenceResponse>? TanakhReferences { get; set; }
}
