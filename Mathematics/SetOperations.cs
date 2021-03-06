﻿using System;
using System.Collections.Generic;

namespace BGC.Mathematics
{
    public static class SetOperations
    {
        /// <summary>
        /// Finds the list intersection between two lists where each repeated value is unique
        /// Intersection is the Or operation
        /// </summary>
        public static List<T> Intersection<T>(this List<T> a, List<T> b)
        {
            Dictionary<T, bool> usedValues = new Dictionary<T, bool>();
            List<T> result = new List<T>();

            for (int i = 0; i < a.Count; ++i)
            {
                if (usedValues.ContainsKey(a[i]) == false)
                {
                    usedValues.Add(a[i], true);
                    result.Add(a[i]);
                }
            }

            for (int i = 0; i < b.Count; ++i)
            {
                if (usedValues.ContainsKey(b[i]) == false)
                {
                    usedValues.Add(a[i], true);
                    result.Add(b[i]);
                }
            }

            return result;
        }

        /// <summary>
        /// Finds the list union between two lists where each repeated value is unique
        /// Union is the And operation
        /// </summary>
        public static List<T> Union<T>(this List<T> a, List<T> b)
        {
            return a.Union(b);
        }
    }
}
