using System;
using System.Collections.Generic;

namespace TheaterKata.Framework.Domain
{
    public class TheaterProvider : ITheaterProvider
    {
        public IEnumerable<Theater> GetAllTheaters()
        {
            return new List<Theater> { Theater.BuildStandardTheater() };
        }
    }

    public interface ITheaterProvider
    {
        IEnumerable<Theater> GetAllTheaters();
    }
}
