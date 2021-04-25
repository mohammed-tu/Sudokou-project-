using System;
using System.Collections.Generic;

namespace Sudokou_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> column1 = new List<int>();
            List<int> column2 = new List<int>();
            List<int> column3 = new List<int>();
            List<int> column4 = new List<int>();
            List<int> column5 = new List<int>();
            List<int> column6 = new List<int>();
            List<int> column7 = new List<int>();
            List<int> column8 = new List<int>();
            List<int> column9 = new List<int>();
            List<int> row1 = new List<int>();
            List<int> row2 = new List<int>();
            List<int> row3 = new List<int>();
            List<int> row4 = new List<int>();
            List<int> row5 = new List<int>();
            List<int> row6 = new List<int>();
            List<int> row7 = new List<int>();
            List<int> row8 = new List<int>();
            List<int> row9 = new List<int>();
            List<int> checkListBlock1 = new List<int>();
            List<int> checkListBlock2 = new List<int>();
            List<int> checkListBlock3 = new List<int>();
            List<int> checkListBlock4 = new List<int>();
            List<int> checkListBlock5 = new List<int>();
            List<int> checkListBlock6 = new List<int>();
            List<int> checkListBlock7 = new List<int>();
            List<int> checkListBlock8 = new List<int>();
            List<int> checkListBlock9 = new List<int>();

            /*int[,] sudokuMatrix = new int[9, 9];
            Console.WriteLine("Enter number Of values to start your sudoku challenge");
            int numberOfvalues = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int row = 0, column = 0, num = 0;
            while (x < numberOfvalues)
            {
                Console.WriteLine("Enter row index");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter column index");
                column = Convert.ToInt32(Console.ReadLine());
                if (row > 8 || column > 8)
                {
                    Console.WriteLine("out of Sudoku rang ");
                    return;
                }
                Console.WriteLine("Enter the value ");
                num = Convert.ToInt32(Console.ReadLine());
                sudokuMatrix[row, column] = num;
                x++;
            }*/

            /*int[,] sudokuMatrix = {
                        { 3, 2, 1, 7, 0, 4, 0, 0, 0 },
                        { 6, 4, 0, 0, 9, 0, 0, 0, 7 },
                        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 4, 5, 9, 0, 0 },
                        { 0, 0, 5, 1, 8, 7, 4, 0, 0 },
                        { 0, 0, 4, 9, 6, 0, 0, 0, 0 },
                        { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                        { 2, 0, 0, 0, 7, 0, 0, 1, 9 },
                        { 0, 0, 0, 6, 0, 9, 5, 8, 2 }
                   };*/

            int[,] sudokuMatrix = {
                              { 0, 3, 0, 5, 0, 0, 0, 9, 0 },
                              { 0, 0, 0, 0, 0, 7, 0, 0, 0 },
                              { 0, 4, 1, 0, 0, 2, 6, 7, 0 },
                              { 0, 0, 2, 7, 1, 8, 9, 0, 0 },
                              { 0, 1, 5, 9, 0, 3, 0, 0, 0 },
                              { 3, 8, 9, 0, 0, 0, 0, 4, 0 },
                              { 8, 0, 0, 0, 5, 6, 0, 1, 9 },
                              { 0, 5, 6, 4, 0, 9, 8, 2, 7 },
                              { 2, 9, 4, 0, 0, 1, 0, 6, 3 }
                         };

            // check input Row
            for (int i = 0; i < 9; i++)
            {
                if (sudokuMatrix[i, 0] != 0)
                {
                    column1.Add(sudokuMatrix[i, 0]);
                }
                if (sudokuMatrix[i, 1] != 0)
                {
                    column2.Add(sudokuMatrix[i, 1]);
                }
                if (sudokuMatrix[i, 2] != 0)
                {
                    column3.Add(sudokuMatrix[i, 2]);
                }
                if (sudokuMatrix[i, 3] != 0)
                {
                    column4.Add(sudokuMatrix[i, 3]);
                }
                if (sudokuMatrix[i, 4] != 0)
                {
                    column5.Add(sudokuMatrix[i, 4]);
                }
                if (sudokuMatrix[i, 5] != 0)
                {
                    column6.Add(sudokuMatrix[i, 5]);
                }
                if (sudokuMatrix[i, 6] != 0)
                {
                    column7.Add(sudokuMatrix[i, 6]);
                }
                if (sudokuMatrix[i, 7] != 0)
                {
                    column8.Add(sudokuMatrix[i, 7]);
                }
                if (sudokuMatrix[i, 8] != 0)
                {
                    column9.Add(sudokuMatrix[i, 8]);
                }
            }

            // check input Column
            for (int j = 0; j < 9; j++)
            {
                if (sudokuMatrix[0, j] != 0)
                {
                    row1.Add(sudokuMatrix[0, j]);
                }
                if (sudokuMatrix[1, j] != 0)
                {
                    row2.Add(sudokuMatrix[1, j]);
                }
                if (sudokuMatrix[2, j] != 0)
                {
                    row3.Add(sudokuMatrix[2, j]);
                }
                if (sudokuMatrix[3, j] != 0)
                {
                    row4.Add(sudokuMatrix[3, j]);
                }
                if (sudokuMatrix[4, j] != 0)
                {
                    row5.Add(sudokuMatrix[4, j]);
                }
                if (sudokuMatrix[5, j] != 0)
                {
                    row6.Add(sudokuMatrix[5, j]);
                }
                if (sudokuMatrix[6, j] != 0)
                {
                    row7.Add(sudokuMatrix[6, j]);
                }
                if (sudokuMatrix[7, j] != 0)
                {
                    row8.Add(sudokuMatrix[7, j]);
                }
                if (sudokuMatrix[8, j] != 0)
                {
                    row9.Add(sudokuMatrix[8, j]);
                }
            }

            // for checking input of the blocks
            for (int i = 0; i < 9; i = i + 3)
            {
                for (int j = 0; j < 9; j = j + 3)
                {
                    int block1 = getBlock(i, j);
                    switch (block1)
                    {
                        case 1:
                            checkListBlock1 = checkInvalidBlock(0, 3, 0, 3, checkListBlock1, sudokuMatrix);
                            break;
                        case 2:
                            checkListBlock2 = checkInvalidBlock(0, 3, 3, 6, checkListBlock2, sudokuMatrix);
                            break;
                        case 3:
                            checkListBlock3 = checkInvalidBlock(0, 3, 6, 9, checkListBlock3, sudokuMatrix);
                            break;
                        case 4:
                            checkListBlock4 = checkInvalidBlock(3, 6, 0, 3, checkListBlock4, sudokuMatrix);
                            break;
                        case 5:
                            checkListBlock5 = checkInvalidBlock(3, 6, 3, 6, checkListBlock5, sudokuMatrix);
                            break;
                        case 6:
                            checkListBlock6 = checkInvalidBlock(3, 6, 6, 9, checkListBlock6, sudokuMatrix);
                            break;
                        case 7:
                            checkListBlock7 = checkInvalidBlock(6, 9, 0, 3, checkListBlock7, sudokuMatrix);
                            break;
                        case 8:
                            checkListBlock8 = checkInvalidBlock(6, 9, 3, 6, checkListBlock8, sudokuMatrix);
                            break;
                        case 9:
                            checkListBlock9 = checkInvalidBlock(6, 9, 6, 9, checkListBlock9, sudokuMatrix);
                            break;
                    }

                }
            }

            // checking invalid input
            bool doNotEnter = false;
            if (checkDuplicate(column1) || checkDuplicate(column2) || checkDuplicate(column3) || checkDuplicate(column4) ||
                checkDuplicate(column5) || checkDuplicate(column6) || checkDuplicate(column7) || checkDuplicate(column8) ||
                checkDuplicate(column9) || checkDuplicate(row1) || checkDuplicate(row2) || checkDuplicate(row3) || checkDuplicate(row4)
                || checkDuplicate(row5) || checkDuplicate(row6) || checkDuplicate(row7) || checkDuplicate(row8) || checkDuplicate(row9)
                || checkDuplicate(checkListBlock1) || checkDuplicate(checkListBlock2) || checkDuplicate(checkListBlock3)
                || checkDuplicate(checkListBlock4) || checkDuplicate(checkListBlock5) || checkDuplicate(checkListBlock6)
                || checkDuplicate(checkListBlock7) || checkDuplicate(checkListBlock8) || checkDuplicate(checkListBlock9))
            {
                doNotEnter = true;
                Console.WriteLine("Invalid input for Soduko");
            }
            if (doNotEnter)
            {
                Console.ReadLine();
                return;
            }

            // after checking Sudoku input 
            int repeat = 0;
            while (repeat < 50) // to make sure the matrix is solved
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (sudokuMatrix[i, j] != 0)
                        {
                            continue;
                        }
                        List<int> oneToNine = validInputs(i, j, sudokuMatrix); // check row and column
                        int block = getBlock(i, j);
                        switch (block)
                        {
                            case 1:
                                oneToNine = checkBlock(0, 3, 0, 3, oneToNine, sudokuMatrix);
                                break;
                            case 2:
                                oneToNine = checkBlock(0, 3, 3, 6, oneToNine, sudokuMatrix);
                                break;
                            case 3:
                                oneToNine = checkBlock(0, 3, 6, 9, oneToNine, sudokuMatrix);
                                break;
                            case 4:
                                oneToNine = checkBlock(3, 6, 0, 3, oneToNine, sudokuMatrix);
                                break;
                            case 5:
                                oneToNine = checkBlock(3, 6, 3, 6, oneToNine, sudokuMatrix);
                                break;
                            case 6:
                                oneToNine = checkBlock(3, 6, 6, 9, oneToNine, sudokuMatrix);
                                break;
                            case 7:
                                oneToNine = checkBlock(6, 9, 0, 3, oneToNine, sudokuMatrix);
                                break;
                            case 8:
                                oneToNine = checkBlock(6, 9, 3, 6, oneToNine, sudokuMatrix);
                                break;
                            case 9:
                                oneToNine = checkBlock(6, 9, 6, 9, oneToNine, sudokuMatrix);
                                break;
                        }
                        if (oneToNine.Count == 1)
                            sudokuMatrix[i, j] = oneToNine[0];
                    }
                }
                repeat++;
            }

            printHardSoduko(sudokuMatrix);
            printSudoku(sudokuMatrix);
        }
        static List<int> validInputs(int i, int j, int[,] sudokuMatrix) //check input for row and column
        {
            List<int> oneToNine = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };
            for (int x = 0; x < 9; x++)
            {
                int val = sudokuMatrix[i, x];
                if (oneToNine.Contains(val))
                    oneToNine.Remove(val);
            }
            for (int y = 0; y < 9; y++)
            {
                int val = sudokuMatrix[y, j];
                if (oneToNine.Contains(val))
                    oneToNine.Remove(val);
            }
            return oneToNine;
        }

        static int getBlock(int i, int j)
        {
            int block = 0;
            if (i < 3 && j < 3)
                block = 1;
            else if (i < 3 && j > 2 && j < 6)
                block = 2;
            else if (i < 3 && j > 5 && j < 9)
                block = 3;
            else if (i > 2 && i < 6 && j == 0 && j < 3)
                block = 4;
            else if (i > 2 && i < 6 && j > 2 && j < 6)
                block = 5;
            else if (i > 2 && i < 6 && j > 5 && j < 9)
                block = 6;
            else if (i > 5 && i < 9 && j == 0 && j < 3)
                block = 7;
            else if (i > 5 && i < 9 && j > 2 && j < 6)
                block = 8;
            else if (i > 5 && i < 9 && j > 5 && j < 9)
                block = 9;
            return block;
        }
        static List<int> checkBlock(int ifrom, int ito, int jfrom, int jto, List<int> oneToNine, int[,] sudo)
        {
            for (int i = ifrom; i < ito; i++)
            {
                for (int j = jfrom; j < jto; j++)
                {
                    int val = sudo[i, j];
                    if (oneToNine.Contains(val))
                        oneToNine.Remove(val);
                }
            }
            return oneToNine;
        }
        static List<int> checkInvalidBlock(int ifrom, int ito, int jfrom, int jto, List<int> checkListBlock, int[,] sudo)
        {
            checkListBlock = new List<int>();
            for (int i = ifrom; i < ito; i++)
            {
                for (int j = jfrom; j < jto; j++)
                {
                    if (sudo[i, j] != 0)
                    {
                        int val = sudo[i, j];
                        checkListBlock.Add(val);

                    }
                }
            }
            return checkListBlock;
        }
        static bool checkDuplicate(List<int> x)
        {
            bool duplicate = false;
            int count = 0;
            for (int i = 0; i < x.Count - 2; i++)
            {
                for (int j = i + 1; j < x.Count - 1; j++)
                {
                    if (x[i] == x[j])
                    {
                        count++;
                    }
                }

            }
            if (count > 0)
            {
                duplicate = true;
            }
            return duplicate;
        }
        static void printSudoku(int[,] sudokuMatrix)
        {
            for (int i = 0; i < 9; i++)              // for row
            {
                for (int j = 0; j < 9; j++)         // for column
                {

                    Console.Write(sudokuMatrix[i, j] + " ");
                    if (j == 8)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        static void printHardSoduko(int[,] sudokuMatrix)
        {
            for (int i = 0; i < 9; i++)              // for row
            {
                for (int j = 0; j < 9; j++)         // for column
                {
                    if (sudokuMatrix[i, j] == 0)
                    {
                        Console.WriteLine("\nSorry , i can't solve it and this is the best i can do\n\n");
                        return;
                    }
                }
            }
        }
    }
}
