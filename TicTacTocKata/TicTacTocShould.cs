using System;
using System.Collections.Generic;
using Xunit;
using static TicTacTocKata.TicTacToc;

namespace TicTacTocKata
{
    public class TicTacTocShould
    {
        [Fact]
        public void BeStatusIncomplete()
        {
            //Arrange
            var turns = new int[]
            {
                1, 0
            };

            //Act
            var result = new TicTacToc().Process(turns);

            //Assert
            Assert.Equal(expected: TicTacToc.StatusTiTacToc.incomplete, actual: result);
        }

        [Fact]
        public void BeStatusDrawInLastTurn()
        {
            //Arrange
            var ticTacToc = new TicTacToc();
            var turns = new int[]
            {
                1, 0
            };

            ticTacToc.SetTurnCount(8);

            //Act
            var result = ticTacToc.Process(turns);

            //Assert
            Assert.Equal(expected: StatusTiTacToc.draw, actual: result);
        }

        [Fact]
        public void BeStatuIncompleteInEigthsTurns() { 
            //Arrange
            var ticTacToc = new TicTacToc();
            var turns = new int[]
            {
                1, 0
            };

            ticTacToc.SetTurnCount(8);

            //Act
            var result = ticTacToc.Process(turns);

            //Assert
            Assert.Equal(expected: StatusTiTacToc.draw, actual: result);
        }

    }

    
}
