﻿using System;
namespace RandomNumberGame
{
    class RandomNumberGame{
        static void Main(string[] args){
            Random random  = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess, number, guesses;
            String response;

            while(playAgain){
                guess = 0;
                guesses = 0;
                number = random.Next(min, max+1);
                response = "";

                while(guess!= number){
                    Console.WriteLine("Guess a number between " +min+ "- "+max+" :");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: "+guess);

                    if(guess > number){
                        Console.WriteLine("The number is lower than "+guess);
                    }else if(guess < number){
                        Console.WriteLine("The number is higher than" +guess);
                    }
                    guesses++;
                }
                Console.WriteLine("Number: "+number);
                Console.WriteLine("You win!!");
                Console.WriteLine("Guesses: "+guesses);
                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y"){
                    playAgain = true;
                }else{
                    playAgain = false;
                }

            }
            Console.WriteLine("Thanks for playing!......I guess");

            Console.ReadKey();

        
        }
    }
}