using System;
using System.Collections.Generic;
using System.Text;

namespace Game1.Content.obj
{
    class Habilidad
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        private int alcance;
        private int damage;
        private int area;
        private int nivelRequerido;

        public Habilidad(int codigo, string nombre, string descripcion, int alcance, int damage, int area, int nivel)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.alcance = alcance;
            this.damage = damage;
            this.area = area;
            this.nivelRequerido = nivel;
        }

        public Habilidad() { }

        public void SetCodigo(int cod)
        {
            this.codigo = cod;
        }

        public int GetCodigo() 
        {
            return this.codigo;
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

        public void SetAlcance(int alc)
        {
            this.alcance = alc;
        }

        public int GetAlcance()
        {
            return this.alcance;
        }

        public void SetDamage(int dmg)
        {
            this.damage = dmg;
        }

        public int GetDamage()
        {
            return this.damage;
        }

        public void SetArea(int area)
        {
            this.area = area;
        }

        public int GetArea()
        {
            return this.area;
        }

        public void SetNivelRequerido(int nivel)
        {
            this.nivelRequerido = nivel;
        }

        public int GetNivelRequerido()
        {
            return this.nivelRequerido;
        }
    }
}
