﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace genericintro
{
    class Mylist<T>
    {
        T[] items;
        //Constructor
        public Mylist()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] temparray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < temparray.Length; i++)
            {
                items[i] = temparray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
