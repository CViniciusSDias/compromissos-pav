using System.Collections.Generic;
using Compromissos.dados;

namespace Compromissos.command
{
    public class ListarPorAssuntoCommand : ListagemCommand
    {
        private string _assunto;

        public ListarPorAssuntoCommand(string assunto)
        {
            _assunto = assunto;
        }

        public ICollection<Compromisso> execute(Agenda agenda)
        {
            return agenda.ListarPorAssunto(_assunto);
        }
    }
}
