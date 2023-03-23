namespace Qn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number in hero's gun: ");
            int hero_bullets = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number in Villan's gun: ");
            int villan_bullets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int h = 1;
            int v = 3;
            Console.WriteLine("Enter Who is shooting 0-Hero 1-Villan: ");
            // change from here
            int hero_count = 0;
            int villan_count = 0;
            while (true)
            {
                int shooter = Convert.ToInt32(Console.ReadLine());
                if (shooter == 0 && hero_bullets > h)
                {
                    hero_bullets--;
                    hero_count++;
                    Console.WriteLine($"Hero's {hero_count} Bullet is fired");
                    continue;
                }
                else if (shooter == 1 && villan_bullets > v)
                {
                    villan_bullets -= 3;
                    villan_count += 3;
                    Console.WriteLine($"Villan's {villan_count} Bullet is fired");
                    continue;
                }
                else
                {
                    if (hero_bullets <= 0)
                    {
                        Console.WriteLine("Villan Wins");

                    }

                    else
                    {
                        Console.WriteLine("Hero Wins");
                    }
                    break;
                }
            }
            /* while (hero_bullets > 0 || villan_bullets >0)
            {
            int shooter = Convert.ToInt32(Console.ReadLine());
                if (shooter == 0 && hero_bullets>=1)
                {
                    d += h;
                    Console.WriteLine($"Bullet {d} is fired");
                    pool -= h;
                    continue;
                }
                else if (shooter == 1 && pool>=3)
                {
                    d += v;
                    Console.WriteLine($"Bullet {d} is fired");
                    pool -= v;
                    continue;
                }
                else
                {
                    Console.WriteLine($"Not Sufficient bullets left for {shooter} ({init_pool-d})");
                    
                }
            }
            */

        }
    }
}