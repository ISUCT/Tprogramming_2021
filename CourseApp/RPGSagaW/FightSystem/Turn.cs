namespace RPGSagaW.FightSystem;
using RPGSagaW.Players;

public static class Turn
{
    public static int RandomFirstTurn()
    {
        return Random.Shared.Next(0, 1);
    }

    public static void ChangeTurn(ref int turn)
    {
        if (turn == 0)
        {
            turn = 1;
        }
        else
        {
            turn = 0;
        }
    }
}