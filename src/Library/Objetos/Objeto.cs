using System;

namespace Library
{
    public class Objeto  // Creamos la clase y establecemos las properities
    {
        public int valorAtaque { get; set; } = 0;  
        
        public int valorDefensa { get; set; } = 0;
        
        public int Resistencia { get; set; } = 0;
        
        // A continuación le damos valor a los atributos

        public Item(int valor_ataque, int valor_defensa, int resistencia)
        {
            this.valorAtaque = valor_ataque;
            this.valorDefensa = valor_defensa;
            this.Resistencia = resistencia;
        }
        
    }
 }
