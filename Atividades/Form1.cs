using System.Windows.Forms;

namespace Atividades
{
    public partial class Matriz : Form
    {
        public Matriz()
        {
            InitializeComponent();
        }

        //Cria array 2D

        string[,] dado;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionar dado no array
            dado = new string[,]
            {
                {"1", "AAA", "BBB", "10" },
                {"2", "CCC", "DDD", "20" },
                {"3", "AAA", "AAA", "30" },
                {"4", "TTT", "AAA", "40" },
                {"5", "PPP", "ZZZ", "50" },
                {"6", "AAA", "WWW", "60" },
                {"7", "KKK", "AAA", "70" },

            };

            //EXIBE OS DADOS DO ARRAY NO OBJETO RICHTEXTBOX

            for (int i = 0; i < dado.GetLength(0); i++)
            {
                for (int j = 0; j < dado.GetLength(1); j++)
                {
                    Dados_matriz.Text += dado[i, j] + " -";
                    Dados_Matriz2.Text += dado[i, j] + " -";
                }

                Dados_matriz.Text += "\n";
                Dados_Matriz2.Text = "\n";


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            resultado.Text = "";

            Dictionary<string, int> contador = new Dictionary<string, int>();

            for (int i = 0; i < dado.GetLength(0); i++)
            {
                for (int j = 0; j < dado.GetLength(1); j++)
                {
                    string valor = dado[i, j];

                    if (contador.ContainsKey(valor))
                    {
                        contador[valor]++;
                    }
                    else
                    {
                        contador[valor] = 1;
                    }
                }

            }

            for (int i = 0; i < dado.GetLength(0); i++)
            {
                for (int j = 0; j < dado.GetLength(1); j++)
                {
                    string valor = dado[i, j];
                    if (contador[valor] == 1)
                    {
                        resultado.Text += valor + "-POSIÇÃO[" + i + j + "]\n";
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Dados_Matriz2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
