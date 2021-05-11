using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Content.obj
{
    class Clase
    {
        private string nombre;
        private string descripcion;
        private int bonusHp;
        private int bonusGolpe;
        private int bonusDamage;
        private List<int> habilidades;

        public Clase(string nombre, string descripcion, int bonusHp, int bonusGolpe, int bonusDamage)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.bonusHp = bonusHp;
            this.bonusGolpe = bonusGolpe;
            this.bonusDamage = bonusDamage;
            this.habilidades = new List<int>();
        }

        public void mostrarHabilidades(int nivel)
        {
            foreach(int h in this.habilidades)
            {
                /*
                if (h.GetNivelRequerido() <= nivel)
                {
                    Console.WriteLine(h.GetNombre() + ": " + h.GetDescripcion());
                }
                */
            }
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string GetDescripcion()
        {
            return this.descripcion;
        }

        public void SetBonusHP(int hp)
        {
            this.bonusHp = hp;
        }

        public int GetBonusHP()
        {
            return this.bonusHp;
        }

        public void SetBonusGolpe(int golpe)
        {
            this.bonusGolpe = golpe;
        }

        public int GetBonusGolpe()
        {
            return this.bonusGolpe;
        }

        public void SetBonusDamage(int damage)
        {
            this.bonusDamage = damage;
        }

        public int GetBonusDamage()
        {
            return this.bonusDamage;
        }

    }
}
