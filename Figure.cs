

namespace ChessProject;

internal abstract class Figure
{
    public abstract void MoveFigure(FigureColor fColor, FigureType fType, Coordinates point1, Coordinates point2, ChessBoard ch);

}

