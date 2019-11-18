using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlotteSoft.DTO
{
    class EmpresaDTO
    {
        string cnpj;
        string razao_social;
        string telefone;
        string email;
        string endereco;
        string status_empresa;

        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public string Razao_social
        {
            get
            {
                return razao_social;
            }

            set
            {
                razao_social = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Status_empresa
        {
            get
            {
                return status_empresa;
            }

            set
            {
                status_empresa = value;
            }
        }
    }
}
