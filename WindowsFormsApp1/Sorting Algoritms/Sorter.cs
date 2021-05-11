using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MultiToolApplication.Sorting_Algoritms
{
    class Sorter
    {
        private ArrayList Numbers = new ArrayList();



        public Sorter()
        {

        }

        public void AddNumbers()
        {
            for (int i = 1; i < 101; i++)
            {
                Numbers.Add(i);
            }
        }


    }

    


}
