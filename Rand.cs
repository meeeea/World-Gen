class Rand
{
    public static Random random = new Random(1);

    public static double Random()
    {
        return random.NextDouble() + (-1 * random.NextInt64(0, 2));
    }

    public static int Random(int min, int max)
    {
        return (int) random.NextInt64(min, max);
    }
}