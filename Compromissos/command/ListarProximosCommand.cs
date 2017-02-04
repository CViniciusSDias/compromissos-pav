using System.Collections.Generic;
using Compromissos.dados;

namespace Compromissos.command
{
    public class ListarProximosCommand : ListagemCommand
    {
        private int _numeroDeDias;

        public ListarProximosCommand(int NumeroDeDias)
        {
            _numeroDeDias = NumeroDeDias;
        }

        public ICollection<Compromisso> execute(Agenda agenda)
        {
            return agenda.ListarProximos(_numeroDeDias);
        }
    }
}
