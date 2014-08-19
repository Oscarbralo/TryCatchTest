using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessHelper;

namespace AlgoChess
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Helper class to create board and check movements
            Helper helper = new Helper();
            StartHelper startHelper = new StartHelper();

            //Declaration of variables
            List<List<string>> result = new List<List<string>>();
            List<string> board = new List<string>();

            //Start with kings
            for (int i = 0; i < 7; i++)
            {
                for (int a = i; a < 7; a++)
                {
                    board = helper.getBoard();
                    var temp = startHelper.kingStart(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.kingStart1(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.kingStart2(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.kingStart3(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.kingStart4(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.queenStart(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.queenStart1(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.queenStart2(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.queenStart3(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.queenStart4(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.bishopStart(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.bishopStart1(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.bishopStart2(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.bishopStart3(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.bishopStart4(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.knightStart(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.knightStart1(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.knightStart2(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.knightStart3(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                    board = helper.getBoard();
                    temp = startHelper.knightStart4(board, i, a);
                    for (int b = 0; b < temp.Count; b++)
                    {
                        result.Add(temp[b]);
                    }
                }
            }

            result = helper.findDuplicates(result);

            for (int b = 0; b < result.Count; b++)
            {
                for (int a = 0; a < result[b].Count; a++)
                {
                    Console.WriteLine(result[b][a]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(string.Format("{0} total number of unique configurations for a 7x7 board", result.Count));
            Console.ReadLine();
        }
    }
}
