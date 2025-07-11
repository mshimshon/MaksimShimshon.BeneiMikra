namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Settings.Entities;
public record AppLocalSettingsEntity
{
    public string Language { get; init; } = "en";
    public bool ShowTransliteration { get; init; } = true;
    public bool ShowTranslation { get; init; } = true;

}
