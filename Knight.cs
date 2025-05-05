using ChessProject;

namespace ChessProject2025;

internal class Knight : Figure
{
    public override void MoveFigure(FigureColor fColor, FigureType fType, Coordinates point1, Coordinates point2, ChessBoard ch)
    {
        ChessBoard board = new ChessBoard();
        string[,] chessBoard = new string[8, 8];
        int startRow = point1.GetRowIndex();
        int startCol = point1.GetColumnIndex();
        int endRow = point2.GetRowIndex();
        int endCol = point2.GetColumnIndex();


        int horizontalShiftx = Math.Abs(endCol - startCol);
        int verticalShift = Math.Abs(endRow - startRow);


        bool isKnightMove = (horizontalShiftx == 2 && verticalShift == 1) || (horizontalShiftx == 1 && verticalShift == 2);

        if (isKnightMove)
        {
            //board.PlaceMarker(chessBoard, point1, " X");
            //board.PlaceMarker(chessBoard, point2, " X");
            //int minY = Math.Min(startRow, endRow);
            //int maxY = Math.Max(startRow, endRow);
            //for (int row = minY + 1; row < maxY; row++)
            //{

            //    chessBoard[row, startCol] = "■";
            //}

            //int minX = Math.Min(startCol, endCol);
            //int maxX = Math.Max(startCol, endCol);
            //for (int col = minX + 1; col < maxX; col++)
            //{
            //    chessBoard[startRow, col] = "■";

            //}

            int[] dx = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };
            int count = 0;
            for (int i = 0; i < 8; i++)
            {
                int newRow = startRow + dy[i];
                int newCol = startCol + dx[i];

                if (newRow >= 0 && newRow < 8 && newCol >= 0 && newCol < 8)
                {
                    count++;


                }
            }
            Console.WriteLine($"Number of knight moves in chess {count} ");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid move for the knight!");
            Console.ResetColor();
        }

        board.DrawBoard(chessBoard, fColor, fType, point1, point2);
    }

}