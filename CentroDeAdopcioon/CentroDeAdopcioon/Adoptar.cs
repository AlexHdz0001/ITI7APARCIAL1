using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeAdopcioon
{
    class Adoptar
    {
        private long NumeroAdopcion;
        private string Mascota;
        private double Peso;
        private double Altura;
        private string Nombre;

        public Adoptar(long numeroAdopcion, string mascota, double peso, double altura, string nombre)
        {
            this.NumeroAdopcion = numeroAdopcion;
            this.Mascota = mascota;
            this.Peso = peso;
            this.Altura = altura;
            this.Nombre = nombre;
        }

        public void SetNumeroAdopcion(long numeroAdopcion)
        {
            this.NumeroAdopcion = numeroAdopcion;
        }

        public void SetMascota(string mascota)
        {
            this.Mascota = mascota;
        }

        public void SetPeso(double peso)
        {
            this.Peso = peso;
        }

        public void SetAltura(double altura)
        {
            this.Altura = altura;
        }

        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public long GetNuneroAdopcion()
        {
            return NumeroAdopcion;
        }

        public string GetMascota()
        {
            return Mascota;
        }

        public double GetPeso()
        {
            return Peso;
        }

        public double GetAltura()
        {
            return Altura;
        }

        public string GetNombre()
        {
            return Nombre;
        }

    }
}
