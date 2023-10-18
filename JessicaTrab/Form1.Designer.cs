namespace JessicaTrab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTN_Left_Side = new Button();
            BTN_Right_Side = new Button();
            Btn_Next = new Button();
            Lbl_Question = new Label();
            SuspendLayout();
            // 
            // BTN_Left_Side
            // 
            BTN_Left_Side.Location = new Point(96, 98);
            BTN_Left_Side.Name = "BTN_Left_Side";
            BTN_Left_Side.Size = new Size(113, 58);
            BTN_Left_Side.TabIndex = 0;
            BTN_Left_Side.Text = "A mesma coisa";
            BTN_Left_Side.UseVisualStyleBackColor = true;
            BTN_Left_Side.Click += BTN_Left_Side_Click;
            BTN_Left_Side.MouseClick += BTN_Esquerdo_Apertado;
            // 
            // BTN_Right_Side
            // 
            BTN_Right_Side.Location = new Point(333, 98);
            BTN_Right_Side.Name = "BTN_Right_Side";
            BTN_Right_Side.Size = new Size(113, 58);
            BTN_Right_Side.TabIndex = 1;
            BTN_Right_Side.Text = "Diferente";
            BTN_Right_Side.UseVisualStyleBackColor = true;
            BTN_Right_Side.Click += BTN_Right_Side_Click;
            BTN_Right_Side.MouseClick += BTN_Right_Apertou;
            // 
            // Btn_Next
            // 
            Btn_Next.Location = new Point(468, 211);
            Btn_Next.Name = "Btn_Next";
            Btn_Next.Size = new Size(72, 40);
            Btn_Next.TabIndex = 2;
            Btn_Next.Text = "Próximo";
            Btn_Next.UseVisualStyleBackColor = true;
            Btn_Next.Click += Btn_Next_Click;
            // 
            // Lbl_Question
            // 
            Lbl_Question.AutoSize = true;
            Lbl_Question.Location = new Point(78, 52);
            Lbl_Question.Name = "Lbl_Question";
            Lbl_Question.Size = new Size(324, 15);
            Lbl_Question.TabIndex = 3;
            Lbl_Question.Text = "Bullying e Brincadeira são a mesma coisa, ou são diferentes?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 287);
            Controls.Add(Lbl_Question);
            Controls.Add(Btn_Next);
            Controls.Add(BTN_Right_Side);
            Controls.Add(BTN_Left_Side);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_Left_Side;
        private Button BTN_Right_Side;
        private Button Btn_Next;
        private Label Lbl_Question;
    }
}