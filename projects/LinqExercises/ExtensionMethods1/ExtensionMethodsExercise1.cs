﻿namespace ExtensionMethods1
{
    // Write the extension method (and containing class) here,
    // following the example in the lesson. The method should
    // be called SayHello(), extends string, and returns a string.

    // public ... class ...
    // { }
    //// START SOLUTION ////
    public static class TheHelloClass
    {
        public static string SayHello(this string str)
        {
            return $"Hello, {str}!";
        }
    }
    //// END SOLUTION ////
}