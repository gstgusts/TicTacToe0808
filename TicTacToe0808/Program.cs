using TicTacToe0808.Data;

namespace TicTacToe0808.Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            while (game.ContinueGame)
            {
                UIHelper.DrawBoard(game.Field);

                // var input = UserInputHelper.GetRowAndColumn();

                //var input = UserInputHelper.GetRowAndColumn2();
                //input.Item1;
                //input.Item2;

                //var input = UserInputHelper.GetRowAndColumn3();
                //input.RowIndex;
                //input.ColumnIndex;

                (int row, int column) = UserInputHelper.GetRowAndColumn();

                var result = game.MakeMove(row, column);

                switch (result)
                {
                    case GameResultEnum.Draw:
                        UIHelper.PrintResult("It's a draw!");
                        break;
                    case GameResultEnum.XWon:
                        UIHelper.PrintResult("X is the winner!");
                        break;
                    case GameResultEnum.OWon:
                        UIHelper.PrintResult("O is the winner!");
                        break;
                }

                if(result != GameResultEnum.Continue)
                {
                    UIHelper.DrawBoard(game.Field);
                }
               
            }
        }
    }
}