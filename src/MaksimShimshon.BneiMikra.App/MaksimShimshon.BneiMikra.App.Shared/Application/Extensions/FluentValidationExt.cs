using FluentValidation;
using System.Linq.Expressions;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Extensions;
internal static class FluentValidationExt
{
    public static IRuleBuilderOptions<T, TProperty> WithPropertizedMessage<T, TProperty>(this IRuleBuilderOptions<T, TProperty> rule, string message, params Expression<Func<T, object?>>[] properties)
    {
        return rule.WithMessage(string.Format(message, properties.Select(p => p.GetPropetyName()).ToArray()));
    }
    public static IRuleBuilderOptions<T, TProperty> WithFormatMessage<T, TProperty>(this IRuleBuilderOptions<T, TProperty> rule, string message, params string[] properties)
    {
        return rule.WithMessage(string.Format(message, properties));
    }



}
