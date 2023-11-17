using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_De_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtém o conteúdo do TextBox
            string conteudo = textBox1.Text;

            // Obtém o caminho da área de trabalho do usuário
            string areaDeTrabalho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Cria o caminho completo do arquivo na área de trabalho
            string caminhoArquivo = Path.Combine(areaDeTrabalho, "arquivo.txt");

            try
            {
                // Escreve o conteúdo do TextBox no arquivo
                File.WriteAllText(caminhoArquivo, conteudo);

                MessageBox.Show("Conteúdo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Configuração da caixa de diálogo para escolher a fonte
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Aplica a fonte selecionada ao TextBox
                textBox1.Font = fontDialog.Font;
            }

            // Configuração da caixa de diálogo para escolher a cor
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Aplica a cor selecionada ao TextBox
                textBox1.ForeColor = colorDialog.Color;
            }
        }
    }
}
    

