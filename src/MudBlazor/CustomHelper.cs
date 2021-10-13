using System;
using System.Linq.Expressions;
using System.Reflection;

namespace MudBlazor
{
    public static class CustomHelper
    {
           public static PropertyInfo SBS_PropertyInfo<T2>(this Expression<T2> expression)
        {
            if (expression is null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            MemberExpression memberExpression = SBS_MemberExpression(expression);

            PropertyInfo propertyInfo = memberExpression.Member as PropertyInfo;
            if (propertyInfo == null)
            {
                throw new ArgumentException($"Expression not a Property: {expression}", nameof(expression));
            }

            MethodInfo getMethod = propertyInfo.GetGetMethod(true);
            if (getMethod is null)
            {
                throw new ArgumentException($"Expression has no GET method: {expression}", nameof(expression));
            }

            if (getMethod.IsStatic)
            {
                throw new ArgumentException($"Expression cannot be static: {expression}", nameof(expression));
            }

            if (memberExpression.Expression is null)
            {
                throw new ArgumentException($"Expression has no expression: {expression}", nameof(expression));
            }

            Type realType = memberExpression.Expression.Type;
            if (realType == null)
            {
                throw new ArgumentException($"Expression has no DeclaringType: {expression}", nameof(expression));
            }

            PropertyInfo realPropertyInfo = realType.GetProperty(propertyInfo.Name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (realPropertyInfo is null)
            {
                throw new ArgumentException($"Cannot get real property info: {expression}", nameof(expression));
            }

            return realPropertyInfo;
        }

        public static MemberExpression SBS_MemberExpression<T2>(this Expression<T2> expression)
        {
            if (expression.Body is MemberExpression memberExpression)
            {
                return memberExpression;
            }

            Expression op = ((UnaryExpression)expression.Body).Operand;
            return (MemberExpression)op;
        }
    }
}
