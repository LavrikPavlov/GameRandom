using System;

namespace GameRandom;

public class RandomGame 
{
    private int RandNumb;
    private int UserNumb;

    public int GetRandNumb()
    {
        Random RandomNumb = new Random();
        RandNumb =  RandomNumb.Next(0,1000);
        System.Console.WriteLine("Ваш копьютер загадл число");
        return RandNumb;
    }

    public int GetUserNumb()
    {
        System.Console.Write("Введите число: ");
        try
        {
             UserNumb = Convert.ToInt32(Console.ReadLine());
             Console.Clear();
        
                if(UserNumb < 0)
                {
                    System.Console.WriteLine("Число не должно быть меньше 0");
                    return GetUserNumb();
                }
                else if(UserNumb > 1000)
                {
                    System.Console.WriteLine("Число не должно быть не больше 1000");
                    return GetUserNumb();
                }
                else
                {
                    return UserNumb;
                }
        }
        catch(Exception)
        {
            System.Console.WriteLine("Вы велли не число");
            return GetUserNumb();
        }
    }
    public void BigMinNumb(int UserNumb, int RandNumb)
    {
        while (true)
        {
            if(RandNumb > UserNumb)
            {
                System.Console.WriteLine("Число загаданное компьюетором должно быть больше");
                UserNumb = GetUserNumb();
                BigMinNumb(UserNumb, RandNumb);
                break;
            }
            else if(RandNumb < UserNumb)
            {
                System.Console.WriteLine("Число загаданное компьюетором должно быть меньше");
                UserNumb = GetUserNumb();
                BigMinNumb(UserNumb, RandNumb);
                break;
            }
            else if(RandNumb == UserNumb)
            {
                System.Console.WriteLine("Вы угадали число");
                break;
            }
        }
    }

}