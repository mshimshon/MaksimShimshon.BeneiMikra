using System.Text.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Services.Data;
public class TransliteratorSchema
{
    public Dictionary<string, string> LetterMap { get; set; } = new();
    public Dictionary<char, string> NiqqudMap { get; set; } = new();
    public Dictionary<string, string> SpecialCombinations { get; set; } = new();
    public Dictionary<string, string> SpecialWords { get; set; } = new();
    public string SyllableSeparator { get; set; } = string.Empty;
    public bool UseLongVowels { get; set; } = true;
    public bool UseQamatsQatan { get; set; } = true;
    public bool UseSQNMLVY { get; set; } = true;
    public bool UseWawShureq { get; set; } = true;
    public TransliteratorSchema()
    {
        // Populate default values
        PopulateDefaultValues();
    }
    public TransliteratorSchema(string json)
    {
        if (!LoadFromJson(json))
            PopulateDefaultValues();
    }
    public bool LoadFromJson(string json)
    {
        try
        {
            var parsed = JsonSerializer.Deserialize<TransliteratorSchema>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (parsed == null) return false;

            LetterMap = parsed.LetterMap ?? new();
            NiqqudMap = parsed.NiqqudMap ?? new();
            SpecialCombinations = parsed.SpecialCombinations ?? new();
            SpecialWords = parsed.SpecialWords ?? new();
            SyllableSeparator = parsed.SyllableSeparator ?? string.Empty;
            UseLongVowels = parsed.UseLongVowels;
            UseQamatsQatan = parsed.UseQamatsQatan;
            UseSQNMLVY = parsed.UseSQNMLVY;
            UseWawShureq = parsed.UseWawShureq;

            return true;
        }
        catch
        {
            return false;
        }
    }
    private void PopulateDefaultValues()
    {
        // Default Letter Map (consonants)
        LetterMap = new Dictionary<string, string>
        {
            { "א", string.Empty }, { "ב", "v" }, { "בּ", "b" }, { "ג", "g" }, { "ד", "d" },
            { "ה", "h" }, { "ו", "v" }, { "ז", "z" }, { "ח", "ch" }, { "ט", "t" },
            { "י", "y" }, { "כ", "kh" }, { "כּ", "k" }, { "ך", "kh" }, { "ל", "l" },
            { "מ", "m" }, { "ם", "m" }, { "נ", "n" }, { "ן", "n" }, { "ס", "s" },
            { "ע", string.Empty }, { "פ", "f" }, { "פּ", "p" }, { "ף", "f" }, { "צ", "ts" },
            { "ץ", "ts" }, { "ק", "k" }, { "ר", "r" }, { "ש", "sh" }, { "שׁ", "sh" },
            { "שׂ", "s" }, { "ת", "t" }, { "תּ", "t" }
        };

        // Default Niqqud Map (vowels)
        NiqqudMap = new Dictionary<char, string>
        {
            ['\u05B0'] = "e",  // Sheva: ְ
            ['\u05B1'] = "e",  // Hataf Segol: ֱ
            ['\u05B2'] = "a",  // Hataf Patah: ֲ
            ['\u05B3'] = "o",  // Hataf Qamats: ֳ
            ['\u05B4'] = "i",  // Hiriq: ִ
            ['\u05B5'] = "e",  // Tsere: ֵ
            ['\u05B6'] = "e",  // Segol: ֶ
            ['\u05B7'] = "a",  // Patah: ַ
            ['\u05B8'] = "a",  // Qamats: ָ
            ['\u05BA'] = "o",  // Holam Haser (rare): ֺ
            ['\u05BB'] = "u",  // Qubuts: ֻ
            ['\u05C1'] = "s",  // Shin Dot: ֱ
            ['\u05C2'] = "s",  // Sin Dot: ׂ
            ['\u05BE'] = "-",
            ['\u05B9'] = "o",   // Holam: ֹ

            // Marks to ignore (empty string)
            ['\u05BC'] = string.Empty,   // Dagesh/Mappiq (no vowel sound): ּ
            ['\u0591'] = string.Empty, // ETNAHTA
            ['\u0592'] = string.Empty, // SEGOL
            ['\u0593'] = string.Empty, // SHALSHELET
            ['\u0594'] = string.Empty, // ZAQEF QATAN
            ['\u0595'] = string.Empty, // ZAQEF GADOL
            ['\u0596'] = string.Empty, // TIPEHA
            ['\u0597'] = string.Empty, // ETNAHTA
            ['\u0598'] = string.Empty, // SEGOLTA
            ['\u0599'] = string.Empty, // ZARQA
            ['\u059A'] = string.Empty, // PASHTA
            ['\u059B'] = string.Empty, // YETIV
            ['\u059C'] = string.Empty, // TEVIR
            ['\u059D'] = string.Empty, // GERESH
            ['\u059E'] = string.Empty, // GERESH MUQDAM
            ['\u059F'] = string.Empty, // GERSHAYIM
            ['\u05A0'] = string.Empty, // QARNEY PARA
            ['\u05A1'] = string.Empty, // TELISHA GEDOLA
            ['\u05A3'] = string.Empty, // MASORA CIRCLE
            ['\u05A4'] = string.Empty, // MASORA MARK
            ['\u05A5'] = string.Empty, // MAQAF
            ['\u05A6'] = string.Empty, // MAQAF
            ['\u05A7'] = string.Empty, // PASEQ
            ['\u05A8'] = string.Empty, // PASEQ
            ['\u05A9'] = string.Empty, // REVERSED PASEQ
            ['\u05AA'] = string.Empty, // DOUBLE PASEQ
            ['\u05AB'] = string.Empty, // PASEQ
            ['\u05AC'] = string.Empty, // ILUY
            ['\u05AD'] = string.Empty, // DEHI
            ['\u05AE'] = string.Empty, // ZINOR
            ['\u05AF'] = string.Empty, // MASORA VERTICAL BAR
            ['\u05C0'] = string.Empty, // PASEQ
            ['\u05C1'] = string.Empty, // SHIN DOT
            ['\u05C2'] = string.Empty, // SIN DOT
            ['\u05C3'] = string.Empty, // SOF PASUQ (punctuation)
            ['\u05C4'] = string.Empty, // UPPER DOT
            ['\u05C5'] = string.Empty, // LOWER DOT
            ['\u05C6'] = string.Empty, // NUN HAFUKHA
            ['\u05F3'] = string.Empty, // GERESH (׳)
            ['\u05F4'] = string.Empty, // GERSHAYIM (״)
            ['\u200E'] = string.Empty, // LEFT-TO-RIGHT MARK (invisible)
            ['\u200F'] = string.Empty, // RIGHT-TO-LEFT MARK (invisible)
            ['\u05BD'] = string.Empty, // METEG
        };

        // Default Special Combinations (e.g., יוּ, יֵ, etc.)
        SpecialCombinations = new Dictionary<string, string>
        {
            { "יּ", "yy" }, { "וּ", "u" }, { "יֵ", "ei" }, { "יִ", "yi" }
        };

        // Default Special Words (e.g., "Adonai", "Elohim")
        SpecialWords = new Dictionary<string, string>
        {
            { "יְהוָ֨ה", "Adonai" },
            { "אֱלֹהִֽים", "Elohim" }
        };

        // Additional settings
        SyllableSeparator = string.Empty;
        UseLongVowels = false;
        UseQamatsQatan = true;
        UseSQNMLVY = true;
        UseWawShureq = true;
    }
}
