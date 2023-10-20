using System.Linq.Expressions;

namespace ASiNet.Expressions.Extensions;
public class DictionaryExpressionHelper
{
    public static Expression New(Type key, Type value) =>
        Expression.New(typeof(Dictionary<,>).MakeGenericType(key, value));

    public static Expression New(Type key, Type value, Expression capasity) =>
        Expression.New(typeof(Dictionary<,>).MakeGenericType(key, value).GetConstructor(new[] { typeof(int) })!, capasity);

    public static Expression Add(Expression instance, Expression key, Expression value) =>
        Expression.Call(instance, nameof(Dictionary<byte, byte>.Add), null, key, value);

    public static Expression TryAdd(Expression instance, Expression key, Expression value) =>
        Expression.Call(instance, nameof(Dictionary<byte, byte>.TryAdd), null, key, value);

    public static Expression TryGetValue(Expression instance, Expression key, Expression outValue) =>
        Expression.Call(instance, nameof(Dictionary<byte, byte>.TryGetValue), null, key, outValue);

    public static Expression Remove(Expression instance, Expression key) =>
        Expression.Call(instance, nameof(Dictionary<byte, byte>.Remove), null, key);

    public static Expression Remove(Expression instance, Expression key, Expression outValue) =>
        Expression.Call(instance, nameof(Dictionary<byte, byte>.Remove), null, key, outValue);

    public static Expression ContainsKey(Expression instance, Expression key) =>
        Expression.Call(instance, nameof(Dictionary<byte, byte>.ContainsKey), null, key);

    public static Expression ContainsValue(Expression instance, Expression value) =>
        Expression.Call(instance, nameof(Dictionary<byte, byte>.ContainsKey), null, value);

    public static Expression Clear(Expression instance) =>
        Expression.Call(instance, nameof(Dictionary<byte, byte>.Clear), null);

    public static Expression Count(Expression instance) =>
        Expression.Property(instance, nameof(Dictionary<byte, byte>.Count), null);
}
