using MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
internal class HebrewSentenceViewModel
{
    private readonly ITransliterationProvider _transliterationProvider;
    public MarkupString Transliteration { get; private set; } = default!;
    public string Hebrew { get; set; } = default!;
    public HebrewSentenceViewModel(
        ITransliterationProvider transliterationProvider
        )
    {
        _transliterationProvider = transliterationProvider;
    }

    public async Task Initialize()
    {
        Transliteration = (MarkupString)await _transliterationProvider.TransliterateAsync(Hebrew);
    }

}
