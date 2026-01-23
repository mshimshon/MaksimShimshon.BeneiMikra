using MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Interfaces;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Implementation.Transliterator;

internal class TransliterationProvider : ITransliterationProvider
{
    public string Transliterate(string hebrewText, TransliteratorSchema? schema = null)
    {
        if (schema == default) schema = new();
        if (string.IsNullOrWhiteSpace(hebrewText)) return "";

        var output = new List<string>();
        var i = 0;

        while (i < hebrewText.Length)
        {
            var currentChar = hebrewText[i];

            if (currentChar == '\r' || currentChar == '\n')
            {
                output.Add(currentChar.ToString());
                i++;
                continue;
            }
            // Check for special word match (greedy)
            var matchedSpecial = false;
            foreach (var kvp in schema.SpecialWords)
            {
                var subStr = hebrewText.Substring(i);
                var x = subStr.StartsWith(kvp.Key);
                if (x)
                {
                    output.Add(kvp.Value);
                    i += kvp.Key.Length;
                    matchedSpecial = true;
                    break;
                }
            }
            if (matchedSpecial)
                continue;

            // Check for special character combination (like שׁ or וּ)
            var matchedCombo = false;
            foreach (var kvp in schema.SpecialCombinations)
            {
                var subStr = hebrewText.Substring(i);
                var x = subStr.StartsWith(kvp.Key);
                if (x)
                {
                    output.Add(kvp.Value);
                    i += kvp.Key.Length;
                    matchedCombo = true;
                    break;
                }
            }
            if (matchedCombo)
                continue;



            // Handle niqqud (vowel marks)
            if (schema.NiqqudMap.TryGetValue(currentChar, out var niqqudVal))
            {
                if (niqqudVal == string.Empty)
                {
                    i++;
                    continue;
                }
                output.Add(schema.SyllableSeparator + niqqudVal);
            }
            // Handle letters
            else if (schema.LetterMap.TryGetValue(currentChar.ToString(), out var letterVal))
                output.Add(letterVal);
            // Fallback: pass through any unknown char (e.g., punctuation)
            else
                output.Add(currentChar.ToString());

            i++;
        }

        return string.Join("", output);
    }

}
