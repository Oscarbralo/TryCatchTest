using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper
{
    public class StartHelper
    {
        public List<List<string>> kingStart(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 1;
            int queensLeft = 2;
            int bishopsLeft = 2;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "K");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.kingNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> kingStart1(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 1;
            int queensLeft = 2;
            int bishopsLeft = 2;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "K");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.kingNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> kingStart2(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 1;
            int queensLeft = 2;
            int bishopsLeft = 2;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "K");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.kingNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }

                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                }
            }
            Console.WriteLine("\n");
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> kingStart3(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 1;
            int queensLeft = 2;
            int bishopsLeft = 2;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "K");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.kingNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }

                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> kingStart4(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 1;
            int queensLeft = 2;
            int bishopsLeft = 2;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "K");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.kingNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> queenStart(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 1;
            int bishopsLeft = 2;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "Q");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.queenNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> queenStart1(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 1;
            int bishopsLeft = 2;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "Q");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.queenNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }

                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> queenStart2(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 1;
            int bishopsLeft = 2;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "Q");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.queenNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }

                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> queenStart3(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 1;
            int bishopsLeft = 2;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "Q");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.queenNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }


                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> queenStart4(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 1;
            int bishopsLeft = 2;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "Q");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.queenNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }

                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }

                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> bishopStart(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 2;
            int bishopsLeft = 1;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "B");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.bishopNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }

                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> bishopStart1(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 2;
            int bishopsLeft = 1;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "B");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.bishopNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }


                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> bishopStart2(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 2;
            int bishopsLeft = 1;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "B");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.bishopNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }

                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }


                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> bishopStart3(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 2;
            int bishopsLeft = 1;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "B");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.bishopNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }



                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> bishopStart4(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 2;
            int bishopsLeft = 1;
            int knightsLeft = 1;
            board[i] = board[i].Insert(a, "B");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.bishopNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }

                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }


                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> knightStart(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 2;
            int bishopsLeft = 2;
            int knightsLeft = 0;
            board[i] = board[i].Insert(a, "P");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.knightNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }

                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> knightStart1(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 2;
            int bishopsLeft = 2;
            int knightsLeft = 0;
            board[i] = board[i].Insert(a, "P");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.knightNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }


                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> knightStart2(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 2;
            int bishopsLeft = 2;
            int knightsLeft = 0;
            board[i] = board[i].Insert(a, "P");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.knightNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }

                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }


                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> knightStart3(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 2;
            int bishopsLeft = 2;
            int knightsLeft = 0;
            board[i] = board[i].Insert(a, "P");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.knightNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }
                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }
                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }



                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

        public List<List<string>> knightStart4(List<string> board, int i, int a)
        {
            Helper helper = new Helper();
            List<List<string>> result = new List<List<string>>();
            int kingsLeft = 2;
            int queensLeft = 2;
            int bishopsLeft = 2;
            int knightsLeft = 0;
            board[i] = board[i].Insert(a, "P");
            board[i] = board[i].Remove(a + 1, 1);
            board = helper.knightNewBoard(board, i, a);
            for (int b = 0; b < board.Count; b++)
            {
                for (int c = 0; c < board[b].Length; c++)
                {
                    if (b == i && c == a)
                        continue;
                    if (knightsLeft > 0)
                    {
                        if (helper.knightCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "P");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.knightNewBoard(board, b, c);
                            knightsLeft--;
                        }
                    }
                    if (queensLeft > 0)
                    {
                        if (helper.queenCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "Q");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.queenNewBoard(board, b, c);
                            queensLeft--;
                        }
                    }

                    if (bishopsLeft > 0)
                    {
                        if (helper.bishopCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "B");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.bishopNewBoard(board, b, c);
                            bishopsLeft--;
                        }
                    }

                    if (kingsLeft > 0)
                    {
                        if (helper.kingCanMove(board, b, c))
                        {
                            board[b] = board[b].Insert(c, "K");
                            board[b] = board[b].Remove(c + 1, 1);
                            board = helper.kingNewBoard(board, b, c);
                            kingsLeft--;
                        }
                    }

                }
            }
            if (knightsLeft == 0 & queensLeft == 0 && bishopsLeft == 0 && knightsLeft == 0)
                result.Add(board);
            return result;
        }

    }
}
