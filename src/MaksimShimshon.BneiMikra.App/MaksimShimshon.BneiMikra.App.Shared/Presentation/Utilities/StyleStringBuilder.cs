namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Utilities;
internal static class StyleStringBuilder
{
    public class StyleBuilder
    {
        private Dictionary<string, string> _style = new();
        public StyleBuilder Add(string property, string value)
        {
            _style[property] = value;
            return this;
        }
        public StyleBuilder Remove(string property, string value)
        {
            _style.Remove(property);
            return this;
        }
        public override string ToString()
        {
            var style = string.Join(";", _style.Select(kv => $"{kv.Key}:{kv.Value}"));
            if (!string.IsNullOrWhiteSpace(style)) style += ";";
            return style;
        }
    }
    public static StyleBuilder CreateStyle() => new();

}
