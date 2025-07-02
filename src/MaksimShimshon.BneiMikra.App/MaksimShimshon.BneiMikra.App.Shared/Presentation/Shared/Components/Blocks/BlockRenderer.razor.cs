using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components.Blocks;
public partial class BlockRenderer
{
    [Parameter]
    public ICollection<BlockComponent> Blocks { get; set; } = default!;
    private List<RenderFragment> Fragments { get; set; } = new();
    public static RenderFragment Render(Type component, IReadOnlyDictionary<string, object?> parameters)
    => (treeBuilder) =>
    {
        treeBuilder.OpenComponent(0, component);
        var index = 1;
        foreach (var item in parameters)
        {
            treeBuilder.AddComponentParameter(index, item.Key, item.Value);
            index++;
        }
        treeBuilder.CloseComponent();
    };

    protected override void OnInitialized()
    {

        Fragments = Blocks
            .SkipWhile(p => Map.ContainsKey(p.Component))
            .Select(p => Render(Map[p.Component], p.Paramaters))
            .ToList();
    }

    private Dictionary<string, Type> Map { get; set; } = new()
    {
        ["MarkdownComponent"] = typeof(BlockMarkdown),
        ["QuotationComponent"] = typeof(BlockQuotation)
    };
}
