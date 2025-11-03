void main()
{
    HashMap<Point> hashMap = new HashMap<Point>(7, 7);
    Saver.DrawHashmap<Point>(hashMap, "hashmap");
    Saver.LinearInterpolationHashMap(hashMap, 10, 10);
}

main();