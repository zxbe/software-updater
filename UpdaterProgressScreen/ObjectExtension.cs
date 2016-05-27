using System;
using System.Linq.Expressions;

namespace Com.QueoFlow.Commons {
    /// <summary>
    ///   Hilfsklasse zur Ermittlung des Namens eines Properties einer Klasse per Lambda-Ausdruck.
    /// </summary>
    public static class ObjectExtension {
        /// <summary>
        ///   Ruft den Namen eines Properties per Lambdaausdruck ab. Bsp this.GetPropertyName(m=>m.Property)
        /// </summary>
        /// <typeparam name="T"> </typeparam>
        /// <typeparam name="TProp"> </typeparam>
        /// <param name="obj"> </param>
        /// <param name="expression"> </param>
        /// <returns> </returns>
        public static string GetPropertyName<T, TProp>(this T obj, Expression<Func<T, TProp>> expression) {
            if (expression == null) {
                throw new ArgumentNullException("expression");
            }

            MemberExpression body = expression.Body as MemberExpression;
            if (body == null) {
                throw new ArgumentException("'expression' should be a member expression");
            }

            return body.Member.Name;
        }
    }
}