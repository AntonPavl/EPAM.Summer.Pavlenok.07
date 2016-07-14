using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libary;
using System.Collections;

namespace Library
{
    public static class BookExtension
    {
        public static Book[] SortBy(this Book[] arr,IComparer<Book> comparator)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (comparator.Compare(arr[i],arr[j]) > 0)
                    {
                        Book temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return null;
        }

    }
}
