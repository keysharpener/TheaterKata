using System;

namespace TheaterKata.Framework
{
    public class Seat
    {
        public string Row { get; }
        public int SeatNumber { get; }

        public Seat(string row, int seatNumber)
        {
            Row = row;
            SeatNumber = seatNumber;
        }

        public Seat(string seatString) : this(seatString.Substring(0, 1), Convert.ToInt32(seatString.Substring(1)))
        {
        }

        public override string ToString()
        {
            return Row + SeatNumber;
        }
    }
}
