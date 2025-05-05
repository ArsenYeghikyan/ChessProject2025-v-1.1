//using ChessCoordinades;

//namespace ConsoleApp9;

//internal class ChessBoard
//{
//    private string[,] chessBoard = new string[8, 8];
//    public void BuildChessBoard(Coordinates point1, Coordinates point2)
//    {

//        ChessLettersPrinter();
//        for (int rowIndex = 0; rowIndex < chessBoard.GetLength(0); rowIndex++)
//        {
//            Console.Write($" {8 - rowIndex} ");
//            for (int colIndex = 0; colIndex < chessBoard.GetLength(1); colIndex++)
//            {
//                if ((rowIndex + colIndex) % 2 == 0)
//                    Console.BackgroundColor = ConsoleColor.White;
//                else
//                    Console.BackgroundColor = ConsoleColor.Black;

//                bool isPath = false;
//                int startRow = point1.GetRowIndex();
//                int startCol = point1.GetColumnIndex();
//                int endRow = point2.GetRowIndex();
//                int endCol = point2.GetColumnIndex();
//                if (startCol == endCol && colIndex == startCol &&
//                    rowIndex >= GetMinCoordIndex(startRow, point2.GetRowIndex()) &&
//                    rowIndex <= GetMaxCoordIndex(startRow, point2.GetRowIndex()))
//                {
//                    isPath = true;                   
//                }
//                else if (startRow == endRow && rowIndex == startRow &&
//                    colIndex >= GetMinCoordIndex(startCol, endCol) &&
//                    colIndex <= GetMaxCoordIndex(startCol, endCol))
//                {
//                    isPath = true;                                    
//                }
//                if (isPath)
//                {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.Write(" ■");
//                }
//                else
//                {
//                    Console.Write("  ");
//                }

//                Console.ForegroundColor = ConsoleColor.Gray;
//            }
//            Console.ResetColor();
//            Console.WriteLine();
//        }
//        ChessLettersPrinter();
//    }
//    private void ChessLettersPrinter()
//    {
//        Console.Write("   ");
//        for (char c = 'A'; c <= 'H'; c++)
//        {
//            Console.Write($" {c}");
//        }
//        Console.WriteLine();
//    }

//    private int GetMinCoordIndex(int index1, int index2)
//    {
//        return index1 < index2 ? index1 : index2;
//    }

//    private int GetMaxCoordIndex(int index1, int index2)
//    {
//        return index1 > index2 ? index1 : index2;
//    }




//}

namespace ChessProject;

internal class ChessBoard
{
    

    public void PlaceMarker(string[,] board, Coordinates point, string marker)
    {
        int row = point.GetRowIndex();
        int col = point.GetColumnIndex();

        if (row >= 0 && row < 8 && col >= 0 && col < 8)
        {
            board[row, col] = marker;
        }
    }

   
    public void DrawBoard(string[,] board, FigureColor fColor, FigureType fType, Coordinates point1, Coordinates point2)
    {
        ChessLettersPrinter();

        for (int row = 0; row < board.GetLength(0); row++)
        {
            Console.Write($" {8 - row} ");
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if ((row + col) % 2 == 0)
                    Console.BackgroundColor = ConsoleColor.White;
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                string cell = board[row, col];

                if (cell == "X")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" X");
                }
                else if (cell == "■")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" ■");
                }
                else
                {
                    Console.Write("  ");
                }

                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        ChessLettersPrinter();

        PrintChessMoveInfo(fColor, fType, point1, point2);
    }

    private void ChessLettersPrinter()
    {
        Console.Write("   ");
        for (char c = 'A'; c <= 'H'; c++)
        {
            Console.Write($" {c}");
        }
        Console.WriteLine();
    }

    private void PrintChessMoveInfo(FigureColor fColor, FigureType fType, Coordinates c1, Coordinates c2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" Info: {fColor} {fType}, {c1.ToString()}---->{c2.ToString()} ");
        Console.WriteLine();
        Console.ResetColor();

    }


}

