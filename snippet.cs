public static bool ValidCpeUriCheck(string str)
{
    string pattern = @"cpe:2\.3:[aho\*\-](:(((\?*|\*?)([a-zA-Z0-9\-\._]|(\\[\\\*\?!""#$$%&'\(\)\+,/:;<=>@\[\]\^`\{\|}~]))+(\?*|\*?))|[\*\-])){5}(:(([a-zA-Z]{2,3}(-([a-zA-Z]{2}|[0-9]{3}))?)|[\*\-]))(:(((\?*|\*?)([a-zA-Z0-9\-\._]|(\\[\\\*\?!""#$$%&'\(\)\+,/:;<=>@\[\]\^`\{\|}~]))+(\?*|\*?))|[\*\-])){4}";

    Match m = Regex.Match(str, pattern, RegexOptions.IgnoreCase);
    if (m.Success)
    {
        return true;
    }
    else
    {
        Console.WriteLine("{0} did not match Regex Requirement", str);
        return false;
    }
}
