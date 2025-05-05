namespace ChessProject;

internal struct Coordinates
{

    private char letter;
    private int number;

    public Coordinates(string coordinate)
    {
        string coordinateUpLetter = coordinate.ToUpper();
        if (string.IsNullOrEmpty(coordinateUpLetter) || coordinate.Length < 2)
        {
            throw new ArgumentException("Invalid input format");
        }
        if (!int.TryParse(coordinateUpLetter[1].ToString(), out int result))
        {
            throw new ArgumentException("Invalid number");
        }
        SetLetter(coordinateUpLetter[0]);
        SetNumber(result);
    }
    private void SetLetter(char letter)
    {
        if (letter < 'A' || letter > 'H')
            throw new ArgumentOutOfRangeException(nameof(letter));
        this.letter = letter;

    }
    public char GetLetter() => letter;

    private void SetNumber(int number)
    {
        if (number < 1 || number > 8)
            throw new ArgumentOutOfRangeException(nameof(number));
        this.number = number;
    }
    public int GetNumber() => number;
   
    public override string ToString() => $"{GetLetter()}{GetNumber()}";
    public int GetColumnIndex()
    {
        return letter - 'A';
    }
    public int GetRowIndex()
    {
        return 8 - number;
    }



}

