using System;
using NFluent;
using Xunit;
using TheaterKata.Framework;

namespace TheaterKata.Test
{
    public class TheaterTest
    {
        [Fact]
        public void Should_build_theater_from_file_topology()
        {
            var actual = new Theater();
            Check.That(actual).IsNotNull();
        }
    }
}
