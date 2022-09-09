using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe0808.Data;

namespace TicTacToe0808.Simple
{
    internal class UIHelper
    {
        const string HorizontalLine = "------------------------------";
        public static void DrawBoard(FieldValueEnum[,] board)
        {
            Console.WriteLine("  ||   0   ||   1   ||   2   |");
            Console.WriteLine(HorizontalLine);

            for (int rowIndex = 0; rowIndex < 3; rowIndex++)
            {
                Console.Write($"{rowIndex} |");
                
                for (int columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    var fieldValue = "   ";
                    
                    if(board[rowIndex, columnIndex] != FieldValueEnum.Empty)
                    {
                        fieldValue = " " + board[rowIndex, columnIndex].ToString() + " ";
                    }

                    Console.Write($"|  {fieldValue}  |");
                }

                Console.WriteLine();
                Console.WriteLine(HorizontalLine);
            }
        }
    }
}
