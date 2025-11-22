void main()
{
    HashMap<Point> hashMap = new HashMap<Point>(32, 18);
    Saver.DrawHashmap(hashMap, "hashmap");
    Saver.SmootherStepInterpolationHashMap(hashMap, 1600, 900);
}

main();