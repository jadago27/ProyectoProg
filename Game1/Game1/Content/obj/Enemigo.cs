using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Content.obj
{
    class Enemigo : Entidad
    {
        private int id;
        private int exp;
        private int ratingDificultad;
        private int rangoVision;

        public Enemigo(int id, int exp, int dific,int rango, string nombre, int hp, int mov, int ca, int alcance, int golpe, int damage) 
            : base(nombre, hp, mov, ca, alcance, golpe, damage)
        {
            this.id = id;
            this.exp = exp;
            this.ratingDificultad = dific;
            this.rangoVision = rango;
        }

        public void SetID(int id)
        {
            this.id = id;
        }

        public int GetID()
        {
            return this.id;
        }

        public void SetExp(int exp)
        {
            this.exp = exp;
        }

        public int GetExp()
        {
            return this.exp;
        }

        public void SetRating(int rat)
        {
            this.ratingDificultad = rat;
        }

        public int GetRating()
        {
            return this.ratingDificultad;
        }

        public void SetRangoVision(int rango)
        {
            this.rangoVision = rango;
        }

        public int GetRangoVision()
        {
            return this.rangoVision;
        }

        public override string ToString()
        {
            return base.ToString()+"\nExperiencia:"+this.exp+"\nRatingDificultad:"+this.ratingDificultad+"\nRangoVision:"+this.rangoVision;
        }
    }
}
