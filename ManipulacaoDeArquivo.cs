using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDepartamento
{
    class ManipulacaoDeArquivo
    {
        //Propriedades da classe Manipulacao
        private OpenFileDialog leitura = new OpenFileDialog();
        private SaveFileDialog salvamento = new SaveFileDialog();
        /// <summary>
        /// Atributo do caminho do arquivo
        /// </summary>
        protected string caminho;

        /// <summary>
        /// Construindo nosso objeto
        /// </summary>
        public ManipulacaoDeArquivo() { }

        //Sobrecarga
        /// <summary>
        /// Construi meu objeto com o caminho do arquivo
        /// </summary>
        /// <param name="caminho">Caminho do arquivo</param>
        public ManipulacaoDeArquivo(string caminho)
        {
            this.caminho = caminho;
        }

        /// <summary>
        /// Retorna meus dados de um arquivo .csv
        /// </summary>
        /// <returns>O que contem no arquivo</returns>
        protected virtual string ObterDados()
        {
            //Definição do arquivo a ser lido
            leitura.Filter = "Arquivo CSV (*.csv)|*.csv";
            leitura.Title = "Selecione o arquivo CSV";
            //Verifica se ocorreu tudo certo
            if (leitura.ShowDialog() != DialogResult.OK)
                return null;
            //Obtem o caminho do arquivo
            string caminho = leitura.FileName;
            string textoLido;

            //Ele tenta fazer a leitura do arquivo, caso não consiga
            //Impede uma excessão, retornando nulo;
            try
            {
                textoLido = File.ReadAllText(caminho);
                return textoLido;
            }
            catch (Exception)
            {
                return null;
            }

        }
        /// <summary>
        /// Criando o método que pode ser modificado pelos filhos da classe Manipulação de Arquivo
        /// </summary>
        protected virtual void SalvarArquivo() { }

        /// <summary>
        /// Método original para salvamento de arquivo
        /// </summary>
        /// <param name="txt">Texto a ser salvo no arquivo</param>
        protected virtual void SalvarArquivo(string txt)
        {
            //Definição do arquivo a ser salvo
            salvamento.Filter = "Arquivo CSV (*.csv)|*.csv";
            salvamento.Title = "Selecione o arquivo CSV";

            //Verifica se ocorreu tudo certo e obteve a base de dados
            if (salvamento.ShowDialog() != DialogResult.OK ||
                salvamento.FileName == null)
            {
                new Exception("Erro ao salvar o arquivo");
                return;
            }

            //Abre o arquivo e é feita a conversão para o tipo FileStream
            FileStream abrirArquivoCriado = salvamento.OpenFile() as FileStream;
            //Convertendo o arquivo de outra maneira: (FileStream)salvamento.OpenFile()

            //Faz a modificação no arquivo
            StreamWriter salvandoArquivo = new StreamWriter(abrirArquivoCriado);
            salvandoArquivo.WriteLine(txt);

            //Encerra o processo de modificação e fecha os arquivos abertos
            salvandoArquivo.Close();
            abrirArquivoCriado.Close();
        }
    }
}
