using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Game1.Content.obj
{
    class Personaje : Entidad
    {
        private int nivel;
        private int expAcumulada;
        private Clase clase;
        private List<int> habilidadesAprendidas;

        public Personaje(int nivel, int exp, Clase clase, List<int> habilidades, string nombre, int hp, int mov, int ca, int alcance, int golpe, int damage)
            : base(nombre, hp, mov, ca, alcance, golpe, damage)
        {
            this.nivel = nivel;
            this.expAcumulada = exp;
            this.clase = clase;
            this.habilidadesAprendidas = habilidades;
        }

        private string stringHabilidades()
        {
            string lista="";
            foreach(int h in this.habilidadesAprendidas)
            {
                lista += ""+h+",";
            }
            return lista;
        }

        public void SubidaNivel()
        {
            this.nivel++;
            this.expAcumulada = 0;
            this.hp += this.clase.GetBonusHP();
        }

        public void CargarPersonaje(string nombre)
        {
            StreamReader fichero;
            string linea;
            
            try
            {
                fichero = File.OpenText("Char"+nombre+".txt");
                linea = fichero.ReadLine();
                this.SetNombre(extraerInfo(linea));
                linea = fichero.ReadLine();
                this.SetHP(Convert.ToInt32(extraerInfo(linea)));
                linea = fichero.ReadLine();
                this.SetMovimiento(Convert.ToInt32(extraerInfo(linea)));
                linea = fichero.ReadLine();
                this.SetCA(Convert.ToInt32(extraerInfo(linea)));
                linea = fichero.ReadLine();
                this.SetAlcanceAtq(Convert.ToInt32(extraerInfo(linea)));
                linea = fichero.ReadLine();
                this.SetDadoGolpe(Convert.ToInt32(extraerInfo(linea)));
                linea = fichero.ReadLine();
                this.SetDadoDamage(Convert.ToInt32(extraerInfo(linea)));
                linea = fichero.ReadLine();
                this.SetNivel(Convert.ToInt32(extraerInfo(linea)));
                linea = fichero.ReadLine();
                this.SetExpAcumulada(Convert.ToInt32(extraerInfo(linea)));
                fichero.Close();

            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Nombre demasiado largo!");
            }
        }

        public void GuardarPersonaje()
        {
            StreamWriter fichero;
            try
            {
                fichero = File.CreateText("Char"+this.nombre+".txt");
                fichero.WriteLine(this.ToString());
                fichero.Close();
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Nombre demasiado largo!");
            }
        }

        public void SetNivel(int nivel)
        {
            this.nivel = nivel;
        }

        public int GetNivel()
        {
            return this.nivel;
        }

        public void SetExpAcumulada(int exp)
        {
            this.expAcumulada = exp;
        }

        public int GetExpAcumulada()
        {
            return this.expAcumulada;
        }

        public void SetClase(Clase c)
        {
            this.clase = c;
        }

        public Clase GetClase()
        {
            return this.clase;
        }

        public void SetHabilidades(List<Habilidad> list)
        {
            this.habilidadesAprendidas = list;
        }

        public List<Habilidad> GetHabilidadesAprendidas()
        {
            return this.habilidadesAprendidas;
        }

        public void AddHabilidadAprendida(Habilidad h)
        {
            this.habilidadesAprendidas.Add(h);
        }

        public void PrintHabilidadesAprendidas()
        {
            foreach(Habilidad h in this.habilidadesAprendidas)
            {
                h.ToString();
            }
        }

        private string extraerInfo(string s)
        {
            return s.Split(':')[1];
        }

        public override string ToString()
        {
            return base.ToString()+"\nNivel:"+this.nivel+"\nExperienciaAcumulada:"+this.expAcumulada+"\nClase:"+this.clase.GetNombre()+"\nHabilidades:"+stringHabilidades();
        }
    }
}
