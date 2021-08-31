using System;
using System.Collections.Generic;

namespace Ninjanaut.Preconditions
{
    public static class Check
    {
        /// <summary>
        /// Ensures that an expression is true, otherwise throws an ArgumentException.
        /// </summary>
        /// <param name="expression"> Condition that has to be true. </param>
        /// <param name="paramName"> The name of the parameter that caused the current exception. </param>
        /// <param name="message"> The error message that explains the reason for the exception. </param>
        /// <exception cref="ArgumentException"></exception>
        public static void Require(bool expression, string message = null, string paramName = null)
        {
            if (expression == false)
            {
                throw new ArgumentException(message, paramName);
            }
        }

        /// <summary>
        /// Ensures that an argument is not null, otherwise throws an ArgumentException.
        /// </summary>
        /// <param name="value"> Argument to test </param>
        /// <param name="paramName"> The name of the parameter that caused the current exception. </param>
        /// <param name="message"> The error message that explains the reason for the exception. </param>
        /// <returns> Value argument. </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T NotNull<T>(T value, string paramName = null, string message = null)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName, message);
            }
            return value;
        }

        /// <summary>
        /// Ensures that an argument is not null and is not empty, otherwise throws an ArgumentNullException or ArgumentException.
        /// </summary>
        /// <param name="value"> Argument to test </param>
        /// <param name="paramName"> The name of the parameter that caused the current exception. </param>
        /// <param name="message"> The error message that explains the reason for the exception. </param>
        /// <returns> Value argument. </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static string NotNullOrEmpty(string value, string paramName = null, string message = null)
        {
            NotNull(value, paramName, message);
            
            if (value == string.Empty)
            {
                throw new ArgumentException(message, paramName);
            }

            return value;
        }

        /// <summary>
        /// Ensures that an argument is not null and is not empty, otherwise throws an ArgumentNullException or ArgumentException.
        /// </summary>
        /// <param name="value"> Argument to test </param>
        /// <param name="paramName"> The name of the parameter that caused the current exception. </param>
        /// <param name="message"> The error message that explains the reason for the exception. </param>
        /// <returns> Value argument. </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static IList<T> NotNullOrEmpty<T>(IList<T> value, string paramName = null, string message = null)
        {
            NotNull(value, paramName, message);

            if (value.Count == 0)
            {
                throw new ArgumentException(message, paramName);
            }

            return value;
        }
    }
}
