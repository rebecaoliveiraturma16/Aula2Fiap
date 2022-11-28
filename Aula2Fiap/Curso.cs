using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    namespace FiapHelloWorld
    {
        public class Curso
        {
            #region atributos
            int Codigo;
            string NomeCurso;
            string NomeInstrutor;
            int CargaHorario;
            int MinimoAlunos;
            int MaximoAlunos;
            #endregion
            public Curso()
            {
                // Construtor padrão.
            }
            public Curso(string nome, string instrutor)
            {
                this.NomeCurso = nome;
                this.NomeInstrutor = instrutor;
            }
            public Curso(string nome, int minimo, int maximo)
            {
                this.NomeCurso = nome;
                this.MaximoAlunos = maximo;
                this.MinimoAlunos = minimo;
            }
            public void CriarCurso(string nome, string instrutor)
            {
                this.NomeCurso = nome;
                this.NomeInstrutor = instrutor;
            }
            private bool MatricularAluno(string nomeAluno)
            {
                // Verificar a quantidade de alunos
                return true;
            }
            private int ConsultarMaximoAlunos()
            {
                // Retorno o valor do atributo
                return this.MaximoAlunos;
            }
        }
    }
}