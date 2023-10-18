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
            if (Lbl_Question.Text == "Bullying e Brincadeira são a mesma coisa, ou são diferentes?")
            {
                BTN_Left_Side.ForeColor = Color.Black;
                BTN_Right_Side.ForeColor = Color.Black;
                Lbl_Question.Text = "Só é bullying quando alguém agride fisicamente outra pessoa. Verdadeiro ou falso?";
                BTN_Left_Side.Text = "Verdadeiro";
                BTN_Right_Side.Text = "Falso";

            }
            else if (Lbl_Question.Text == "Só é bullying quando alguém agride fisicamente outra pessoa. Verdadeiro ou falso?")
            {
                BTN_Left_Side.ForeColor = Color.Black;
                BTN_Right_Side.ForeColor = Color.Black;
                Lbl_Question.Text = "Tirar sarro dos outros na internet é bullying?";
                BTN_Left_Side.Text = "Sim";
                BTN_Right_Side.Text = "Não";
            }
            else if (Lbl_Question.Text == "Tirar sarro dos outros na internet é bullying?")
            {
                BTN_Left_Side.ForeColor = Color.Black;
                BTN_Right_Side.ForeColor = Color.Black;
                Lbl_Question.Text = "Quando você vê alguém fazendo bullying, o melhor é nnão se meter para não piorar\r\nas coisas. Verdadeiro ou falso?";
                BTN_Left_Side.Text = "Verdadeiro";
                BTN_Right_Side.Text = "Falso";

            }
            else if (Lbl_Question.Text == "Quando você vê alguém fazendo bullying, o melhor é nnão se meter para não piorar\r\nas coisas. Verdadeiro ou falso?")
            {
                BTN_Left_Side.ForeColor = Color.Black;
                BTN_Right_Side.ForeColor = Color.Black;
                Lbl_Question.Text = "Se um colega parecer triste ou\r\nmuito chateado, o que você\r\ndeve fazer para ajudar?";
                BTN_Left_Side.Text = "Avisar a Professora";
                BTN_Right_Side.Text = "Conversar com ele";
            }
        }

        private void BTN_Esquerdo_Apertado(object sender, MouseEventArgs e)
        {
            if (Lbl_Question.Text == "Bullying e Brincadeira são a mesma coisa, ou são diferentes?")
            {
                BTN_Left_Side.ForeColor = Color.Red;
                BTN_Right_Side.ForeColor = Color.Green;


            }
            else if (Lbl_Question.Text == "Só é bullying quando alguém agride fisicamente outra pessoa. Verdadeiro ou falso?" && BTN_Left_Side.ForeColor == Color.Black)
            {
                BTN_Left_Side.ForeColor = Color.Red;
                BTN_Right_Side.ForeColor = Color.Green;

            }
            else if (Lbl_Question.Text == "Tirar sarro dos outros na internet é bullying?")
            {
                BTN_Left_Side.ForeColor = Color.Green;
                BTN_Right_Side.ForeColor = Color.Red;
            }
            else if (Lbl_Question.Text == "Quando você vê alguém fazendo bullying, o melhor é nnão se meter para não piorar\r\nas coisas. Verdadeiro ou falso?")

            {
                BTN_Left_Side.ForeColor = Color.Red;
                BTN_Right_Side.ForeColor = Color.Green;
            }
            else if (Lbl_Question.Text == "Se um colega parecer triste ou\r\nmuito chateado, o que você\r\ndeve fazer para ajudar?") ;
            {
                BTN_Left_Side.ForeColor = Color.Green;
                BTN_Right_Side.ForeColor = Color.Red;
            }
            




        }

        private void BTN_Right_Apertou(object sender, MouseEventArgs e)
        {
            if(Lbl_Question.Text == "Bullying e Brincadeira são a mesma coisa, ou são diferentes?") 
            {
                BTN_Right_Side.ForeColor = Color.Green;
                BTN_Left_Side.ForeColor = Color.Red;

            }
            else if (Lbl_Question.Text == "Só é bullying quando alguém agride fisicamente outra pessoa. Verdadeiro ou falso?" && BTN_Right_Side.ForeColor == Color.Black)
            {
                BTN_Right_Side.ForeColor = Color.Green;
                BTN_Left_Side.ForeColor = Color.Red;

            }
            else if (Lbl_Question.Text == "Tirar sarro dos outros na internet é bullying?")
            {
                BTN_Left_Side.ForeColor = Color.Green;
                BTN_Right_Side.ForeColor = Color.Red;
            }
            else if (Lbl_Question.Text == "Quando você vê alguém fazendo bullying, o melhor é nnão se meter para não piorar\r\nas coisas. Verdadeiro ou falso?")

            {
                BTN_Left_Side.ForeColor = Color.Red;
                BTN_Right_Side.ForeColor = Color.Green;
            }
            else if (Lbl_Question.Text == "Se um colega parecer triste ou\r\nmuito chateado, o que você\r\ndeve fazer para ajudar?") ;
            {
                BTN_Left_Side.ForeColor = Color.Green;
                BTN_Right_Side.ForeColor = Color.Red;
            }



        }
    }
}