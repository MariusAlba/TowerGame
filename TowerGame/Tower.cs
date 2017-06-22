using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerGame
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders (Invader[] invaders)
        {
            //int index = 0;

            //while (index < invaders.Length)
            //{
            //    Invader invader = invaders[index];

            //    index ++;
            //}

            //for (int index = 0; index < invaders.Length; index ++)
            //{
            //    Invader invader = invaders[index];
            //}
            foreach(Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit an invader!");

                        if (invader.IsDead)
                        {
                            Console.WriteLine("Kill an invader!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at the missed an ivader.");
                    }
                    break; 
                }
            }
        }
    }
}
