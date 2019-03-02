using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarTestRules
{
    class Moves
    {
        FigureMoving fm;
        Board board;

        public Moves (Board board)
        {
            this.board = board;
        }

        public bool CanMove (FigureMoving fm)
        {
            this.fm = fm;
            return
                CanMoveFrom() &&
                CanMoveTo();
        }

        bool CanMoveFrom()
        {
            return fm.from.OnBoard() &&
                    fm.figure.GetColor() == board.moveColor &&
                    board.GetFigureAt(fm.from) == fm.figure;
        }

        bool CanMoveTo()
        {
            return  fm.to.OnBoard() &&
                    board.GetFigureAt(fm.to).GetColor() != board.moveColor;
        }
    }
}
