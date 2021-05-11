using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Content.obj
{
    class Entidad
    {
        protected string nombre;
        protected int hp;
        protected int movimiento;
        protected int claseArmadura;
        protected int alcanceAtaque;
        protected int dadoGolpe;
        protected int dadoDamage;
        
        public Entidad(string nombre, int hp, int mov, int ca, int alcance, int golpe, int damage)
        {
            this.nombre = nombre;
            this.hp = hp;
            this.movimiento = mov;
            this.claseArmadura = ca;
            this.alcanceAtaque = alcance;
            this.dadoGolpe = golpe;
            this.dadoDamage = damage;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetHP(int hp)
        {
            this.hp = hp;
        }

        public int GetHP()
        {
            return this.hp;
        }

        public void SetMovimiento(int mov)
        {
            this.movimiento = mov;
        }

        public int GetMovimiento()
        {
            return this.movimiento;
        }

        public void SetCA(int ca)
        {
            this.claseArmadura = ca;
        }

        public int GetCA()
        {
            return this.claseArmadura;
        }

        public void SetAlcanceAtq(int alcance)
        {
            this.alcanceAtaque = alcance;
        }

        public int GetAlcanceAtq()
        {
            return this.alcanceAtaque;
        }

        public void SetDadoGolpe(int dado)
        {
            this.dadoGolpe = dado;
        }

        public int GetDadoGolpe()
        {
            return this.dadoGolpe;
        }

        public void SetDadoDamage(int dado)
        {
            this.dadoDamage = dado;
        }

        public int GetDadoDamage()
        {
            return this.dadoDamage;
        }

        public override string ToString()
        {
            return "Nombre:"+this.nombre+"\nPuntosVida:"+this.hp+"\nMovimiento:"+this.movimiento+"\nClaseArmadura:"+this.claseArmadura+"\nAlcanceAtaque:"
                    +this.movimiento+"\nDadoGolpe:"+this.dadoGolpe+"\nDadoDamage:"+this.dadoDamage;
        }
    }
}
