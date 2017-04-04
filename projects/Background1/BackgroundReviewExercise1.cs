﻿using System.Collections.Generic;

namespace Background1
{
    // Uncomment the TransformationFunction delegate declaration
    //
    // following the examples in the lessons, declare the type
    // TransformationFunction as a delegate that takes a single
    // int parameter and returns an int result.

    // public ... TransformationFunction ...

    public static class BackgroundReviewExercise1
    {
        public static IEnumerable<int> DoTransform(IEnumerable<int> data, TransformationFunction func)
        {
            return data.Transform(func);
        }
    }

    // Write the extension method (and containing class) here,
    // following the examples in the lessons. The method should
    // be called Transform(), extends IEnumerable<int>, and
    // returns an IEnumerable<int>.

    // public ... class ...
    // { }

}