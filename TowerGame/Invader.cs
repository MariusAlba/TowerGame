using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerGame;

namespace TowerGame
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        
        //private MapLocation _location;

        //public MapLocation GetLocation()
        //{
        //    return _location;
        //}
        //public void SetLocation(MapLocation value)
        //{
        //    _location = value;
        //}
        
            //Syntactic sugar
        public MapLocation Location => _path.GetLocationAt(_pathStep); //{ get; private set; }

        public int enemyHealth { get; private set; } = 2;

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsDead => enemyHealth <= 0;

        public bool IsActive => !(IsDead || HasScored);
        //{
        //    get
        //    {
        //        return _path.GetLocationAt(_pathStep);
        //    }
        //}
        public Invader (Path path)
        {
            _path = path;
           // Location = _path.GetLocationAt(_pathStep);
        }
        public void Move () => _pathStep += 1;
        
        public void DecreaseHealth( int factor )
        {
             enemyHealth -= factor;
        }  
    }
}
