using System.Collections.Generic;

namespace TheaterKata.Framework
{
    public class SeatFinder
    {
        private readonly Theater _theater;
        private readonly List<Seat> _booked;

        public SeatFinder(Theater theater) : this(theater, new List<Seat>())
        {
        }

        public SeatFinder(Theater theater, List<Seat> booked)
        {
            _theater = theater;
            _booked = booked;
        }

        public List<Seat> suggest(int partySize)
        {
            return null;
        }
    }
}
