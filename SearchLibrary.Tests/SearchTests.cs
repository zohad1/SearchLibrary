using NUnit.Framework;
using SearchLibrary;

namespace SearchLibrary.Tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        private BinarySearch _bs;

        [SetUp]
        public void Setup() => _bs = new BinarySearch();

        [Test]
        public void T1_KeyFoundAtMiddle_ReturnsIndex()
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            Assert.That(_bs.Search(5, arr), Is.EqualTo(2));
        }

        [Test]
        public void T2_KeyFoundSingleElement_ReturnsZero()
        {
            int[] arr = { 5 };
            Assert.That(_bs.Search(5, arr), Is.EqualTo(0));
        }

        [Test]
        public void T3_KeyNotFound_ReturnsNegOne()
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            Assert.That(_bs.Search(4, arr), Is.EqualTo(-1));
        }

        [Test]
        public void T4_EmptyArray_ReturnsNegOne()
        {
            int[] arr = { };
            Assert.That(_bs.Search(1, arr), Is.EqualTo(-1));
        }

        [Test]
        public void T5_KeyGreaterThanMid_SearchesUpperHalf()
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            Assert.That(_bs.Search(8, arr), Is.EqualTo(3));
        }

        [Test]
        public void T6_KeyLessThanMid_SearchesLowerHalf()
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            Assert.That(_bs.Search(2, arr), Is.EqualTo(0));
        }
    }

    [TestFixture]
    public class LinearSearchTests
    {
        private LinearSearch _ls;

        [SetUp]
        public void Setup() => _ls = new LinearSearch();


        [Test]
        public void L1_KeyFound_ReturnsIndex()
        {
            int[] arr = { 10, 20, 30, 40 };
            Assert.That(_ls.Search(30, arr), Is.EqualTo(2));
        }

        [Test]
        public void L2_KeyNotFound_ReturnsNegOne()
        {
            int[] arr = { 10, 20, 30, 40 };
            Assert.That(_ls.Search(99, arr), Is.EqualTo(-1));
        }

        [Test]
        public void L3_KeyAtLastIndex_ReturnsLastIndex()
        {
            int[] arr = { 5, 10 };
            Assert.That(_ls.Search(10, arr), Is.EqualTo(1));
        }

        [Test]
        public void L4_EmptyArray_ReturnsNegOne()
        {
            int[] arr = { };
            Assert.That(_ls.Search(5, arr), Is.EqualTo(-1));
        }
    }

    [TestFixture]
    public class InterpolationSearchTests
    {
        private InterpolationSearch _is;

        [SetUp]
        public void Setup() => _is = new InterpolationSearch();


        [Test]
        public void I1_KeyFound_ReturnsIndex()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Assert.That(_is.Search(30, arr), Is.EqualTo(2));
        }

        [Test]
        public void I3_KeyNotFound_ReturnsNegOne()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Assert.That(_is.Search(35, arr), Is.EqualTo(-1));
        }

        [Test]
        public void I4_EmptyArray_ReturnsNegOne()
        {
            int[] arr = { };
            Assert.That(_is.Search(5, arr), Is.EqualTo(-1));
        }

        [Test]
        public void I5_KeyBelowRange_ReturnsNegOne()
        {
            int[] arr = { 10, 20, 30 };
            Assert.That(_is.Search(5, arr), Is.EqualTo(-1));
        }

        [Test]
        public void I6_KeyEqualsLow_ReturnsZero()
        {
            int[] arr = { 10, 20, 30 };
            Assert.That(_is.Search(10, arr), Is.EqualTo(0));
        }

        [Test]
        public void I7_KeyAboveRange_ReturnsNegOne()
        {
            int[] arr = { 10, 20, 30 };
            Assert.That(_is.Search(99, arr), Is.EqualTo(-1));
        }

        [Test]
        public void I8_KeyEqualsHigh_ReturnsLastIndex()
        {
            int[] arr = { 10, 20, 30 };
            Assert.That(_is.Search(30, arr), Is.EqualTo(2));
        }

        [Test]
        public void I9_AllEqualElements_KeyMatches_ReturnsZero()
        {
            int[] arr = { 5, 5, 5, 5 };
            Assert.That(_is.Search(5, arr), Is.EqualTo(0));
        }
    }
}