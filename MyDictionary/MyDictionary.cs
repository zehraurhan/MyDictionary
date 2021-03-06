﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    {
    public class MyDictionary<TKeys, TValues>
    {
        TKeys[] Keys;
        TValues[] Values;

        public MyDictionary()
        {
            Keys = new TKeys[0];
            Values = new TValues[0];
        }

        public void Add(TKeys key, TValues value)
        {
            TKeys[] tempArray1 = Keys;
            TValues[] tempArray2 = Values;

            Keys = new TKeys[Keys.Length + 1];
            Values = new TValues[Values.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                Keys[i] = tempArray1[i];
                Values[i] = tempArray2[i];
            }

            Keys[Keys.Length - 1] = key;
            Values[Values.Length - 1] = value;

            tempArray1 = new TKeys[0];
            tempArray2 = new TValues[0];

        }

        public int Count { get => Keys.Length; }
    }
}
