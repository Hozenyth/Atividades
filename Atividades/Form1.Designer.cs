namespace Atividades
{
    partial class Matriz
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            resultado = new RichTextBox();
            btnBuscar = new Button();
            Dados_matriz = new RichTextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            Dados_Matriz2 = new RichTextBox();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(659, 578);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(resultado);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(Dados_matriz);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(651, 545);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Exemplo 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // resultado
            // 
            resultado.Location = new Point(387, 93);
            resultado.Name = "resultado";
            resultado.Size = new Size(222, 421);
            resultado.TabIndex = 3;
            resultado.Text = "";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(233, 302);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 41);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Dados_matriz
            // 
            Dados_matriz.Location = new Point(6, 93);
            Dados_matriz.Name = "Dados_matriz";
            Dados_matriz.Size = new Size(193, 421);
            Dados_matriz.TabIndex = 1;
            Dados_matriz.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(606, 38);
            label1.TabIndex = 0;
            label1.Text = "Exibir apenas valores únicos de toda a matriz";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Dados_Matriz2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(richTextBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(651, 545);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Exemplo 2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // Dados_Matriz2
            // 
            Dados_Matriz2.Location = new Point(6, 115);
            Dados_Matriz2.Name = "Dados_Matriz2";
            Dados_Matriz2.Size = new Size(214, 371);
            Dados_Matriz2.TabIndex = 3;
            Dados_Matriz2.Text = "";
            Dados_Matriz2.TextChanged += Dados_Matriz2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(258, 251);
            button1.Name = "button1";
            button1.Size = new Size(83, 40);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(362, 115);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(248, 371);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // Matriz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 712);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Matriz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atividades Estrutura de dados";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private RichTextBox Dados_matriz;
        private RichTextBox resultado;
        private Button btnBuscar;
        private Button button1;
        private RichTextBox richTextBox2;
        private RichTextBox Dados_Matriz2;
    }
}
