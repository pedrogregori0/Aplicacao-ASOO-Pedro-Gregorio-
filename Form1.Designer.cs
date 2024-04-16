
namespace Aplicacao_ASOO__Pedro_Gregorio_
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
            btnValidar = new Button();
            lblDigiteRA = new Label();
            txbRa = new TextBox();
            lblResposta = new Label();
            lblResposta2 = new Label();
            lblResposta3 = new Label();
            lblResposta4 = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(153, 206);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(125, 27);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar RA";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblDigiteRA
            // 
            lblDigiteRA.AutoSize = true;
            lblDigiteRA.Location = new Point(166, 89);
            lblDigiteRA.Name = "lblDigiteRA";
            lblDigiteRA.Size = new Size(99, 20);
            lblDigiteRA.TabIndex = 1;
            lblDigiteRA.Text = "Digite seu RA";
            lblDigiteRA.Click += lblDigiteRA_Click;
            // 
            // txbRa
            // 
            txbRa.Location = new Point(153, 136);
            txbRa.Name = "txbRa";
            txbRa.Size = new Size(125, 27);
            txbRa.TabIndex = 2;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(12, 305);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(0, 20);
            lblResposta.TabIndex = 3;
            lblResposta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResposta2
            // 
            lblResposta2.AutoSize = true;
            lblResposta2.Location = new Point(12, 325);
            lblResposta2.Name = "lblResposta2";
            lblResposta2.Size = new Size(0, 20);
            lblResposta2.TabIndex = 4;
            // 
            // lblResposta3
            // 
            lblResposta3.AutoSize = true;
            lblResposta3.Location = new Point(12, 345);
            lblResposta3.Name = "lblResposta3";
            lblResposta3.Size = new Size(0, 20);
            lblResposta3.TabIndex = 5;
            // 
            // lblResposta4
            // 
            lblResposta4.AutoSize = true;
            lblResposta4.Location = new Point(12, 365);
            lblResposta4.Name = "lblResposta4";
            lblResposta4.Size = new Size(0, 20);
            lblResposta4.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 403);
            Controls.Add(lblResposta4);
            Controls.Add(lblResposta3);
            Controls.Add(lblResposta2);
            Controls.Add(lblResposta);
            Controls.Add(txbRa);
            Controls.Add(lblDigiteRA);
            Controls.Add(btnValidar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnValidar;
        private Label lblDigiteRA;
        private TextBox txbRa;
        private Label lblResposta;
        private Label lblResposta2;
        private Label lblResposta3;
        private Label lblResposta4;
    }
}
