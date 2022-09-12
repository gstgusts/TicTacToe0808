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
            for (int i = 0; i < Size; i++)
            {
                if (Field[i, 0] == Field[i, 1] && Field[i, 1] == Field[i, 2] && Field[i, 0] != FieldValueEnum.Empty) //checks horizontals
                {
                    if (Field[i, 0] == FieldValueEnum.X)
                    {
                        return GameResultEnum.XWon;
                    }
                    else
                    {
                        return GameResultEnum.OWon;
                    }
                }

                if (Field[0, i] == Field[1, i] && Field[1, i] == Field[2, i] && Field[0, i] != FieldValueEnum.Empty) //checks verticals
                {
                    if (Field[0, i] == FieldValueEnum.X)
                    {
                        return GameResultEnum.XWon;
                    }
                    else
                    {
                        return GameResultEnum.OWon;
                    }
                }
            }

            if (Field[0, 0] == Field[1, 1] && Field[1, 1] == Field[2, 2] && Field[1, 1] != FieldValueEnum.Empty
                || Field[0, 2] == Field[1, 1] && Field[1, 1] == Field[2, 0] && Field[1, 1] != FieldValueEnum.Empty) //checks diagonals
            {
                if (Field[1, 1] == FieldValueEnum.X)
                {
                    return GameResultEnum.XWon;
                }
                else
                {
                    return GameResultEnum.OWon;
                }
            }

            bool allFieldsFull = true;
            for (int i = 0; i < Size; i++) //checks if all fields full even though there is no winner - draw situation
            {
                for (int j = 0; j < Size; j++)
                {
                    if (Field[i, j] == FieldValueEnum.Empty)
                    {
                        allFieldsFull = false;
                        break;
                    }
                }
            }

            if (allFieldsFull)
            {
                return GameResultEnum.Draw;
            }

            return GameResultEnum.Continue;
        }
    }
}