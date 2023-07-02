using System;
using System.Threading;

namespace GameRandom;

class GameMain
{
    public static void Main()
    {
        RandomGame Game = new RandomGame();
        int RandNumb = Game.GetRandNumb();
        int UserNumb = Game.GetUserNumb();

        Game.BigMinNumb(UserNumb,RandNumb);
        Thread.Sleep(2000);

    }
}
