using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerGame
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            int xDiff = X - x;
            int yDiff = Y - y;
            double xDiffSquared = Math.Pow(xDiff, 2);
            double yDiffSquared = Math.Pow(yDiff, 2);

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
        }

        public int DistanceTo(MapLocation location)
        {
            int xDiff = X - location.X;
            int yDiff = Y - location.Y;
            double xDiffSquared = Math.Pow(xDiff, 2);
            double yDiffSquared = Math.Pow(yDiff, 2);

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
        }
    }
}
