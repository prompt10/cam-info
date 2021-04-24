using System;

namespace cam_info
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double flimBackWidth = 0, fLength, fov;

            while (flimBackWidth <= 0)
            {
                Console.WriteLine("Invalid flimBackWidth. Please input again");
                string flimBackWidthF = Console.ReadLine();
                flimBackWidth = Convert.ToDouble(flimBackWidthF);
            }
            if (mode == "fLength");
            {
                string fLengthF = Console.ReadLine();
                fLength = Convert.ToDouble(fLengthF);
                while (fLength <= 0)
                {
                    Console.WriteLine("Invalid fLength. Please input again");
                    fLengthF = Console.ReadLine();
                    fLength = Convert.ToDouble(fLengthF);
                }
                fov = 2 * Math.Atan(flimBackWidth / (2 * fLength));
                Console.WriteLine(("fLength = {0}, fov = {1}"),fLength,fov);
            }
            if (mode == "fov")
            {
                string fovF = Console.ReadLine();
                fov = Convert.ToDouble(fovF);
                while (fov <= 0.1 && fov > 6.28)
                {
                    Console.WriteLine("Invalid fov. Please input again");
                    fovF = Console.ReadLine();
                    fov = Convert.ToDouble(fovF);
                }
                fLength = flimBackWidth / (2 * Math.Tan(fov / 2));
                Console.WriteLine(("fLength = {0}, fov = {1}"), fLength, fov);
            }

        }
    }
}
