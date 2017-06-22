using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerGame
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;
        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            //First try
            //try
            //{
            //    return _path[pathStep];
            //}
            //catch(System.IndexOutOfRangeException)
            //{
            //    return null;
            //}

            //Secound try
            //if (pathStep < _path.Length)
            //{
            //    return _path[pathStep];
            //}
            //else
            //{
            //    return null;
            //}

            return (pathStep < _path.Length) ? (_path[pathStep]) : null;

        }
    }
}
