using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compromissos.dados
{
    public class Agenda
    {
        private ICollection<Compromisso> _compromissos;
        private int _autoIncrement;

        public Agenda()
        {
            _compromissos = new List<Compromisso>();
            _autoIncrement = 1;
        }

        public ICollection<Compromisso> Compromissos
        {
            get
            {
                return _compromissos;
            }
        }

        public void Inserir(Compromisso c)
        {
            c.Id = _autoIncrement++;
            _compromissos.Add(c);
        }

        public bool Remover(int id)
        {
            for (int i = 0; i < _compromissos.Count; i++) {
                Compromisso c = _compromissos.ElementAt(i);
                if (c.Id == id) {
                    _compromissos.Remove(c);
                    return true;
                }
            }

            return false;
        }

        /**
         * Retorna uma coleção Imutável
         */
        public ICollection<Compromisso> ListarTodos()
        {
            return _compromissos.ToList().AsReadOnly();
        }

        public ICollection<Compromisso> ListarPorAssunto(string assunto)
        {
            return Filtra(c => c.Assunto.Contains(assunto));
        }

        public ICollection<Compromisso> ListarHoje()
        {
            return Filtra(c => c.GetData() == DateTime.Today);
        }

        public ICollection<Compromisso> ListarPorPeriodo(DateTime inicio, DateTime fim)
        {
            return Filtra(c => c.GetData() > inicio && c.GetData() < fim);
        }

        public ICollection<Compromisso> ListarProximos(int numeroDeDias)
        {
            DateTime hoje = DateTime.Today;
            DateTime proxima = hoje.AddDays(numeroDeDias);

            return Filtra(c => c.GetData().Date >= hoje && c.GetData().Date <= proxima.Date); 
        }

        public ICollection<Compromisso> Filtra(Func<Compromisso, bool> f)
        {
            return _compromissos
                .Where(f)
                .ToList()
                .AsReadOnly();
        }
    }
}
