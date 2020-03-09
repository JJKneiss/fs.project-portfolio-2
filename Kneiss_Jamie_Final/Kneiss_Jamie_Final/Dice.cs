using System;
namespace Kneiss_Jamie_Final
{
    public class D4 : IDice
    {
        public D4()
        {
        }
        public int Sides(int sides)
        {
            sides = 4;
            return sides;
        }
        public int Roll(int roll)
        {
            return 1;
        }
    }
    public class D6 : IDice
    {
        public D6()
        {

        }
        public int Sides(int sides)
        {
            sides = 6;
            return sides;
        }
        public int Roll(int roll)
        {
            return 1;
        }
    }
    public class D8 : IDice
    {
        public D8()
        {

        }
        public int Sides(int sides)
        {
            sides = 8;
            return sides;
        }
        public int Roll(int roll)
        {
            return 1;
        }
    }
    public class D10 : IDice
    {
        public D10()
        {

        }
        public int Sides(int sides)
        {
            sides = 10;
            return sides;
        }
        public int Roll(int roll)
        {
            return 1;
        }
    }
    public class Percentile : IDice
    {
        public Percentile()
        {

        }
        public int Sides(int sides)
        {
            sides = 10;
            return sides;
        }
        public int Roll(int roll)
        {
            return 1;
        }
    }
    public class D12 : IDice
    {
        public D12()
        {

        }
        public int Sides(int sides)
        {
            sides = 12;
            return sides;
        }
        public int Roll(int roll)
        {
            return 1;
        }
    }
    public class D20 : IDice
    {
        public D20()
        {

        }
        public int Sides(int sides)
        {
            sides = 20;
            return sides;
        }
        public int Roll(int roll)
        {
            return 1;
        }
    }
    public interface IDice
    {
        int Sides(int sides);
        int Roll(int roll);
    }
}
