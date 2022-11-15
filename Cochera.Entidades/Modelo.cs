using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cochera.Entidades
{
    public class Modelo
    {

        //------------ATRIBUTOS Y PROPIEDADES------------//

        public int ModeloId { get; private set; }

        public string Nombre { get; private set; }

        private TipoDeVehiculo tipoVehiculo;

        private Marca marca;

        //------------CONSTRUCTOR------------//

        public Modelo(int modeloId, string modelo)
        {
            ModeloId = modeloId;
            Nombre = modelo;
        }

        public Modelo(int modeloId, string modelo, TipoDeVehiculo tipoVehiculo, Marca marca) : this(modeloId,modelo)
        {
            this.tipoVehiculo = tipoVehiculo;
            this.marca = marca;
        }


        //------------METODOS------------//


        //----PRIVADOS----//


        //----PUBLICOS----//

        public void ActualizarDatos(string nombre, Marca marca, TipoDeVehiculo tipo)
        {
            Nombre = nombre;
            this.marca = marca;
            this.tipoVehiculo = tipo;
        }
        public string ObtenerMarca()
        {
            return marca.Nombre;
        }

        public int ObtenerMarcaId()
        {
            return marca.MarcaId;
        }

        public string ObtenerTipoVehiculo()
        {
            return tipoVehiculo.Tipo;
        }

        public int ObtenerTipoVehiculoId()
        {
            return tipoVehiculo.TipoId;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
