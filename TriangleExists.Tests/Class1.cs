using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Testing_3__NUnit_;

namespace TriangleExists.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Triangle_5_10_8_ExistsTrue()
        {
            int a = 5, b = 10, c = 8;

            TriangleExistsClass te = new TriangleExistsClass();
            bool result = te.TriangleExists(a, b, c);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void Triangle_5_10_20_ExistsFalse()
        {
            int a = 5, b = 10, c = 20;

            TriangleExistsClass te = new TriangleExistsClass();
            bool result = te.TriangleExists(a, b, c);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Triangle_of_one_minus_side_ExistsFalse()
        {
            int a = -5, b = 4, c = 3;

            TriangleExistsClass te = new TriangleExistsClass();
            bool result = te.TriangleExists(a, b, c);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Triangle_of_minus_sides_ExistsFalse()
        {
            int a = -1, b = 0, c = 0;

            TriangleExistsClass te = new TriangleExistsClass();
            bool result = te.TriangleExists(a, b, c);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Triangle_of_two_equal_sides_ExistsTrue()
        {
            int a = 5, b = 5, c = 6;

            TriangleExistsClass te = new TriangleExistsClass();
            bool result = te.TriangleExists(a, b, c);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void Triangle_of_equal_sides_ExistsTrue()
        {
            int a = 2, b = 2, c = 2;

            TriangleExistsClass te = new TriangleExistsClass();
            bool result = te.TriangleExists(a, b, c);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void Triangle_of_zero_sides_ExistsFalse()
        {
            int a = 0, b = 0, c = 0;

            TriangleExistsClass te = new TriangleExistsClass();
            bool result = te.TriangleExists(a, b, c);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Triangle_of_one_zero_side_ExistsFalse()
        {
            int a = 5, b = 4, c = 0;

            TriangleExistsClass te = new TriangleExistsClass();
            bool result = te.TriangleExists(a, b, c);

            Assert.AreEqual(false, result);
        }


        [Test]
        public void Triangle_of_double_sides_ExistsTrue()
        {
            double a = 5.4, b = 4.1, c = 8.91;

            TriangleExistsClass te = new TriangleExistsClass();
            bool result = te.TriangleExists(a, b, c);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void Triangle_of_sum_of_2_sides_equals_3rd_ExistsFalse()
        {
            int a = 5, b = 6, c = 11;

            TriangleExistsClass te = new TriangleExistsClass();
            bool result = te.TriangleExists(a, b, c);

            Assert.AreEqual(false, result);
        }
    }
}
