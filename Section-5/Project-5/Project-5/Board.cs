using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Board
    {
        private int Size;
        private string[][] Grid;
        private int targX;
        private int targY;
        private int destX;
        private int destY;

        public Board(int size)
        {
            this.Size = size;
            this.Grid = new string[size][];

            for (int i = 0; i < size; i++)
            {
                this.Grid[i] = new string[size];
            }
        }

        public void Fill()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.Grid[i][j] = "X ";
                }
            }
        }

        public void RemoveX()
        {
            for (int i = 2; i <= 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.Grid[i][j] = "  ";
                }
            }
        }

        public void Print()
        {
            int xGrid = -1;
            int yGrid = -1;
            System.Console.Write("    ");

            foreach (string[] column in Grid)
            {
                xGrid++;
                System.Console.Write(xGrid + "   ");
            }
            foreach (string[] row in Grid)
            {
                yGrid++;
                System.Console.WriteLine();
                System.Console.WriteLine("  +---+---+---+---+---+---+---+---+");
                System.Console.Write(yGrid + " ");

                foreach (string stringValue in row)
                {

                    System.Console.Write("| ");
                    System.Console.Write(stringValue);

                }
                System.Console.Write("|");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("  +---+---+---+---+---+---+---+---+");
        }

        public void YourMove()
        {
            while (targX <= 7 && targX >= 0 && targY <= 7 && targY >= 0 && destX <= 7 && destX >= 0 && destY <= 7 && destY >= 0)
            {
                System.Console.WriteLine(" ");
                System.Console.Write("Enter Target X Coordinate Between 0 and 7: ");
                targX = int.Parse(System.Console.ReadLine());
                System.Console.Write("Enter Target Y Coordinate Between 0 and 7: ");
                targY = int.Parse(System.Console.ReadLine());
                System.Console.Write("Enter Destination X Coordinate Between 0 and 7: ");
                destX = int.Parse(System.Console.ReadLine());
                System.Console.Write("Enter Destination Y Coordinate Between 0 and 7: ");
                destY = int.Parse(System.Console.ReadLine());

                if (targX <= 7 && targX >= 0 && targY <= 7 && targY >= 0 && destX <= 7 && destX >= 0 && destY <= 7 && destY >= 0)
                {
                    this.Grid[destY][destX] = this.Grid[targY][targX];
                    this.Grid[targY][targX] = "  ";
                    System.Console.Clear();
                    Print();
                }
            }
            System.Console.WriteLine("One of your Coordinates is not on the Chessboard!");
            System.Console.WriteLine("This Program will now Exit");
            System.Threading.Thread.Sleep(5000);
        }
    }
}


