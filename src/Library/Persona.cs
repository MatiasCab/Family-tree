using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    //Clase persona, la cual tiene un atributo nombre y edad
    public class Persona
    {
        private string name;

        private int age;


        public Persona(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }        
    }
}
