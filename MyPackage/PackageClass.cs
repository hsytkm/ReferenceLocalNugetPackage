using System;

namespace MyPackage
{
    public class PackageClass
    {
        public static string Message => "Hello. I'm nupkg.";

        public int Value { get; private set; } = 1;

        public int Add(int x)
        {
            Value += x;
            return Value;
        }
    }
}
