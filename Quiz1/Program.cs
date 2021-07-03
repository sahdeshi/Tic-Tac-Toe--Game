/*
 Name - Shivam Sahdev
 Class - 42329
 Studen ID = 991411814*/
using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            char decide = ' ';// Condition for do while loop 
            do { 
           
            char player = 'O';// first player is starting the game with 'O'
            char[,] board = new char[3, 3];// This is 2D array
            Boolean game = true; // condition for while loop 
            int turnes = 0;


                while (game == true) // while loop is used so that player can input different values 
                {


                    Console.Clear();

                    // To Print the basic board for Positions
                    Console.WriteLine("Tic Tac Toe Game \nThese are the positions, select any position");
                    Console.WriteLine(" ");
                    Console.WriteLine("  " + "(row 0 column 0)" + " | " + "(row 0 column 1)" + " | " + "(row 0 column 2)");
                    Console.WriteLine("-------------------+------------------+-------------------");
                    Console.WriteLine("  " + "(row 1 column 0)" + " | " + "(row 1 column 1)" + " | " + "(row 1 column 2)");
                    Console.WriteLine("-------------------+---------+--------+-------------------");
                    Console.WriteLine("  " + "(row 2 column 0)" + " | " + "(row 2 column 1)" + " | " + "(row 2 column 2)");

                    // To print the playing board
                    boardPrinting(board);
                    Console.WriteLine("\n");

                    // To enter the row value from 0 -2
                    Console.Write("Please Enter the Row number from (0 - 2): ");
                    int row = int.Parse(Console.ReadLine());

                    // To enter the column value from 0 -2
                    Console.Write("Please Enter the Column number from (0 - 2): ");
                    int column = int.Parse(Console.ReadLine());

                    // This will input 'O' value at the position selected by the player
                    board[row, column] = player;

                    //  To check if any player won the game, if someone won the while loop breaks.
                    
                    if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                    {
                        Console.Clear();
                        game = false;
                         
                        Console.WriteLine(player + " has won the game");
                        Console.WriteLine("Thank you for playing \n Do you want to play another game ? ");
                        Console.WriteLine("Enter 'y' to play another game or 'n' to exit");
                        decide = char.Parse(Console.ReadLine());

                       
                       
                    }
                    else if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                    {
                        Console.Clear();
                        game = false;
                        Console.WriteLine(player + " has won the game");
                        Console.WriteLine("Thank you for playing \n Do you want to play another game ? ");
                        Console.WriteLine("Enter 'y' to play another game or 'n' to exit");
                        decide = char.Parse(Console.ReadLine());
                    }
                    else if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                    {
                        Console.Clear();
                        game = false;
                        Console.WriteLine(player + " has won the game");
                        Console.WriteLine("Thank you for playing \n Do you want to play another game ? ");
                        Console.WriteLine("Enter 'y' to play another game or 'n' to exit");
                        decide = char.Parse(Console.ReadLine());
                    }
                    else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                    {
                        Console.Clear();
                        game = false;
                        Console.WriteLine(player + " has won the game");
                        Console.WriteLine("Thank you for playing \n Do you want to play another game ? ");
                        Console.WriteLine("Enter 'y' to play another game or 'n' to exit");
                        decide = char.Parse(Console.ReadLine());


                    }
                    else if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                    {
                        Console.Clear();

                        game = false;
                        Console.WriteLine(player + " has won the game");
                        Console.WriteLine("Thank you for playing \n Do you want to play another game ? ");
                        Console.WriteLine("Enter 'y' to play another game or 'n' to exit");
                        decide = char.Parse(Console.ReadLine());
                    }
                    else if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                    {
                        Console.Clear();
                        game = false;
                        Console.WriteLine(player + " has won the game");
                        Console.WriteLine("Thank you for playing \n Do you want to play another game ? ");
                        Console.WriteLine("Enter 'y' to play another game or 'n' to exit");
                        decide = char.Parse(Console.ReadLine());
                    }
                    else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                    {
                        Console.Clear();
                        game = false;
                        Console.WriteLine(player + " has won the game");
                        Console.WriteLine("Thank you for playing \n Do you want to play another game ? ");
                        Console.WriteLine("Enter 'y' to play another game or 'n' to exit");
                        decide = char.Parse(Console.ReadLine());
                    }
                    else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                    {
                        Console.Clear();
                        game = false;
                        Console.WriteLine(player + " has won the game");
                        Console.WriteLine("Thank you for playing \n Do you want to play another game ? ");
                        Console.WriteLine("Enter 'y' to play another game or 'n' to exit");
                        decide = char.Parse(Console.ReadLine());
                    }
                    else if (player == board[2, 0] && player == board[1, 1] && player == board[0, 2])
                    {
                        Console.Clear();
                        game = false;
                        Console.WriteLine(player + " has won the game");
                        Console.WriteLine("Thank you for playing \n Do you want to play another game ? ");
                        Console.WriteLine("Enter 'y' to play another game or 'n' to exit");
                        decide = char.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Press Enter to enter the value in the board");
                    }

                    // reference to change the turnes
                    player = playerChange(player);

                    /*To check if the total turnes are greater than 9 or the wile loop is running 9 times because after 9 time the game is a draw.  */
                    turnes += 1;
                    if (turnes == 9)
                    {
                        Console.Clear();
                        game = false;
                        Console.WriteLine("The Game is a Draw");
                        Console.WriteLine("Thank you for playing \n Do you want to play another game ? ");
                        Console.WriteLine("Enter 'y' to play another game or 'n' to exit");
                        decide = char.Parse(Console.ReadLine());
                        
                    }


                }
            } while (decide == 'y');


        }
        static char playerChange(char thePlayer)
        {
            /*This will change the player, it will check if the player is at 'O' and return 'X' otherwise return 'O'*/
            if (thePlayer == 'O')
            {
                return  'X';
            }
            else
            
                return  'O';
            
        }
       
       static void boardPrinting(Char[, ] board)
        {
            // This is the Board For Tic Tac Toe
            Console.WriteLine(" \nThis is the Game Board");
            Console.WriteLine(" ");
            Console.WriteLine("  " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2]);
            Console.WriteLine("----+---+----");
            Console.WriteLine("  " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2]);
            Console.WriteLine("----+---+----");
            Console.WriteLine("  " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2]);
        }
    }
    }

