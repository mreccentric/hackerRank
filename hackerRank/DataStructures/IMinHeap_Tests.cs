﻿using System;
using FluentAssertions;
using NUnit.Framework;

namespace hackerRank
{
    internal abstract class IMinHeap_Tests<THeap> where THeap : IMinHeap
    {
        protected abstract THeap CreateHeap();

        [Test]
        public void Test_ManyElements()
        {
            var heap = CreateHeap();
            for (int i = 1000; i >= 0; i--)
            {
                heap.Add(i);
                heap.GetMin().Should().Be(i);
            }
            for (int i = 0; i <=1000; i++)
            {
                heap.GetMin().Should().Be(i);
                Console.Out.WriteLine($"Deletint element {i}");
                heap.Delete(i);
            }
        }

        [Test]
        public void Test()
        {
            var heap = CreateHeap();

            heap.Add(5);
            heap.GetMin().Should().Be(5);

            heap.Add(10);
            heap.GetMin().Should().Be(5);

            heap.Delete(5);
            heap.GetMin().Should().Be(10);

            heap.Add(5);
            heap.GetMin().Should().Be(5);

            heap.Add(4);
            heap.Add(6);
            heap.Add(2);
            heap.GetMin().Should().Be(2);
        }

        [Test]
        public void Test_DeleteAll()
        {
            var heap = CreateHeap();

            heap.Add(5);
            heap.Add(10);
            heap.GetMin().Should().Be(5);

            heap.Delete(5);
            heap.Delete(10);

            heap.Add(5);
            heap.Add(10);
            heap.GetMin().Should().Be(5);
        }

        [Test]
        public void Test_NegativeNumbers()
        {
            var heap = CreateHeap();

            heap.Add(5);
            heap.Add(10);
            heap.Add(-10);
            heap.GetMin().Should().Be(-10);

            heap.Add(6);
            heap.Add(11);
            heap.GetMin().Should().Be(-10);
        }

        [Test]
        public void Test_DecreaseKey1()
        {
            var heap = CreateHeap();

            heap.Add(5);
            heap.Add(10);
            heap.GetMin().Should().Be(5);

            heap.DecreaseKey(10, 4);
            heap.GetMin().Should().Be(4);

            heap.Add(6);
            heap.Add(7);
            heap.GetMin().Should().Be(4);

            heap.DecreaseKey(5, 1);
            heap.GetMin().Should().Be(1);

            heap.Delete(1);
            heap.GetMin().Should().Be(4);
        }
    }
}