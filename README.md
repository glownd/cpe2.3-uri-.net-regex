# cpe2.3-uri-.net-regex
The proper Regex to verify the CPE2.3 standard against a cpe2.3uri in C#.  This has been tested against the NIST CPE Match Feed on October 13th, 2021.

string pattern = @"cpe:2\.3:[aho\*\-](:(((\?*|\*?)([a-zA-Z0-9\-\._]|(\\[\\\*\?!""#$$%&'\(\)\+,/:;<=>@\[\]\^`\{\|}~]))+(\?*|\*?))|[\*\-])){5}(:(([a-zA-Z]{2,3}(-([a-zA-Z]{2}|[0-9]{3}))?)|[\*\-]))(:(((\?*|\*?)([a-zA-Z0-9\-\._]|(\\[\\\*\?!""#$$%&'\(\)\+,/:;<=>@\[\]\^`\{\|}~]))+(\?*|\*?))|[\*\-])){4}";

Match m = Regex.Match(str, pattern, RegexOptions.IgnoreCase);
if (m.Success)
{
  //Return True or Do Something...
  return true;
}
else
{
  Console.WriteLine("{0} did not match Regex Requirement", str);
  return false;
}
