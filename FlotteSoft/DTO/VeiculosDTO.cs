using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlotteSoft.DTO
{
    class VeiculosDTO
    {
        private string tipo_veiculo;
        private string marca;
        private string modelo;
        private double valordiaria;
        private int    ano;
        private int    ar_condicionado;
        private int    veiculo_do_cliente;

        public string Tipo_veiculo
        {
            get
            {
                return tipo_veiculo;
            }

            set
            {
                tipo_veiculo = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public int Ano
        {
            get
            {
                return ano;
            }

            set
            {
                ano = value;
            }
        }

        public double Valordiaria
        {
            get
            {
                return valordiaria;
            }

            set
            {
                valordiaria = value;
            }
        }

        public int Ar_condicionado
        {
            get
            {
                return ar_condicionado;
            }

            set
            {
                ar_condicionado = value;
            }
        }

        public int Veiculo_do_cliente
        {
            get
            {
                return veiculo_do_cliente;
            }

            set
            {
                veiculo_do_cliente = value;
            }
        }
    }
}
