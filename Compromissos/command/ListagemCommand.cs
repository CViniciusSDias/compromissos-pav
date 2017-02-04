using System.Collections.Generic;
using Compromissos.dados;

namespace Compromissos.command
{
    public interface ListagemCommand
    {
        ICollection<Compromisso> execute(Agenda agenda);
    }
}
