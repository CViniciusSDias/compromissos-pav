using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Compromissos.dados;
using Compromissos.command;

namespace Compromissos.telas
{
    public partial class Listar : Form
    {
        private Agenda _agenda;
        private ICollection<Compromisso> _compromissos;

        public Listar(Agenda agenda, ListagemCommand command)
        {
            _agenda = agenda;
            _compromissos = command.execute(agenda);
            InitializeComponent();
            TabelaCompromissos.DataSource = _compromissos;
        }
    }
}
