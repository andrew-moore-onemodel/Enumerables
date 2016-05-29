﻿using System.Collections.Generic;
using Xunit;

namespace OneModel.Enumerables.UnitTests.IEnumerable
{
    public class PermuteExtensionsTests
    {
        [Theory, MemberData(nameof(TestData))]
        public void Returns_Expected_Result(int[][] input, int[][] expected)
        {
            var actual = input.Permute();

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> TestData => new[]
        {
            new object[]
            {
                new[] { new[] { 1 } },
                new[] { new[] { 1 } }
            },

            new object[]
            {
                new[] { new[] { 1, 2 } },
                new[] { new[] { 1 }, new[] { 2 } }
            },

            new object[]
            {
                new[] { new[] { 1, 2, 3 } },
                new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }
            },

            new object[]
            {
                new[] { new[] { 1 }, new[] { 2 } },
                new[] { new[] { 1, 2 } }
            },

            new object[]
            {
                new[] { new[] { 0, 1 }, new[] { 2, 3 } },
                new[] { new[] { 0, 2 }, new[] { 0, 3 }, new[] { 1, 2 }, new[] { 1, 3 } }
            },

            new object[]
            {
                new[] { new[] { 0, 1 }, new[] { 2 }, new[] { 3, 4 }, new[] { 5 } },
                new[]
                {
                    new[] { 0, 2, 3, 5 },
                    new[] { 0, 2, 4, 5 },
                    new[] { 1, 2, 3, 5 },
                    new[] { 1, 2, 4, 5 }
                }
            }
        };
    }
}
