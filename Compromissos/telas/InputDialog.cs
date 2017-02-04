using System;
using System.Windows.Forms;

namespace Compromissos.telas
{
    public partial class InputDialog : Form
    {
        private DialogResult _resultado;
        private string _dado;

        public DialogResult Resposta
        {
            get
            {
                return _resultado;
            }
        }

        public string Dado
        {
            get
            {
                return _dado;
            }
        }

        public InputDialog(string titulo, string mensagem)
        {
            _resultado = DialogResult.Cancel;

            InitializeComponent();
            Text = titulo;
            LblMensagem.Text = mensagem;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            _resultado = DialogResult.OK;
            _dado = TxtInput.Text;
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _resultado = DialogResult.Cancel;
            Close();
        }
    }
}
