using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compromissos.dados
{
    public class Compromisso
    {
        private int _id;
        private string _titulo;
        private string _descricao;
        private DateTime _dataHora;
        private string _assunto;

        public Compromisso(string titulo, string descricao, DateTime dataHora, string assunto)
        {
            this._titulo = titulo;
            this._descricao = descricao;
            this._assunto = assunto;
            this._dataHora = dataHora;
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public String DataHora
        {
            get
            {
                return _dataHora.ToString();
            }
        }

        public string Assunto
        {
            get
            {
                return _assunto;
            }
        }

        public string Titulo
        {
            get
            {
                return _titulo;
            }
        }

        public string Descricao
        {
            get
            {
                return _descricao;
            }
        }

        public DateTime GetData()
        {
            return _dataHora.Date;
        }
    }
}
