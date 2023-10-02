class Test
{
    public static void Main()
    {
        string path = @"D:\Programming guysss";
        DirectoryInfo Directory = new DirectoryInfo(path);
        Directory.Create();


        var initial = $@"{path}\Initial.txt";

        var final = $@"{path}\Final.txt";

        string hello = "hello guys";

        File.WriteAllText(initial, hello);
        File.Copy(initial, final);
        
    }
}
