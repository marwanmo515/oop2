using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal struct Person
    {
        #region att
        private string[]? Names;
        private int[]? Ages;
        private int Size;
        #endregion


        #region prop 
        //public string Name { get; set; }
        //public int Age { get; set; }
        //#endregion

        //#region constructor 

        //public Person(string name, int age)
        //{
        //    Name = name;
        //    Age = age;
        //}

        #endregion


        #region constructor 
        public Person(int size)
        {
            Names = new string[size];
            Ages = new int[size]; 
            Size = size;
        }


        #endregion



        #region method 
        public void AddPerson (int position , string name , int age )
        {
            Names[position] = name;
            Ages[position]= age;

        }


        #endregion


    }
}
