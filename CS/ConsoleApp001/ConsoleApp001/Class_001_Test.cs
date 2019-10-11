﻿using Xunit;
using System;

namespace ConsoleApp001
{
    public class Class_001_Test
    {
        [Theory]
        [InlineData(new[] { 2, 3, 5, 6, 10, 12, 3 }, 11, new[] { 2, 3 })]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        public void TestName(int[] input, int target, int[] output)
        {
            Assert.Equal(output, Class_001.TwoSum_01(input, target));
        }
    }
}
