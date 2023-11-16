namespace CubeCheck {
  using System;
      public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            if (volume > 0 & side > 0)
            {
                if (Math.Pow(side, 3) == volume)
                {
                    return true;
                }
            }
            return false;
        }
    }
}