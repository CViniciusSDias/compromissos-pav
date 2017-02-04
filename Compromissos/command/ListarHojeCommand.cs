using System.Collections.Generic;
using Compromissos.dados;

namespace Compromissos.command
{
    public class ListarHojeCommand : ListagemCommand
    {
        public ICollection<Compromisso> execute(Agenda agenda)
        {
            return agenda.ListarHoje();
        }
    }
}
