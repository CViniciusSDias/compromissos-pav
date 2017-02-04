using System;
using System.Collections.Generic;
using Compromissos.dados;

namespace Compromissos.command
{
    public class ListarPorPeriodoCommand : ListagemCommand
    {
        private DateTime _inicio;
        private DateTime _fim;

        public ListarPorPeriodoCommand(DateTime Inicio, DateTime Fim)
        {
            _inicio = Inicio;
            _fim = Fim;
        }

        public ICollection<Compromisso> execute(Agenda agenda)
        {
            return agenda.ListarPorPeriodo(_inicio, _fim);
        }
    }
}
