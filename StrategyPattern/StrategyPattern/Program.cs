// See https://aka.ms/new-console-template for more information
using StrategyPattern;
using System.Security.Cryptography;

Character player1 = SelectPlayer();
Character player2 = SelectPlayer();

int rounds = 100;

for (int i = 0; i < rounds; i++)
{
    if (i % 2 == 0)
    {
        AttackSequence(player1, player2);
    }
    else
    {
        AttackSequence(player2, player1);
    }

    if (player1.Points <= 0 && player2.Points <= 0)
    {
        Console.WriteLine($"Players have killed each other! Nobody wins!");
        break;
    }
    else if (player1.Points <= 0)
    {
        Console.WriteLine($"Player 2: {player2.Name} wins!");
        Console.WriteLine($"Score: Player 2 ({player2.Name}) {player2.Points} | Player 1 ({player1.Name}) {player1.Points}");
        break;
    }
    else if (player2.Points <= 0)
    {
        Console.WriteLine($"Player 1: {player1.Name} wins!");
        Console.WriteLine($"Score: Player 1 ({player1.Name}) {player1.Points} | Player 2 ({player2.Name}) {player2.Points}");
        break;
    }
    else if (i == rounds - 1)
    {
        Console.WriteLine("100 Rounds complete with no deaths!");
        if (player1.Points > player2.Points)
            Console.WriteLine($"Player 1: {player1.Name} wins!");
        else if (player2.Points > player1.Points)
            Console.WriteLine($"Player 2: {player2.Name} wins!");
        else
            Console.WriteLine("It's a draw!");

        Console.WriteLine($"Score: Player 1 ({player1.Name}) {player1.Points} | Player 2 ({player2.Name}) {player2.Points}");
        break;
    }
}

Console.ReadKey();

static Character SelectPlayer()
{
    int character = RandomNumberGenerator.GetInt32(0, 4);

    switch (character)
    {
        case 0:
            return new Troll();
        case 1:
            return new Knight();
        case 2:
            return new Queen();
        default:
            return new King();
    }
}

static void AttackSequence(Character attackPlayer, Character defendPlayer)
{
    int? attack = attackPlayer.Fight();
    int? defend = defendPlayer.Defend();

    if (attack == null || defend == null)
        return;

    int total = attack.Value - defend.Value;

    if (total > 0)
    {
        if ((defendPlayer.Points - total) < 0)
            defendPlayer.Points = 0;
        else
            defendPlayer.Points -= total;

        Console.WriteLine($"Defense failed! {defendPlayer.Name} loses {total} points.");
    }
    else if (total < 0)
    {
        if ((attackPlayer.Points - total) < 0)
            attackPlayer.Points = 0;
        else
            attackPlayer.Points -= total;

        Console.WriteLine($"Attack blocked! {attackPlayer.Name} loses {total} points.");

    }
}
