using ChessProject2025;

namespace ChessProject;
internal static class Menu
{
    private static ChessBoard board = new ChessBoard();

    public static void RunChessMenu()
    {
        ChessBoard ch = new ChessBoard();
        bool flag = true;
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The new game has started!");
            string colorInput = Console.ReadLine()?.Trim().ToLower();
      
            Console.WriteLine("Enter two coordinates in chess format (e.g., A1, H8):");
            Console.WriteLine("First — starting position, then — target position.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Start (e.g., A2): ");
            string coord1 = Console.ReadLine();

            Coordinates point1 = new Coordinates(coord1);
            Console.Write("End   (e.g., A4): ");
            string coord2 = Console.ReadLine();
            Console.ResetColor();

            Coordinates point2 = new Coordinates(coord2);
            Figure figure = new Knight();

            Console.ResetColor();

            if (point1.GetColumnIndex() < 0 || point1.GetRowIndex() < 0 || point1.GetColumnIndex() > 7 || point1.GetRowIndex() > 7 ||
                point2.GetColumnIndex() < 0 || point2.GetRowIndex() < 0 || point2.GetColumnIndex() > 7 || point2.GetRowIndex() > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect coordinates!!! Please, enter correct coordinates in chess format (e.g., A1, H8):");
                Console.ResetColor();
                return;
            }
            //FigureColor fColor;
            //switch (colorInput)
            //{
            //    case "White":
            //        fColor = FigureColor.White;
            //        break;
            //    case "Black":
            //        fColor = FigureColor.Black;
            //        break;

            //    default:
            //        Console.WriteLine("Incorrect coordinates!!! Please, enter White or Black.");
            //        break;
            //}

            figure.MoveFigure(FigureColor.White, FigureType.Knight, point1, point2, board);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("If you want to exit the menu, type \"Exit\" or type \"Start\" to continue");

            Console.ResetColor();
            string? button = Console.ReadLine();

            if (button == null || button.Equals("Exit", StringComparison.OrdinalIgnoreCase) || !button.Equals("Start",StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over!");
                flag = false;
                Console.ResetColor();
            }
        } while (flag);
    }
}

