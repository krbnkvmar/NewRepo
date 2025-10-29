using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого ферзя");
            var whiteQueen = Console.ReadLine();
            Console.WriteLine("Введите позицию черного слона");
            var blackBishop = Console.ReadLine();

            if (whiteQueen == blackBishop)
            {
                Console.WriteLine("Фигуры не могут стоять на одной клетке");
                return;
            }

            int queenH, queenV;
            int bishopH, bishopV;

            DecodePosition(whiteQueen, out queenV, out queenH);
            DecodePosition(blackBishop, out bishopV, out bishopH);

            bool QueenGotBishop = QueenSuccess(whiteQueen, blackBishop);
            bool BishopGotQueen = BishopSuccess(blackBishop, whiteQueen);

            if (QueenGotBishop && BishopGotQueen)
            {
                Console.WriteLine("Фигуры бьют друг друга");
            }
            else if (BishopGotQueen)
            {
                Console.WriteLine("Ферзь под боем слона");
            }
            else if (QueenGotBishop)
            {
                Console.WriteLine("Слон под боем ферзя");
            }
            else { Console.WriteLine("Фигуры не бьют друг друга"); }
        }

        static void DecodePosition(string position, out int vert, out int hor)
        {
            vert = (int)position[0] - 0x60;
            hor = int.Parse(position[1].ToString());
        }

        static bool QueenSuccess(string position, string whiteQueen)
        {
            int qV, qH, bV, bH;

            DecodePosition(position, out bV, out bH);
            DecodePosition(whiteQueen, out qV, out qH);
            if (bV == qV) return true;
            if (bH == qH) return true;
            if (Math.Abs(bV - qV) == Math.Abs(bH - qH)) return true;
            else return false;
        }

        static bool BishopSuccess(string position, string blackBishop)
        {
            int qV, qH, bV, bH;

            DecodePosition(position, out qV, out qH);
            DecodePosition(blackBishop, out bV, out bH);

            if (Math.Abs(bV - qV) == Math.Abs(bH - qH)) return true;
            else return false;
        }
    }
}