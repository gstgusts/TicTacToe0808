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