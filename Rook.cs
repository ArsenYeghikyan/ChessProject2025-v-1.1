namespace ChessProject;

internal class Rook : Figure
{

    public override void MoveFigure(FigureColor fColor, FigureType fType, Coordinates point1, Coordinates point2, ChessBoard ch)
    {
        ChessBoard board = new ChessBoard();
        string[,] chessBoard = new string[8, 8];

        board.PlaceMarker(chessBoard, point1, "X");
        board.PlaceMarker(chessBoard, point2, "X");

        int startRow = point1.GetRowIndex();
        int startCol = point1.GetColumnIndex();
        int endRow = point2.GetRowIndex();
        int endCol = point2.GetColumnIndex();


        if (startCol == endCol)
        {
            int min = Math.Min(startRow, endRow);
            int max = Math.Max(startRow, endRow);
            for (int row = min + 1; row < max; row++)
            {
                chessBoard[row, startCol] = "■";
            }
        }
        else if (startRow == endRow)
        {
            int min = Math.Min(startCol, endCol);
            int max = Math.Max(startCol, endCol);
            for (int col = min + 1; col < max; col++)
            {
                chessBoard[startRow, col] = "■";
            }
        }
        //else
        //{
        //    int minY = Math.Min(startRow, endRow);
        //    int maxY = Math.Max(startRow, endRow);
        //    for (int row = minY + 1; row < maxY; row++)
        //    {
        //        chessBoard[row, startCol] = "■";
        //    }

        //    int minX = Math.Min(startCol, endCol);
        //    int maxX = Math.Max(startCol, endCol);
        //    for (int col = minX + 1; col < maxX; col++)
        //    {
        //        chessBoard[endRow, col] = "■";
        //    }
        //}

        board.DrawBoard(chessBoard, fColor, fType, point1, point2);
    }





}

