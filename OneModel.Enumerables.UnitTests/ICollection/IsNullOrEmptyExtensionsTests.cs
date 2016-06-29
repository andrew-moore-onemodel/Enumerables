﻿using System.Collections.Generic;
using OneModel.Enumerables.ICollection;
using Xunit;

namespace OneModel.Enumerables.UnitTests.ICollection
{
    public class IsNullOrEmptyExtensionsTests
    {
        [Fact]
        public void Returns_True_For_Null_Enumerable()
        {
            var nullEnumerable = GetNullEnumerable<int>();

            var actual = nullEnumerable.IsNullOrEmpty();

            Assert.Equal(true, actual);
        }

        [Fact]
        public void Returns_True_For_Empty_Enumerable()
        {
            ICollection<int> emptyEnumerable = new List<int>();

            var actual = emptyEnumerable.IsNullOrEmpty();

            Assert.Equal(true, actual);
        }
        
        [Fact]
        public void Returns_False_For_Enumerable_With_Elements()
        {
            ICollection<int> nonEmptyNonNullEnumerable = new List<int> { 1, 2, 3 };

            var actual = nonEmptyNonNullEnumerable.IsNullOrEmpty();

            Assert.Equal(false, actual);
        }

        private ICollection<T> GetNullEnumerable<T>()
        {
            return null;
        }
    }
}
