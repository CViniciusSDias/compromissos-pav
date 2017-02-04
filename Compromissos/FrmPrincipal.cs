using System;
using System.Windows.Forms;
using System.Globalization;
using Compromissos.telas;
using Compromissos.dados;
using Compromissos.command;

namespace Compromissos
{
    public partial class FrmPrincipal : Form
    {
        private Agenda _agenda;

        public FrmPrincipal()
        {
            InitializeComponent();
            _agenda = new Agenda();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja sair?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes) {
                Close();
            }
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar FormListar = new Listar(_agenda, new ListarTodosCommand());
            FormListar.ShowDialog();
        }

        private void porAssuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDialog input = new InputDialog("Assunto", "Digite o assunto a buscar:");
            input.ShowDialog();

            if (input.Resposta == DialogResult.OK) {
                string assunto = input.Dado;
                Listar FormListar = new Listar(_agenda, new ListarPorAssuntoCommand(assunto));
                FormListar.ShowDialog();
            }
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir(_agenda);
            inserir.ShowDialog();
        }

        private void porPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                DateTime inicio = AskUserForDate("Início", "Digite o início do período a buscar:");
                DateTime fim = AskUserForDate("Fim", "Digite o fim do período a buscar:");

                Listar FormListar = new Listar(_agenda, new ListarPorPeriodoCommand(inicio, fim));
                FormListar.ShowDialog();
            } catch (ArgumentNullException ex) {
                // Usuário cancelou
            } catch (FormatException ex) {
                MessageBox.Show("Formato de data inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DateTime AskUserForDate(string titulo, string mensagem)
        {
            InputDialog inputInicio = new InputDialog(titulo, mensagem);
            inputInicio.ShowDialog();

            if (inputInicio.Resposta == DialogResult.Cancel) {
                throw new ArgumentNullException();
            }

            return DateTime.ParseExact(
                inputInicio.Dado,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );
        }

        private void deHojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar FormListar = new Listar(_agenda, new ListarHojeCommand());
            FormListar.ShowDialog();
        }

        private void próximosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDialog input = new InputDialog("Número de Dias", "Digite o número de dias a buscar:");
            if (input.Resposta == DialogResult.OK) {
                int dias = Convert.ToInt32(input.Dado);

                Listar FormListar = new Listar(_agenda, new ListarProximosCommand(dias));
                FormListar.ShowDialog();
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDialog input = new InputDialog("Excluir", "Digite o ID do compromisso a remover:");
            input.ShowDialog();
            if (input.Resposta == DialogResult.OK) {
                _agenda.Remover(Convert.ToInt32(input.Dado));
            }
        }
    }
}
