namespace TicTacToe0808.Data
{
    public class Game
    {
        public const int Size = 3;
        public bool IsXPlaying { get; set; }

        public FieldValueEnum[,] Field { get; set; } = new FieldValueEnum[Size, Size];

        public Game()
        {
            Reset();
        }

        public void Reset()
        {
            IsXPlaying = true;

            // changes rows
            for (int i = 0; i < Size; i++)
            {
                // changes columns
                for (int j = 0; j < Size; j++)
                {
                    Field[i,j] = FieldValueEnum.Empty;
                }
            }
        }

        public GameResultEnum MakeMove(int rowIndex, int columnIndex)
        {
            if(rowIndex > Size - 1 || columnIndex > Size - 1)
            {
                return GameResultEnum.Continue;
            }

            if (Field[rowIndex, columnIndex] != FieldValueEnum.Empty)
            {
                return GameResultEnum.Continue;
            }

            Field[rowIndex, columnIndex] = IsXPlaying ? FieldValueEnum.X : FieldValueEnum.O;

            IsXPlaying = !IsXPlaying;

            return CheckWinner();
        }

        private GameResultEnum CheckWinner()
        {
            return GameResultEnum.Continue;
        }
    }
}