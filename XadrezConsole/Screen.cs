﻿using System;
using board;
using chess;

namespace ChessConsole {
    class Screen {
        public static void printTray(Board board) {

            for (int i = 0; i < board.Rows; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Columns; j++) {
                    if (board.Piece(i, j) == null) {
                        Console.Write("- ");

                    } else {
                        PrintPiece(board.Piece(i, j));
                        Console.Write(" ");

                    }

                }
                Console.WriteLine();

            }
            Console.WriteLine("  a b c d e f g h");

        }

        public static ChessPosition ReadChessPosition() {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");

            return new ChessPosition(column, row);

        }

        public static void PrintPiece(Piece piece) {
            if (piece.Color == Color.Branca) {
                Console.Write(piece);

            } else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);

                Console.ForegroundColor = aux;

            }

        }

    }
}
