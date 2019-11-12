using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacTocKata
{
    public class TicTacToc
    {
        public enum StatusTiTacToc
        {
            incomplete = 0,
            win = 1,
            draw = 2

        }

        private int CountTurns { get; set; }

        public int GetCountTurn()
        {
            return CountTurns;
        }

        public void SetTurnCount(int turnCount)
        {
            CountTurns = turnCount;
        }

        public StatusTiTacToc Process(int[] turns)
        {
            CountTurns++;

            // Conta les tirades
            if (CountTurns == 9)
            {
                return StatusTiTacToc.draw;
            }

            // si la 9 draw
            return StatusTiTacToc.incomplete;
        }
    }
}
