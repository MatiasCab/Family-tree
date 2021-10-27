using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    // Creo una clase abstracta Visitor de la cual van a heredar todas aquellas clses que interactuen con node de manera directa
    public abstract class Visitor 
    {
        public int AgeTotal
        {
            get
            {
                return this.TotalAge;
            }
        }

        protected int TotalAge {get; set;} = 0; //Guardo el total de la edad

        public string LongestName
        {
            get
            {
                return this.LongName;
            }
        }

        protected string LongName {get; set;} = ""; //guardo el nombre mas largo

        public int OldSon
        {
            get
            {
                return this.OldSonAge;
            }
        }
        protected int OldSonAge {get; set;} = 0;//aca guardo la edad del node hijo mayor
        public abstract void Visit(Node node);//El metodo visit es abstracto porque las distintas clases que heradan de node, pueden tener distintas implementaciones del metodo, dependiendo del labor a ejecutar
    }
}
