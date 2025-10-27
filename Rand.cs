class Rand
{
    public static Random random = new Random();

    public static double Random()
    {
        return random.NextDouble() + (-1 * random.NextInt64(0, 2));
    }
}