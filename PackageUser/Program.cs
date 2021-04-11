using System;

namespace PackageUser
{
    /*  ローカルのNuGetパッケージをプロジェクトに追加する
     *  
     *  Add a package with a local package file in 'dotnet'
     *    https://stackoverflow.com/questions/43400069/add-a-package-with-a-local-package-file-in-dotnet
     */
    class Program
    {
        static void Main(string[] args)
        {
            var cls = new MyPackage.PackageClass();

            Console.WriteLine(MyPackage.PackageClass.Message);

            var add = 10;
            Console.WriteLine($"(Value: {cls.Value}) + {add} = {cls.Add(10)}");
        }
    }
}
