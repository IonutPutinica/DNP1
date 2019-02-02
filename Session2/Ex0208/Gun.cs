using System;

namespace Ex0208
{
    
     class Gun
    {
        private static int gunCount=0;
    private static int bulletCount=0;
    private int shotsFired=0;
    public Gun()
    {
        gunCount++;
    }
    public int getGunCount()
    {
        return gunCount;
    }
    public int getBulletCount()
    {
        return bulletCount;
    }
    public int getShotsFired()
    {
        return shotsFired;
    }

    public void Shoot()
    {
        bulletCount++;
        shotsFired++;
        Console.WriteLine("BANG!!!");
    }
    }
}