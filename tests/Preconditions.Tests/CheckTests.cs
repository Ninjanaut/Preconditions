using System;
using System.Collections.Generic;
using Xunit;

namespace Ninjanaut.Preconditions.Tests
{
    public class CheckTests
    {
        public class NotNull
        {
            [Fact]
            public void Argument_with_value_returns_value()
            {
                // Arrange
                string value = "Foo";
                // Act
                var result = Check.NotNull(value);
                // Assert
                Assert.Equal(expected: value, actual: result);
            }

            [Fact]
            public void Null_argument_throws_exception()
            {
                // Arrange
                string value = null;
                // Act
                void act() => Check.NotNull(value);
                // Assert
                var exception = Assert.Throws<ArgumentNullException>(act);

            }
            [Fact]
            public void Null_argument_throws_exception_with_param_name()
            {
                // Arrange
                string value = null;
                string paramName = nameof(value);
                // Act
                void act() => Check.NotNull(value, paramName);
                // Assert
                var exception = Assert.Throws<ArgumentNullException>(paramName, act);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
            }

            [Fact]
            public void Null_argument_throws_exception_with_param_name_and_custom_message()
            {
                // Arrange
                string value = null;
                string paramName = nameof(value);
                string message = "Foo";
                // Act
                void act() => Check.NotNull(value, paramName, message);
                // Assert
                var exception = Assert.Throws<ArgumentNullException>(paramName, act);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
                Assert.Equal(expected: "Foo (Parameter 'value')", actual: exception.Message);
            }
        }

        public class Require
        {
            [Fact]
            public void True_condition_does_not_throw_exception()
            {
                // Arrange
                bool condition = true;
                // Act
                void act() => Check.Require(condition);
                // Assert
                var exception = Record.Exception(act);
                Assert.Null(exception);
            }

            [Fact]
            public void False_condition_throws_exception()
            {
                // Arrange
                bool condition = false;
                // Act
                void act() => Check.Require(condition);
                // Assert
                var exception = Assert.Throws<ArgumentException>(act);
            }

            [Fact]
            public void False_condition_throws_exception_with_custom_message()
            {
                // Arrange
                bool condition = false;
                string message = "Foo";
                // Act
                void act() => Check.Require(condition, message);
                // Assert
                var exception = Assert.Throws<ArgumentException>(act);
                Assert.Equal(expected: message, actual: exception.Message);
            }

            [Fact]
            public void False_condition_throws_exception_with_custom_message_and_param_name()
            {
                // Arrange
                bool condition = false;
                string message = "Foo";
                string paramName = "Bar";
                // Act
                void act() => Check.Require(condition, message, paramName);
                // Assert
                var exception = Assert.Throws<ArgumentException>(paramName, act);
                Assert.Equal(expected: "Foo (Parameter 'Bar')", actual: exception.Message);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
            }
        }

        public class NotNullOrEmpty
        {
            [Fact]
            public void Valid_argument_returns_value()
            {
                // Arrange
                string value = "Foo";
                // Act
                var result = Check.NotNullOrEmpty(value);
                // Assert
                Assert.Equal(expected: value, actual: result);
            }

            [Fact]
            public void Null_argument_throws_exception()
            {
                // Arrange
                string value = null;
                // Act
                void act() => Check.NotNullOrEmpty(value);
                // Assert
                var exception = Assert.Throws<ArgumentNullException>(act);
            }

            [Fact]
            public void Null_argument_throws_exception_with_param_name()
            {
                // Arrange
                string value = null;
                string paramName = nameof(value);
                // Act
                void act() => Check.NotNullOrEmpty(value, paramName);
                // Assert
                var exception = Assert.Throws<ArgumentNullException>(paramName, act);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
            }

            [Fact]
            public void Null_argument_throws_exception_with_param_name_and_custom_message()
            {
                // Arrange
                string value = null;
                string paramName = nameof(value);
                string message = "Foo";
                // Act
                void act() => Check.NotNullOrEmpty(value, paramName, message);
                // Assert
                var exception = Assert.Throws<ArgumentNullException>(paramName, act);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
                Assert.Equal(expected: "Foo (Parameter 'value')", actual: exception.Message);
            }

            [Fact]
            public void Empty_argument_throws_exception()
            {
                // Arrange
                string value = string.Empty;
                // Act
                void act() => Check.NotNullOrEmpty(value);
                // Assert
                var exception = Assert.Throws<ArgumentException>(act);
            }

            [Fact]
            public void Empty_argument_throws_exception_with_param_name()
            {
                // Arrange
                string value = string.Empty;
                string paramName = nameof(value);
                // Act
                void act() => Check.NotNullOrEmpty(value, paramName);
                // Assert
                var exception = Assert.Throws<ArgumentException>(paramName, act);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
            }

            [Fact]
            public void Empty_argument_throws_exception_with_param_name_and_custom_message()
            {
                // Arrange
                string value = string.Empty;
                string paramName = nameof(value);
                string message = "Foo";
                // Act
                void act() => Check.NotNullOrEmpty(value, paramName, message);
                // Assert
                var exception = Assert.Throws<ArgumentException>(paramName, act);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
                Assert.Equal(expected: "Foo (Parameter 'value')", actual: exception.Message);
            }
        }

        public class NotNullOrEmptyOnCollection
        {
            [Fact]
            public void Valid_argument_returns_value()
            {
                // Arrange
                var value = new List<string>() { "Foo", "Bar" };
                // Act
                var result = Check.NotNullOrEmpty(value);
                // Assert
                Assert.Equal(expected: value, actual: result);
            }

            [Fact]
            public void Null_argument_throws_exception()
            {
                // Arrange
                List<string> value = null;
                // Act
                void act() => Check.NotNullOrEmpty(value);
                // Assert
                var exception = Assert.Throws<ArgumentNullException>(act);
            }

            [Fact]
            public void Null_argument_throws_exception_with_param_name()
            {
                // Arrange
                List<string> value = null;
                string paramName = nameof(value);
                // Act
                void act() => Check.NotNullOrEmpty(value, paramName);
                // Assert
                var exception = Assert.Throws<ArgumentNullException>(paramName, act);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
            }

            [Fact]
            public void Null_argument_throws_exception_with_param_name_and_custom_message()
            {
                // Arrange
                List<string> value = null;
                string paramName = nameof(value);
                string message = "Foo";
                // Act
                void act() => Check.NotNullOrEmpty(value, paramName, message);
                // Assert
                var exception = Assert.Throws<ArgumentNullException>(paramName, act);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
                Assert.Equal(expected: "Foo (Parameter 'value')", actual: exception.Message);
            }

            [Fact]
            public void Empty_argument_throws_exception()
            {
                // Arrange
                var value = new List<string>();
                // Act
                void act() => Check.NotNullOrEmpty(value);
                // Assert
                var exception = Assert.Throws<ArgumentException>(act);
            }

            [Fact]
            public void Empty_argument_throws_exception_with_param_name()
            {
                // Arrange
                var value = new List<string>();
                string paramName = nameof(value);
                // Act
                void act() => Check.NotNullOrEmpty(value, paramName);
                // Assert
                var exception = Assert.Throws<ArgumentException>(paramName, act);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
            }

            [Fact]
            public void Empty_argument_throws_exception_with_param_name_and_custom_message()
            {
                // Arrange
                var value = new List<string>();
                string paramName = nameof(value);
                string message = "Foo";
                // Act
                void act() => Check.NotNullOrEmpty(value, paramName, message);
                // Assert
                var exception = Assert.Throws<ArgumentException>(paramName, act);
                Assert.Equal(expected: paramName, actual: exception.ParamName);
                Assert.Equal(expected: "Foo (Parameter 'value')", actual: exception.Message);
            }
        }
    }
}
