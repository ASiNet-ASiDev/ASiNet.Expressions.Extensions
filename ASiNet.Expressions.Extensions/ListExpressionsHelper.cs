using System.Linq.Expressions;

namespace ASiNet.Expressions.Extensions;

public static class ListExpressionsHelper
{
    public static Expression New(Type listType) =>
        Expression.New(typeof(List<>).MakeGenericType(listType));

    public static Expression New(Type listType, Expression capasity) =>
        Expression.New(typeof(List<>).MakeGenericType(listType).GetConstructor(new[] { typeof(int) })!, capasity);

    public static Expression Add(Expression list, Expression value) =>
        Expression.Call(list, nameof(List<byte>.Add), null, value);

    public static Expression Remove(Expression list, Expression value) =>
        Expression.Call(list, nameof(List<byte>.Remove), null, value);

    public static Expression RemoveAt(Expression list, Expression index) =>
        Expression.Call(list, nameof(List<byte>.RemoveAt), null, index);

    public static Expression IndexOf(Expression list, Expression item) =>
        Expression.Call(list, nameof(List<byte>.IndexOf), null, item);

    public static Expression RemoveRange(Expression list, Expression start, Expression end) =>
        Expression.Call(list, nameof(List<byte>.RemoveRange), null, start, end);

    public static Expression Insert(Expression list, Expression index, Expression item) =>
        Expression.Call(list, nameof(List<byte>.Insert), null, index, item);

    public static Expression ToArray(Expression list) =>
        Expression.Call(list, nameof(List<byte>.ToArray), null);

    public static Expression Clear(Expression list) =>
        Expression.Call(list, nameof(List<byte>.Clear), null);

    public static Expression Count(Expression list) =>
        Expression.Property(list, nameof(List<byte>.Count), null);

    public static Expression GetItem(Expression list, Expression index) =>
        Expression.Call(list, "get_item", null, index);
}
