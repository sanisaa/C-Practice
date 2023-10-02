using System;
namespace RockPaperScissor
{
    class RockPaperScissor{
        static void Main(string[] args){
            Random random  = new Random();
            bool playAgain = true;
            String player, computer, answer;
            
            while(playAgain){
                player = "";
                computer = "";
                answer = "";
                while(player != "ROCK" && player != "PAPER" && player != "SCISSORS"){
                Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
                }

                switch(random.Next(1, 4)){
                    case 1:
                        computer = "ROCK";
                        break;
                   case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: "+player);
                Console.WriteLine("computer: "+computer);

                switch(player){
                    case "ROCK":
                        if(computer == "ROCK"){
                            Console.WriteLine("It's a draw");
                        }else if(computer == "PAPER"){
                            Console.WriteLine("You lose!");
                        }else{
                            Console.WriteLine("You Win!");
                        }
                        break;
                    case "PAPER":
                          if(computer == "ROCK"){
                            Console.WriteLine("You win!");
                        }else if(computer == "PAPER"){
                            Console.WriteLine("It's a draw!");
                        }else{
                            Console.WriteLine("You Lose!");
                        }
                        break;
                    case "SCISSORS":
                          if(computer == "SCISSORS"){
                            Console.WriteLine("It's a draw");
                        }else if(computer == "ROCK"){
                            Console.WriteLine("You lose!");
                        }else{
                            Console.WriteLine("You Win!");
                        }
                        break;    
                }
                Console.WriteLine("Would you like to play again (Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if(answer == "Y"){
                    playAgain = true;
                }else{
                    playAgain = false;
                    
                }
            }

           
            Console.WriteLine("Thanks for playing!....Rock Paper Scissor");

            Console.ReadKey();

        
        }
    }
}