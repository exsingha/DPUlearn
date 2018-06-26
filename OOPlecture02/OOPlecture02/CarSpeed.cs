using System;
namespace OOPlecture02
{
    internal class CarSpeed
    {
        private int speed;
        public CarSpeed()
        {
            
        }
        public void Breaks()
        {
            speed = 0;
        }
        public void IncreaseSpeed()
        {
            speed++;
        }
        public void DecreaseSpeed()
        {
            speed--;
        }
        public int GetSpeed()
        {

            return speed;
        }
        public void SetSpeed(int speed)
        {
            this.speed = speed; // speed ตัวแรกเป็น parameter ของใน class, speed ตัวที่สองเป็นตัวที่รับเข้ามา
        }

    }
}