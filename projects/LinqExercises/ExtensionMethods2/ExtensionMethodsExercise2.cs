﻿namespace ExtensionMethods2
{
    // Write the extension method (and containing class) here,
    // following the example in the lesson. The method should
    // be called MakePlural(), extends string, takes an int
    // parameter, and returns a string.
    //
    // If the passed-in int is 1, then MakePlural() should
    // return the original string, unmodified. Otherwise, it
    // should return the string with an 's' appended to it.

    // public ... class ...
    // { }
    //// START SOLUTION ////
    public static class ThePluralClass
    {
        public static string MakePlural(this string str, int count)
        {
            return $"{str}{(count == 1 ? string.Empty : "s")}";
        }
    }
    //// END SOLUTION ////
}