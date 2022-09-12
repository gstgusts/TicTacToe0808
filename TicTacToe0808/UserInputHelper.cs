using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe0808.Simple
{
    internal class UserInputHelper
    {
        internal static (int row, int column) GetRowAndColumn()
        {
            Console.Write("Please enter row and column (enter comma seperated values): ");
            var userInput = Console.ReadLine();

            var values = userInput.Split(",", StringSplitOptions.TrimEntries);

            var rowIndex = int.Parse(values[0]);
            var columnIndex = int.Parse(values[1]);

            return (rowIndex, columnIndex);
        }

        internal static Tuple<int, int> GetRowAndColumn2()
        {
            Console.Write("Please enter row and column (enter comma seperated values): ");
            var userInput = Console.ReadLine();

            var values = userInput.Split(",", StringSplitOptions.TrimEntries);

            var rowIndex = int.Parse(values[0]);
            var columnIndex = int.Parse(values[1]);

            return Tuple.Create(rowIndex, columnIndex);
        }

        internal static UserInputDto GetRowAndColumn3()
        {
            Console.Write("Please enter row and column (enter comma seperated values): ");
            var userInput = Console.ReadLine();

            var values = userInput.Split(",", StringSplitOptions.TrimEntries);

            var rowIndex = int.Parse(values[0]);
            var columnIndex = int.Parse(values[1]);

            return new UserInputDto() { 
                RowIndex = rowIndex, 
                ColumnIndex = columnIndex 
            };
        }
    }
}
