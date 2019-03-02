namespace WarTestRules
{
    public class WarTest
    {
        public string fen
        {
            get
            {
                return board.fen;
            }
        }

        Board board;
        Moves moves;

        public WarTest(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            board = new Board(fen);
            moves = new Moves(board);
        }

        WarTest (Board board)
        {
            this.board = board;
            moves = new Moves(board);
        }

        public WarTest Move (string move)
        {
            FigureMoving fm = new FigureMoving(move);
            if (!moves.CanMove(fm))
                return this;
            Board nextBoard = board.Move(fm);
            WarTest nextWar = new WarTest(nextBoard);            
            return nextWar;
        }

        public char GetFigureAt (int x, int y)
        {            
            Square square = new Square(x, y);
            Figure figure = board.GetFigureAt(square);
            return figure == Figure.none ? '.' : (char)figure;
        }
    }    
}
