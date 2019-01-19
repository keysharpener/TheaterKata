using System.Collections.Generic;

namespace TheaterKata.Framework
{
    public class Theater
    {
        public List<string> Rows { get; set; }
        public IDictionary<string, List<int>> Seats { get; set; }

        public Theater(List<string> rows, IDictionary<string, List<int>> seats)
        {
            Rows = rows;
            Seats = seats;
        }

        public static Theater standardTheater()
        {
            List<string> rows = new List<string> { "A", "B", "C", "D", "E", "F", "G" };
            Dictionary<string, List<int>> seats = new Dictionary<string, List<int>>
            {
                ["A"] = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                ["B"] = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                ["C"] = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                ["D"] = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                ["E"] = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                ["F"] = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                ["G"] = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
            };
            return new Theater(rows, seats);
        }
    }
}
