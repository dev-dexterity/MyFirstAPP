using System.ComponentModel.DataAnnotations;

namespace MyFirstAPP
{
    class Box
    {
        //member variables
        private int length = 3;
        private int height;
        //public int width;
        private int volume;

        //Third method to use Properties and the most efficient way.
        public int Width { get; set; }

        public Box(int length, int height, int width)
        {
            this.length = length;
            Height = height;
            Width = width;
        }
        
        public int Volume
        {
            get
            {
                return this.length * this.Height * this.Width;
            }
        }


        //Second method to use Properties
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = -value;
                else
                    height = value;
            }
        }

        //First Method to use Properties
        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }


        public void DisplayInfo()
        {
            Console.WriteLine("length is {0} and height is {1} and width is {2} so the volume is {3} ", 
                length, height, Width, volume = length * height * Width);
        }


    }
}