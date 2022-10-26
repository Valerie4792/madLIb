string name1;
int age;
string favorite;
string worstFood;
string animal1;
string adj1;
string birthday;
string smell;
string zodiac;
string adj2;
bool playAgain = true;
string userAnswer;
bool valid1 = true;
bool valid2 = true;
bool valid3 = true;
bool valid4 = true;
bool valid5 = true;
bool valid6 = true;
bool valid7 = true;
bool valid8 = true;
bool valid9 = true;
bool next1 = true;

while (playAgain)
{
    Console.WriteLine("Hello! Let's do a Mad Lib.");
    Console.WriteLine("Please enter your name.");
    valid1 = false;

    while (!valid1)
    {

        name1 = Console.ReadLine();
        for (int i = 0; i < name1.Length; i++)
        {
            valid1 = char.IsLetter(name1[i]);
        }


        if (!valid1)
        {
            Console.WriteLine("Please type in a valid name containing letters only.");
        }
        else
        {
            valid1 = true;
        }

    }

    Console.WriteLine("How old are you?");
    valid2 = false;


    while (!valid2)
    {
        valid2 = int.TryParse(Console.ReadLine(), out age);

        if (!valid2)
        {
            Console.WriteLine("Please type in a valid age using digits");
        }
        else
        {
            valid2 = true;
        }


    }

    Console.WriteLine("What's your least favorite thing to do?");
    valid3 = false;

    while (!valid3)
    {
        favorite = Console.ReadLine();
        for (int i = 0; i < favorite.Length; i++)
        {
            valid3 = char.IsLetter(favorite[i]);
        }

        if (!valid3)
        {
            Console.WriteLine("Please enter an actual word containg letters only.");
        }
        else
        {
            valid3 = true;

        }
    }

    Console.WriteLine("What's your least favorite food?");
    valid4 = false;

    while (!valid4)
    {
        worstFood = Console.ReadLine();
        for (int i = 0; i < worstFood.Length; i++)
        {
            valid4 = char.IsLetter(worstFood[i]);

        }
        if (!valid4)
        {
            Console.WriteLine("Please type in a food item containing letters only.");
        }
        else
        {
            valid4 = true;
        }
    }

    Console.WriteLine("What's your least favorite animal?");
    valid5 = false;
    while (!valid5)
    {
        animal1 = Console.ReadLine();
        for (int i = 0; i < animal1.Length; i++)
        {
            valid5 = char.IsLetter(animal1[i]);
        }
        if (!valid5)
        {
            Console.WriteLine("Please type in an animal. Must contain letters only.");
        }
        else
        {
            valid5 = true;
        }

    }

    Console.WriteLine("Please type in an ajdective");
    valid6 = false;
    while (!valid6)
    {
        adj1 = Console.ReadLine();
        for (int i = 0; i < adj1.Length; i++)
        {
            valid6 = char.IsLetter(adj1[i]);
        }
        if (!valid6)
        {

            Console.WriteLine("Please type in a word containing letters only.");
        }
        else
        {
            valid6 = true;
        }

    }


    Console.WriteLine("Type in a smell or scent.");
    valid7 = false;
    while (!valid7)
    {
        smell = Console.ReadLine();
        for (int i = 0; i < smell.Length; i++)
        {
            valid7 = char.IsLetter(smell[i]);
        }
        if (!valid7)
        {
            Console.WriteLine("Please type in a word containing letters only.");
        }
        else
        {
            valid7 = true;
        }

    }


    Console.WriteLine("Type in your birthday (month and day only)");
    birthday = Console.ReadLine();
   


    Console.WriteLine("What is your zodiac sign");
    valid8 = false;
    while(!valid8)
    {   
        zodiac = Console.ReadLine();
        for(int i = 0; i < zodiac.Length; i++)
        {
            valid8 = char.IsLetter(zodiac[i]);
        }
        if(!valid8)
        {
            Console.WriteLine("Please type in a word containing letters only.");
        }
        else
        {
            valid8 = true;
        }

    }
   

    Console.WriteLine("Type in a descriptive word or an adjective.");
    valid9 = false;
    
    while(!valid9)
    {
        adj2 = Console.ReadLine();
        for(int i = 0; i < adj2.Length; i++)
        {
            valid9 = char.IsLetter(adj2[i]);

        }
        if(!valid9)
        {
             Console.WriteLine("Please type in a word containing letters only.");
        }
        else
        {
            valid9 = true;
        }

    }
    


    Console.WriteLine($"Hello! My name is {name1}. A little about me: I am {age} years old. My favorite thing to do is {favorite}. If I was stuck on an island and could bring only one thing to eat every day, I would bring my all time favorite, {worstFood}. I cannot live without it. Another fun fact, If I could be any animal, I would choose to be a/an {animal1} because they are my spirit animal and are just so {adj1}. They smell like {smell}. Also, in case you were wondering, my birthday is {birthday} and my zodiac sign is {zodiac}, so that explains why I am the way that I am, {adj2}.  ");

    Console.WriteLine("Would you like to play again?");
    userAnswer = Console.ReadLine().ToUpper();

    if (userAnswer == "YES")
    {
        playAgain = true;
    }

    else
    {
        playAgain = false;
    }

}



