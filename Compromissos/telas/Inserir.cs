using System;
using System.Windows.Forms;
using Compromissos.dados;

namespace Compromissos.telas
{
    public partial class Inserir : Form
    {
        private Agenda _agenda;

        public Inserir(Agenda agenda)
        {
            _agenda = agenda;
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            _agenda.Inserir(TelaToCompromisso());
            Close();
        }

        private Compromisso TelaToCompromisso()
        {
            return new Compromisso(
                TxtTitulo.Text,
                TxtDescricao.Text,
                DtPickerDataHora.Value,
                TxtAssunto.Text
            );
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
