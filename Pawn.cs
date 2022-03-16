using System;

namespace Polish_Draughts {
	class Pawn {
		public string color { get; set; }
		public int[] Coordinates { get; set; }
		public bool IsCrowned;
        public Pawn(int row, int col, string c) {
            color = c;
            Coordinates = new int[2];
            Coordinates[0] = row;
            Coordinates[1] = col;
        }
        public bool CanMoveTo(int row,int col, ref Board board) {
            string oppositeMark = (color=="W")?"B":"W";
            if (row < 0 || col < 0 || row > board.size - 1 || col > board.size - 1)
                return false; 
            if (board.field[row,col] != null)
                return false;
            if (Math.Abs(Coordinates[0] - row) > 2 || Math.Abs(Coordinates[1] - col) > 2)
                return false; 
            if (Coordinates[0] == row || Coordinates[1] == col) 
                return false;
            if (Coordinates[1] < col) {
                if (Coordinates[0] - row == 2 && board.field[Coordinates[0] - 1, Coordinates[1] + 1]!=null)
                    if(board.field[Coordinates[0] - 1, Coordinates[1] + 1].color == oppositeMark)
                        return true;
                else if (Coordinates[0] - row == - 2 && board.field[Coordinates[0] + 1, Coordinates[1] + 1] != null)
                        if(board.field[Coordinates[0] + 1, Coordinates[1] + 1].color == oppositeMark)
                            return true; 
            }
            else if (Coordinates[1] > col ) {
                if (Coordinates[0] - row == 2 && board.field[Coordinates[0] - 1, Coordinates[1] - 1] != null)
                    if (board.field[Coordinates[0] - 1, Coordinates[1] - 1].color == oppositeMark)
                        return true;
                else if (Coordinates[0] - row == -2 && board.field[Coordinates[0] + 1, Coordinates[1] - 1] != null)
                        if (board.field[Coordinates[0] + 1, Coordinates[1] - 1].color == oppositeMark)
                            return true;
            }
            if (color == "B" && Coordinates[1] - col == -1) 
                return true; 
            else if (color == "W" && Coordinates[1] - col ==1)
                return true;
            return false;
		}
		public bool CanMove(ref Board board)
        {   if (CanMoveTo(Coordinates[0] - 1, Coordinates[1] - 1, ref board)) return true;
            if (CanMoveTo(Coordinates[0] - 2, Coordinates[1] - 2, ref board)) return true;
            if (CanMoveTo(Coordinates[0] + 1, Coordinates[1] - 1, ref board)) return true;
            if (CanMoveTo(Coordinates[0] + 2, Coordinates[1] - 2, ref board)) return true;
            if (CanMoveTo(Coordinates[0] - 1, Coordinates[1] + 1, ref board)) return true;
            if (CanMoveTo(Coordinates[0] - 2, Coordinates[1] + 2, ref board)) return true;
            if (CanMoveTo(Coordinates[0] + 1, Coordinates[1] + 1, ref board)) return true;
            if (CanMoveTo(Coordinates[0] + 2, Coordinates[1] + 2, ref board)) return true;
            return false;
        }
    }
}
