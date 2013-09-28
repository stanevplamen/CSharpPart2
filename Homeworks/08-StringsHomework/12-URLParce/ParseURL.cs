using System;

class ParseURL
{
    static string Protocol(string fileName)
    {
        string protocol = String.Empty;
        int protIndex = fileName.IndexOf(@"://");
        if (protIndex != -1)
        {
            protocol = fileName.Substring(0, protIndex);
        }
        return protocol;
    }

    static string Server(string fileName)
    {
        string server = String.Empty;
        int servIndex = fileName.IndexOf(@"://");
        int indexOfSlash = fileName.IndexOf("/", servIndex + 3);
        if (servIndex != -1)
        {
            server = fileName.Substring(servIndex + 3, indexOfSlash - servIndex - 3);
        }
        return server;
    }

    static string Resourse(string fileName)
    {
        string resourse = String.Empty;
        int servIndex = fileName.IndexOf(@"://");
        int indexOfSlash = fileName.IndexOf("/", servIndex + 3);
        if (indexOfSlash != -1)
        {
            resourse = fileName.Substring(indexOfSlash);
        }
        return resourse;
    }

    static void Main()
    {
        string fileName = @"http://servername.com/username/collectionkey/sectionkey.extension";;

        string protocolOnly = Protocol(fileName);
        string serverOnly = Server(fileName);
        string resourseOnly = Resourse(fileName);
        Console.WriteLine("Parce with string searching:");
        Print(fileName, protocolOnly, serverOnly, resourseOnly);

        Uri uri = new Uri(fileName);
        Console.WriteLine("\n\nParce with URL class:");
        Print(uri.AbsoluteUri, uri.Scheme, uri.Authority, uri.PathAndQuery);
    }

    private static void Print(string fileName, string protocolOnly, string serverOnly, string resourseOnly)
    {
        Console.WriteLine("Full URL address: {0}", fileName);
        Console.WriteLine("Protocol:         {0}", protocolOnly);
        Console.WriteLine("Server:           {0}", serverOnly);
        Console.WriteLine("Resourse:         {0}", resourseOnly);
    }
}
