﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class ShipPlacementBoard : Board
    {
        Ships destroyer = new Ships("Destroyer", 2);
        public void shipPlacementBoard()
        {

        }

        internal void PlaceDestroyer(string destroyerVH, string destroyerLetterPlacement, string destroyerNumberPlacement)
        {
            int letterPlacement = Convert.ToInt32(destroyerLetterPlacement);
        }
    }
}
