using System;
namespace Ex0208
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun Pistol1= new Gun();
            Gun Pistol2= new Gun();
            Gun Pistol3=new Gun();
            Console.WriteLine(Pistol3.getGunCount()+ " guns have been created");
            Pistol1.Shoot();
            Pistol1.Shoot();
            Pistol1.Shoot();
            Pistol1.Shoot();
            Pistol2.Shoot();
            Pistol2.Shoot();
            Pistol3.Shoot();
            Pistol3.Shoot();
            Pistol3.Shoot();
            Console.WriteLine("You have shot "+Pistol1.getBulletCount()+ " bullets");
            Console.WriteLine("You have shot "+Pistol1.getShotsFired()+ " bullets");
            
            
        }
    }
}
