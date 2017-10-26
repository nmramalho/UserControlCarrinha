using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLibraryCarrinha
{

    public partial class UserControlCarrinha : UserControl
    {
        // Atributos privados
        private bool motoristaAtribuido;
        private int numLugaresLivres;
        private int numLugaresReservados;

        // Propriedades dos atributos
        public bool MotoristaAtribuido        
        {
            get { return motoristaAtribuido; }
            set { motoristaAtribuido = value; }
        }
     
        public int NumLugaresLivres
        {
            get { return numLugaresLivres; }
            set { numLugaresLivres = value; }
        }

        public int NumLugaresReservados
        {
            get { return numLugaresReservados; }
            set { numLugaresReservados = value; }
        }

        // Construtor padrão
        public UserControlCarrinha()
        {
            InitializeComponent();
            Inicializar();
            buttonLugar1.Click += new EventHandler(QuandoBotaoLugarPressionado);
            buttonLugar2.Click += new EventHandler(QuandoBotaoLugarPressionado);
            buttonLugar3.Click += new EventHandler(QuandoBotaoLugarPressionado);
            buttonLugar4.Click += new EventHandler(QuandoBotaoLugarPressionado);
            buttonLugar5.Click += new EventHandler(QuandoBotaoLugarPressionado);
            buttonLugar6.Click += new EventHandler(QuandoBotaoLugarPressionado);
            buttonMotorista.Click += new EventHandler(QuandoBotaoMotoristaPressionado);

      
        }



        //-------------------------------------------------------------------------------------
        // -----                       Método (Público)  BotaoClickHandler               ------
        //-------------------------------------------------------------------------------------
        // - Gerar um evento para deteção de clique nos botões
        //-------------------------------------------------------------------------------------
        public void BotaoClickHandler(EventHandler handler)
        {
            buttonLugar1.Click += handler;
            buttonLugar2.Click += handler;
            buttonLugar3.Click += handler;
            buttonLugar4.Click += handler;
            buttonLugar5.Click += handler;
            buttonLugar6.Click += handler;
            buttonMotorista.Click += handler;
        }

        //-------------------------------------------------------------------------------------
        // -----                             Método Inicializar                          ------
        //-------------------------------------------------------------------------------------
        // - Coloca a interface no estado inicial
        // - Inicializa os valores dos atributos
        //-------------------------------------------------------------------------------------
        private void Inicializar()
        {
            BotaoLivre(buttonLugar1);
            BotaoLivre(buttonLugar2);
            BotaoLivre(buttonLugar3);
            BotaoLivre(buttonLugar4);
            BotaoLivre(buttonLugar5);
            BotaoLivre(buttonLugar6);
            BotaoSemMotorista(buttonMotorista);
            MotoristaAtribuido = false;
            NumLugaresLivres = 6;
            NumLugaresReservados = 0;

        }



        //-------------------------------------------------------------------------------------
        // -----                       Método QuandoBotaoMotoristaPressionado            ------
        //-------------------------------------------------------------------------------------
        // - Inicializa a interface caso não exista motorista
        // - Atualiza propriedade MotoristaAtribuido
        //-------------------------------------------------------------------------------------
        private void QuandoBotaoMotoristaPressionado(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if(btn.Text == "SIM")
            {
                Inicializar();
            }
            else
            {
                BotaoComMotorista(btn);
                MotoristaAtribuido = true;
            }
        }
        //-------------------------------------------------------------------------------------
        // -----                       Método QuandoBotaoLugarPressionado            ------
        //-------------------------------------------------------------------------------------
        // - Testa se existe motorista para que se possam reservar lugares
        // - Atualiza aspeto e texto dos botões
        // - Atualiza as propriedades NumLugaresLivres e NumLugaresReservados
        //-------------------------------------------------------------------------------------
        public void QuandoBotaoLugarPressionado(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!motoristaAtribuido)
            {
                MessageBox.Show("Primeiro deve atribuir um motorista.", "Informação",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                return;
            }

            if (btn.Text == "Livre")
            {
                BotaoOcupado(btn);
                NumLugaresLivres--;
                NumLugaresReservados++;
            }
            else
            {
                BotaoLivre(btn);
                NumLugaresLivres++;
                NumLugaresReservados--;
            }
        }
        //-------------------------------------------------------------------------------------
        // -----                       Método BotaoSemMotorista            ------
        //-------------------------------------------------------------------------------------
        // -  Atualiza aspeto e texto do botão relativo ao motorista - Sem Motorista
        //-------------------------------------------------------------------------------------       
        private void BotaoSemMotorista(Button btn)
        {
            btn.Text = "NÃO";
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.White;
        }
        //-------------------------------------------------------------------------------------
        // -----                       Método BotaoComMotorista            ------
        //-------------------------------------------------------------------------------------
        // -  Atualiza aspeto e texto do botão relativo ao motorista - Com Motorista
        //------------------------------------------------------------------------------------- 
        private void BotaoComMotorista(Button btn)
        {
            btn.Text = "SIM";
            btn.BackColor = Color.Gray;
            btn.ForeColor = Color.Black;
        }
        //-------------------------------------------------------------------------------------
        // -----                       Método BotaoLivre                                ------
        //-------------------------------------------------------------------------------------
        // -  Atualiza aspeto e texto dos botões relativos aos passageiros - Livre
        //------------------------------------------------------------------------------------- 
        private void BotaoLivre(Button btn)
        {
            btn.Text = "Livre";
            btn.BackColor = Color.LawnGreen;
        }
        //-------------------------------------------------------------------------------------
        // -----                       Método BotaoOcupado                                ------
        //-------------------------------------------------------------------------------------
        // -  Atualiza aspeto e texto dos botões relativos aos passageiros - Ocupado
        //------------------------------------------------------------------------------------- 
        private void BotaoOcupado(Button btn)
        {
            btn.Text = "ocupado";
            btn.BackColor = Color.IndianRed;
        }
    }
}
