namespace JessicaTrab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.MaximizeBox = false;

            InitializeComponent();

        }

        private void BTN_Left_Side_Click(object sender, EventArgs e)
        {
            

        }

        private void BTN_Right_Side_Click(object sender, EventArgs e)
        {
            

        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (Lbl_Question.Text == "Bullying e Brincadeira s�o a mesma coisa, ou s�o diferentes?")
            {
                BTN_Left_Side.ForeColor = Color.Black;
                BTN_Right_Side.ForeColor = Color.Black;
                Lbl_Question.Text = "S� � bullying quando algu�m agride fisicamente outra pessoa. Verdadeiro ou falso?";
                BTN_Left_Side.Text = "Verdadeiro";
                BTN_Right_Side.Text = "Falso";

            }
            else if (Lbl_Question.Text == "S� � bullying quando algu�m agride fisicamente outra pessoa. Verdadeiro ou falso?")
            {
                BTN_Left_Side.ForeColor = Color.Black;
                BTN_Right_Side.ForeColor = Color.Black;
                Lbl_Question.Text = "Tirar sarro dos outros na internet � bullying?";
                BTN_Left_Side.Text = "Sim";
                BTN_Right_Side.Text = "N�o";
            }
            else if (Lbl_Question.Text == "Tirar sarro dos outros na internet � bullying?")
            {
                BTN_Left_Side.ForeColor = Color.Black;
                BTN_Right_Side.ForeColor = Color.Black;
                Lbl_Question.Text = "Quando voc� v� algu�m fazendo bullying, o melhor � nn�o se meter para n�o piorar\r\nas coisas. Verdadeiro ou falso?";
                BTN_Left_Side.Text = "Verdadeiro";
                BTN_Right_Side.Text = "Falso";

            }
            else if (Lbl_Question.Text == "Quando voc� v� algu�m fazendo bullying, o melhor � nn�o se meter para n�o piorar\r\nas coisas. Verdadeiro ou falso?")
            {
                BTN_Left_Side.ForeColor = Color.Black;
                BTN_Right_Side.ForeColor = Color.Black;
                Lbl_Question.Text = "Se um colega parecer triste ou\r\nmuito chateado, o que voc�\r\ndeve fazer para ajudar?";
                BTN_Left_Side.Text = "Avisar a Professora";
                BTN_Right_Side.Text = "Conversar com ele";
            }
        }

        private void BTN_Esquerdo_Apertado(object sender, MouseEventArgs e)
        {
            if (Lbl_Question.Text == "Bullying e Brincadeira s�o a mesma coisa, ou s�o diferentes?")
            {
                BTN_Left_Side.ForeColor = Color.Red;
                BTN_Right_Side.ForeColor = Color.Green;


            }
            else if (Lbl_Question.Text == "S� � bullying quando algu�m agride fisicamente outra pessoa. Verdadeiro ou falso?" && BTN_Left_Side.ForeColor == Color.Black)
            {
                BTN_Left_Side.ForeColor = Color.Red;
                BTN_Right_Side.ForeColor = Color.Green;

            }
            else if (Lbl_Question.Text == "Tirar sarro dos outros na internet � bullying?")
            {
                BTN_Left_Side.ForeColor = Color.Green;
                BTN_Right_Side.ForeColor = Color.Red;
            }
            else if (Lbl_Question.Text == "Quando voc� v� algu�m fazendo bullying, o melhor � nn�o se meter para n�o piorar\r\nas coisas. Verdadeiro ou falso?")

            {
                BTN_Left_Side.ForeColor = Color.Red;
                BTN_Right_Side.ForeColor = Color.Green;
            }
            else if (Lbl_Question.Text == "Se um colega parecer triste ou\r\nmuito chateado, o que voc�\r\ndeve fazer para ajudar?") ;
            {
                BTN_Left_Side.ForeColor = Color.Green;
                BTN_Right_Side.ForeColor = Color.Red;
            }
            




        }

        private void BTN_Right_Apertou(object sender, MouseEventArgs e)
        {
            if(Lbl_Question.Text == "Bullying e Brincadeira s�o a mesma coisa, ou s�o diferentes?") 
            {
                BTN_Right_Side.ForeColor = Color.Green;
                BTN_Left_Side.ForeColor = Color.Red;

            }
            else if (Lbl_Question.Text == "S� � bullying quando algu�m agride fisicamente outra pessoa. Verdadeiro ou falso?" && BTN_Right_Side.ForeColor == Color.Black)
            {
                BTN_Right_Side.ForeColor = Color.Green;
                BTN_Left_Side.ForeColor = Color.Red;

            }
            else if (Lbl_Question.Text == "Tirar sarro dos outros na internet � bullying?")
            {
                BTN_Left_Side.ForeColor = Color.Green;
                BTN_Right_Side.ForeColor = Color.Red;
            }
            else if (Lbl_Question.Text == "Quando voc� v� algu�m fazendo bullying, o melhor � nn�o se meter para n�o piorar\r\nas coisas. Verdadeiro ou falso?")

            {
                BTN_Left_Side.ForeColor = Color.Red;
                BTN_Right_Side.ForeColor = Color.Green;
            }
            else if (Lbl_Question.Text == "Se um colega parecer triste ou\r\nmuito chateado, o que voc�\r\ndeve fazer para ajudar?") ;
            {
                BTN_Left_Side.ForeColor = Color.Green;
                BTN_Right_Side.ForeColor = Color.Red;
            }



        }
    }
}