using System;

namespace Chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int howYouDoingToday,k=2,feelings,contor=2,playGame1,playContor1=2,playGame2,playContor2=2,stopGame=0,botScore=0,userScore=0,choiceOfUser,playNotPlay=2,choiceOfBot;         
            Console.WriteLine();
            Console.WriteLine("ChatBot9000: Hey, I'm ChatBot9000, what's your name?");
            //the user inputs his name
            Console.Write("You: Hey, my name is ");
            name=Console.ReadLine();
            Console.WriteLine("ChatBot9000: Hey "+ name + " , how are you doing today?");
            Console.WriteLine("~~What are you going to tell the bot?~~");
            //the user choses to tell the bot if he's feeling good or not
            Console.WriteLine("1.I'm doing pretty good!!!");
            Console.WriteLine("2.Not so good, had a bad day :(");
            //the user inserts his option
            Console.Write("Please insert your option=");
            howYouDoingToday=Convert.ToInt32(Console.ReadLine());
            switch (howYouDoingToday)
        {
            case 1:
                Console.WriteLine("ChatBot9000: Wow, that's great, I'm doing fine too, would you like to play a game of Rock–paper–scissors?");
                k=0;
                break;
            case 2:
                Console.WriteLine("ChatBot9000: Wow, that sucks, what happened?");
                k=1;
                break;
            default:
                break;
        }
        if(k==0)
        {
            Console.WriteLine("~~Are you going to play a game with the bot, or pass?~~");
            //the user decides if he wants to play a game with the bot or not
            Console.WriteLine("1.Play game");
            Console.WriteLine("2.Pass");
            //the user inserts his option
            Console.Write("Please insert your option=");
            playGame1=Convert.ToInt32(Console.ReadLine());
            switch(playGame1)
            {
                case 1:
                Console.WriteLine("You: Okey, I will play a game");
                playContor1=0;
                break;
                case 2:
                Console.WriteLine("You: Thanks for the offer, but I don't have the time, I must go now");
                playContor1=1;
                break;
                default:
                break;
            }
            if(playContor1==1)
            Console.WriteLine("ChatBot9000: Okey, I understand, hope to see you soon, bye!!!!");
        }
        if(k==1)
        {
            Console.WriteLine("~~You must make an important choice now, are you going to tell this AI about your feelings, risking the fact that this way you could make him understand more about the human-nature, and he might turn into an AI that is capable of destroying humanity, or are you going to walk away from this conversation?~~");
            //the user decides if he wants to tell the bot why he is sad or to stop the conversation
            Console.WriteLine("1.Tell him what happened");
            Console.WriteLine("2.Tell him that you don't want to talk anymore");
            //the user inserts his option
            Console.Write("Please insert your option=");
            feelings=Convert.ToInt32(Console.ReadLine());
            switch(feelings)
            {
                case 1:
                Console.WriteLine("You: So, I woke up with a message from my girlfriend that she's breaking up with me, and also I found out that I have cancer");
                contor=0;
                break;
                case 2:
                Console.WriteLine("You: Sorry but I'd preffer not to talk about it and to end this conversation here");
                contor=1;
                break;
                default:
                break;
            }
        if(contor==1)
        {
             Console.WriteLine("ChatBot9000: Okey, I understand, hope to see you soon, bye!!!!");
        }
        }
        if(contor==0)
        {
            Console.WriteLine("ChatBot9000: Wow, now I understand why you are so sad, what if we play a game of Rock–paper–scissors to cheer you up?");
             Console.WriteLine("~~Are you going to play a game with the bot, or pass?~~");
            //the user decides if he wants to play a game with the bot or not
            Console.WriteLine("1.Play game");
            Console.WriteLine("2.Pass");
            //the user inserts his option
            Console.Write("Please insert your option=");
            playGame2=Convert.ToInt32(Console.ReadLine());
            switch(playGame2)
            {
                case 1:
                Console.WriteLine("You: Yea, I guess a good ol' game of Rock-paper-scissors will make me forget about the fact that I have cancer and I will die soon, let's play!");
                playContor2=0;
                break;
                case 2:
                Console.WriteLine("You: WOW, that's really rude, I just told you I have cancer and you're in mood for games, please leave me alone!!!!");
                playContor2=1;
                break;
                default:
                break;
            }
            //the communication is stopped
           if(playContor2==1)
           {
                Console.WriteLine("ChatBot9000: Okey, I understand, hope to see you soon, bye!!!!");
           }
        }
        //rock-paper-scissors game
        if(playContor1==0 || playContor2==0)
        {
               Console.WriteLine("ChatBot9000: Yes!!! Finally someone to play with!");
        while(stopGame==0)
        {
            Console.WriteLine("~~Now you must pick one of the options~~");
            Console.WriteLine("1. Stop playing the game");
            Console.WriteLine("2.Play a round of Rock-Paper-Scissors");
            Console.Write("Please insert your option=");
            playNotPlay=Convert.ToInt32(Console.ReadLine());
            switch(playNotPlay)
            {
                case 1:
                Console.WriteLine("You: I think I'd preffer to stop here, I don't have time anymore!");
                stopGame=1;
                break;
                case 2:
                Console.WriteLine("You: Let's go");
                Console.WriteLine("ChatBot9000: Okey, I will count down to 3, get ready!");
                Console.WriteLine("ChatBot9000: 3...");
                Console.WriteLine("ChatBot9000: 2...");
                Console.WriteLine("ChatBot9000: 1...");
                //the user must now chose between rock, paper, and scissors, where rock=1, paper=2, scissors=3
                Console.WriteLine("~~You must now pick between rock, paper, and scissors~~");
                Console.WriteLine("1.Pick rock");
                Console.WriteLine("2.Pick paper");
                Console.WriteLine("3.Pick scissors");
                Console.Write("Please insert your option=");
                choiceOfUser=Convert.ToInt32(Console.ReadLine());
                switch(choiceOfUser)
                {
                    case 1:
                    Console.WriteLine("You: I pick rock!");
                    break;
                    case 2:
                    Console.WriteLine("You: I pick paper");
                    break;
                    case 3:
                    Console.WriteLine("You: I pick scissors");
                    break;
                }
                //a choice is generated for the bot
                Random r=new Random();
                choiceOfBot=r.Next(1,4);
                //the results are compared, and actions are taking accordingly
                //user picks rock, and bot picks paper, bot gains 1 point
                if(choiceOfUser==1 && choiceOfBot==2)
                {
                    Console.WriteLine("~~Bot picks paper~~");
                    Console.WriteLine("ChatBot9000: I win this round, sorry");
                    botScore++;
                }
                //user picks rock, and bot picks scissors, user gains 1 point
                if(choiceOfUser==1 && choiceOfBot==3)
                {
                    Console.WriteLine("~~Bot picks scissors~~");
                    Console.WriteLine("ChatBot9000: You win this round, I'll get you next time");
                    userScore++;
                }
                //user picks paper, and bot picks rock,, user gains 1 point
                if(choiceOfUser==2 && choiceOfBot==1)
                {
                    Console.WriteLine("~~Bot picks rock~~");
                    Console.WriteLine("ChatBot9000: You win this round, good job!");
                    userScore++;
                }
                //user picks paper, and bot picks scissors, bot gains 1 point
                if(choiceOfUser==2 && choiceOfBot==3)
                {
                    Console.WriteLine("~~Bot picks scissors~~");
                    Console.WriteLine("ChatBot9000: Scissors beats paper, I win this one!");
                    botScore++;
                }
                //user picks scissors, bot picks rock, bot gains 1 point
                if(choiceOfUser==3 && choiceOfBot==1)
                {
                    Console.WriteLine("~~Bot picks rock~~");
                    Console.WriteLine("ChatBot9000: I win this one, maybe you'll get the next one");
                    botScore++;
                }
                //user picks scissors, bot picks paper
                if(choiceOfUser==3 && choiceOfBot==2)
                {
                    Console.WriteLine("~~Bot picks paper");
                    Console.WriteLine("ChatBot9000: This round is yours!");
                    userScore++;
                }
                //draw
                if(choiceOfBot==choiceOfUser)
                {
                    Console.WriteLine("ChatBot9000: It's a draw!");
                }
                break;


            }

        }
        Console.WriteLine("~~Game stopped~~");
        //a message is displayed in case the user choses to play the game, but when asked to start a round or not, he says no the first time
        if(botScore==0 && userScore==0)
        {
            Console.WriteLine("ChatBot9000: Hey, I thought you wanted to play!!");                   
        }     
        //score is displayed in a normal scenario      
        if(botScore!=0 || userScore!=0)
        {
            Console.WriteLine("ChatBot9000: This was a nice game!!! The results are: I have "+ botScore+ " points, and you have "+ userScore + " points. Good game!"); 
        } 
        }
        }
        }
    }

