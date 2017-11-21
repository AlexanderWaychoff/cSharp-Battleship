using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class SetUpShips
    {
        Player1 player1 = new Player1();
        Player2 player2 = new Player2();
        public void setUpShips()
        {
            player1.placeDestroyer();
        }
    }
}
