using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
public partial class HebrewSentence : ComponentBase
{
    [Inject] private ITransliterationProvider TransliterationProvider { get; set; } = default!;
    [Parameter] public string Hebrew { get; set; } = default!;
    [Parameter] public string? Translation { get; set; }
    [Parameter] public List<TanakhReferenceResponse>? ScripturalReferences { get; set; }

}
