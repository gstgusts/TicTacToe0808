using TicTacToe0808.Data;

namespace TicTacToe0808.Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            bool continueGame = true;

            while (continueGame)
            {
                UIHelper.DrawBoard(game.Field);

                Console.Write("Please enter row and column (enter comma seperated values): ");
                var userInput = Console.ReadLine();

                var values = userInput.Split(",", StringSplitOptions.TrimEntries);

                var rowIndex = int.Parse(values[0]);
                var columnIndex = int.Parse(values[1]);

                var result = game.MakeMove(rowIndex, columnIndex);

                switch (result)
                {
                    case GameResultEnum.Draw:
                        Console.WriteLine();
                        Console.WriteLine("It's a draw!");
                        UIHelper.DrawBoard(game.Field);
                        continueGame = false;
                        break;
                    case GameResultEnum.XWon:
                        Console.WriteLine();
                        Console.WriteLine("X is the winner!");
                        UIHelper.DrawBoard(game.Field);
                        continueGame = false;
                        break;
                    case GameResultEnum.OWon:
                        Console.WriteLine();
                        Console.WriteLine("O is the winner!");
                        UIHelper.DrawBoard(game.Field);
                        continueGame = false;
                        break;
                }
            }
        }
    }
}