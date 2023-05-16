using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escolaa
{
    public class PESSOA
    {
        private string nome;
        private string cpf;
        private string nome_social;
       

        public virtual string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                nome = value;
            }
        }

        public virtual string Cpf
        {
            get
            {
                return this.cpf;
            }
            set
            {
                cpf = value;
            }
        }

        public virtual string NomeSocial
        {
            get
            {
                return this.nome_social;
            }
            set
            {
                nome_social = value;
            }
        }

    }


}