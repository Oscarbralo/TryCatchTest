using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper
{
    public class Helper
    {
        public List<string> getBoard()
        {
            return new List<string>() {
                                     "........",
                                     "........",
                                     "........",
                                     "........",
                                     "........",
                                     "........",
                                     "........",
                                     "........"
                                 };
        }

        //King
        public bool kingCanMove(List<string> board, int x, int y)
        {
            if (board[x][y] != '.')
                return false;
            if (x - 1 >= 0)
                if (board[x - 1][y] != '.' && board[x - 1][y] != '-')
                    return false;
            if (x - 1 >= 0 && y - 1 >= 0)
                if (board[x - 1][y - 1] != '.' && board[x - 1][y - 1] != '-')
                    return false;
            if (y - 1 >= 0)
                if (board[x][y - 1] != '.' && board[x][y - 1] != '-')
                    return false;
            if (x + 1 < board[x].Length && y - 1 >= 0)
                if (board[x + 1][y - 1] != '.' && board[x + 1][y - 1] != '-')
                    return false;
            if (x + 1 < board[x].Length)
                if (board[x + 1][y] != '.' && board[x + 1][y] != '-')
                    return false;
            if (x + 1 < board[x].Length && y + 1 < board.Count)
                if (board[x + 1][y + 1] != '.' && board[x + 1][y + 1] != '-')
                    return false;
            if (y + 1 < board.Count)
                if (board[x][y + 1] != '.' && board[x][y + 1] != '-')
                    return false;
            if (x - 1 >= 0 && y + 1 < board.Count)
                if (board[x - 1][y + 1] != '.' && board[x - 1][y + 1] != '-')
                    return false;
            return true;
        }

        public List<string> kingNewBoard(List<string> board, int x, int y)
        {
            if (x - 1 >= 0)
                if (board[x - 1][y] == '.')
                {
                    board[x - 1] = board[x - 1].Insert(y, "-");
                    board[x - 1] = board[x - 1].Remove(y + 1, 1);
                }
            if (x - 1 >= 0 && y - 1 >= 0)
                if (board[x - 1][y - 1] == '.')
                {
                    board[x - 1] = board[x - 1].Insert(y - 1, "-");
                    board[x - 1] = board[x - 1].Remove(y - 1 + 1, 1);
                }
            if (y - 1 >= 0)
                if (board[x][y - 1] == '.')
                {
                    board[x] = board[x].Insert(y - 1, "-");
                    board[x] = board[x].Remove(y - 1 + 1, 1);
                }
            if (x + 1 < board[x].Length && y - 1 >= 0)
                if (board[x + 1][y - 1] == '.')
                {
                    board[x + 1] = board[x + 1].Insert(y - 1, "-");
                    board[x + 1] = board[x + 1].Remove(y - 1 + 1, 1);
                }
            if (x + 1 < board[x].Length)
                if (board[x + 1][y] == '.')
                {
                    board[x + 1] = board[x + 1].Insert(y, "-");
                    board[x + 1] = board[x + 1].Remove(y + 1, 1);
                }
            if (x + 1 < board[x].Length && y + 1 < board.Count)
                if (board[x + 1][y + 1] == '.')
                {
                    board[x + 1] = board[x + 1].Insert(y + 1, "-");
                    board[x + 1] = board[x + 1].Remove(y + 1 + 1, 1);
                }
            if (y + 1 < board.Count)
                if (board[x][y + 1] == '.')
                {
                    board[x] = board[x].Insert(y + 1, "-");
                    board[x] = board[x].Remove(y + 1 + 1, 1);
                }
            if (x - 1 >= 0 && y + 1 < board.Count)
                if (board[x - 1][y + 1] == '.')
                {
                    board[x - 1] = board[x - 1].Insert(y + 1, "-");
                    board[x - 1] = board[x - 1].Remove(y + 1 + 1, 1);
                }
            return board;
        }

        //Queen
        public bool queenCanMove(List<string> board, int x, int y)
        {
            if (board[x][y] != '.')
                return false;
            //Left
            int tempX = x;
            int tempY = y - 1;
            while (tempY >= 0)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempY--;
            }
            //Left Top
            tempX = x - 1;
            tempY = y - 1;
            while (tempX >= 0 && tempY >= 0)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempX--;
                tempY--;
            }
            //Top
            tempX = x - 1;
            tempY = y;
            while (tempX >= 0)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempX--;
            }
            //Right Top
            tempX = x + 1;
            tempY = y - 1;
            while (tempX < board[x].Length && tempY >= 0)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempX++;
                tempY--;
            }
            //Right
            tempX = x;
            tempY = y + 1;
            while (tempY < board[x].Length)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempY++;
            }
            //Right Down
            tempX = x + 1;
            tempY = y + 1;
            while (tempX < board[x].Length && tempY < board.Count)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempX++;
                tempY++;
            }
            //Down
            tempX = x + 1;
            tempY = y;
            while (tempX < board.Count)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempX++;
            }
            //Down Left
            tempX = x - 1;
            tempY = y + 1;
            while (tempX >= 0 && tempY < board.Count)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempX--;
                tempY++;
            }
            return true;
        }

        public List<string> queenNewBoard(List<string> board, int x, int y)
        {
            //Left
            int tempX = x;
            int tempY = y - 1;
            while (tempY >= 0)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempY--;
            }
            //Left Top
            tempX = x - 1;
            tempY = y - 1;
            while (tempX >= 0 && tempY >= 0)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempX--;
                tempY--;
            }
            //Top
            tempX = x - 1;
            tempY = y;
            while (tempX >= 0)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempX--;
            }
            //Right Top
            tempX = x + 1;
            tempY = y - 1;
            while (tempX < board[x].Length && tempY >= 0)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempX++;
                tempY--;
            }
            //Right
            tempX = x;
            tempY = y + 1;
            while (tempY < board[x].Length)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempY++;
            }
            //Right Down
            tempX = x + 1;
            tempY = y + 1;
            while (tempX < board[x].Length && tempY < board.Count)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempX++;
                tempY++;
            }
            //Down
            tempX = x + 1;
            tempY = y;
            while (tempX < board.Count)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempX++;
            }
            //Down Left
            tempX = x - 1;
            tempY = y + 1;
            while (tempX >= 0 && tempY < board.Count)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempX--;
                tempY++;
            }
            return board;
        }

        //Bishop
        public bool bishopCanMove(List<string> board, int x, int y)
        {
            if (board[x][y] != '.')
                return false;
            int tempX = x - 1;
            int tempY = y - 1;
            while (tempX >= 0 && tempY >= 0)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempX--;
                tempY--;
            }
            tempX = x + 1;
            tempY = y - 1;
            while (tempX < board[x].Length && tempY >= 0)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempX++;
                tempY--;
            }
            tempX = x + 1;
            tempY = y + 1;
            while (tempX < board[x].Length && tempY < board.Count)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempX++;
                tempY++;
            }
            tempX = x - 1;
            tempY = y + 1;
            while (tempX >= 0 && tempY < board.Count)
            {
                if (board[tempX][tempY] != '.' && board[tempX][tempY] != '-')
                    return false;
                tempX--;
                tempY++;
            }
            return true;
        }

        public List<string> bishopNewBoard(List<string> board, int x, int y)
        {
            int tempX = x - 1;
            int tempY = y - 1;
            while (tempX >= 0 && tempY >= 0)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempX--;
                tempY--;
            }
            tempX = x + 1;
            tempY = y - 1;
            while (tempX < board[x].Length && tempY >= 0)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempX++;
                tempY--;
            }
            tempX = x + 1;
            tempY = y + 1;
            while (tempX < board[x].Length && tempY < board.Count)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempX++;
                tempY++;
            }
            tempX = x - 1;
            tempY = y + 1;
            while (tempX >= 0 && tempY < board.Count)
            {
                if (board[tempX][tempY] == '.')
                {
                    board[tempX] = board[tempX].Insert(tempY, "-");
                    board[tempX] = board[tempX].Remove(tempY + 1, 1);
                }
                tempX--;
                tempY++;
            }
            return board;
        }

        //Knight
        public bool knightCanMove(List<string> board, int x, int y)
        {
            if (board[x][y] != '.')
                return false;
            if (x - 2 >= 0 && y - 1 >= 0)
                if (board[x - 2][y - 1] != '.' && board[x - 2][y - 1] != '-')
                    return false;
            if (x - 2 >= 0 && y + 1 < board.Count)
                if (board[x - 2][y + 1] != '.' && board[x - 2][y + 1] != '-')
                    return false;
            if (y - 2 >= 0 && x - 1 >= 0)
                if (board[x - 1][y - 2] != '.' && board[x - 1][y - 2] != '-')
                    return false;
            if (y - 2 >= 0 && x + 1 < board[x].Length)
                if (board[x + 1][y - 2] != '.' && board[x + 1][y - 2] != '-')
                    return false;
            if (x + 2 < board[x].Length && y - 1 >= 0)
                if (board[x + 2][y - 1] != '.' && board[x + 2][y - 1] != '-')
                    return false;
            if (x + 2 < board[x].Length && y + 1 < board.Count)
                if (board[x + 2][y + 1] != '.' && board[x + 2][y + 1] != '-')
                    return false;
            if (y + 2 < board.Count && x - 1 >= 0)
                if (board[x - 1][y + 2] != '.' && board[x - 1][y + 2] != '-')
                    return false;
            if (y + 2 < board.Count && x + 1 < board[x].Length)
                if (board[x + 1][y + 2] != '.' && board[x + 1][y + 2] != '-')
                    return false;
            return true;
        }

        public List<string> knightNewBoard(List<string> board, int x, int y)
        {
            if (x - 2 >= 0 && y - 1 >= 0)
                if (board[x - 2][y - 1] == '.')
                {
                    board[x - 2] = board[x - 2].Insert(y - 1, "-");
                    board[x - 2] = board[x - 2].Remove(y - 1 + 1, 1);
                }
            if (x - 2 >= 0 && y + 1 < board.Count)
                if (board[x - 2][y + 1] == '.')
                {
                    board[x - 2] = board[x - 2].Insert(y + 1, "-");
                    board[x - 2] = board[x - 2].Remove(y + 1 + 1, 1);
                }
            if (y - 2 >= 0 && x - 1 >= 0)
                if (board[x - 1][y - 2] == '.')
                {
                    board[x - 1] = board[x - 1].Insert(y - 2, "-");
                    board[x - 1] = board[x - 1].Remove(y - 2 + 1, 1);
                }
            if (y - 2 >= 0 && x + 1 < board[x].Length)
                if (board[x + 1][y - 2] == '.')
                {
                    board[x + 1] = board[x + 1].Insert(y - 2, "-");
                    board[x + 1] = board[x + 1].Remove(y - 2 + 1, 1);
                }
            if (x + 2 < board[x].Length && y - 1 >= 0)
                if (board[x + 2][y - 1] == '.')
                {
                    board[x + 2] = board[x + 2].Insert(y - 1, "-");
                    board[x + 2] = board[x + 2].Remove(y - 1 + 1, 1);
                }
            if (x + 2 < board[x].Length && y + 1 < board.Count)
                if (board[x + 2][y + 1] == '.')
                {
                    board[x + 2] = board[x + 2].Insert(y + 1, "-");
                    board[x + 2] = board[x + 2].Remove(y + 1 + 1, 1);
                }
            if (y + 2 < board.Count && x - 1 >= 0)
                if (board[x - 1][y + 2] == '.')
                {
                    board[x - 1] = board[x - 1].Insert(y + 2, "-");
                    board[x - 1] = board[x - 1].Remove(y + 2 + 1, 1);
                }
            if (y + 2 < board.Count && x + 1 < board[x].Length)
                if (board[x + 1][y + 2] == '.')
                {
                    board[x + 1] = board[x + 1].Insert(y + 2, "-");
                    board[x + 1] = board[x + 1].Remove(y + 2 + 1, 1);
                }
            return board;
        }

        public List<List<string>> findDuplicates(List<List<string>> result)
        {
            for (int i = 0; i < result.Count - 1; i++)
            {
                for (int a = i + 1; a < result.Count; a++)
                {
                    int temp = 0;
                    for (int b = 0; b < result[a].Count; b++)
                    {
                        if (result[i][b] != result[a][b])
                        {
                            temp++;
                        }
                    }
                    if (temp == 7)
                    {
                        result.RemoveAt(a);
                        a--;
                    }
                }
            }
            return result;
        }
    }
}
