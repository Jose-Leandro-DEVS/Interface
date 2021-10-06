
namespace Interface
{
    partial class Tela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela));
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnEstados = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.bnt_Maximizar = new System.Windows.Forms.Button();
            this.bnt_Minimizar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.CLIENTES = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ESTADOS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(13)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(83, 227);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(203, 181);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVendedores
            // 
            this.btnVendedores.BackColor = System.Drawing.Color.Red;
            this.btnVendedores.FlatAppearance.BorderSize = 0;
            this.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVendedores.Image = ((System.Drawing.Image)(resources.GetObject("btnVendedores.Image")));
            this.btnVendedores.Location = new System.Drawing.Point(381, 227);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(203, 181);
            this.btnVendedores.TabIndex = 7;
            this.btnVendedores.UseVisualStyleBackColor = false;
            // 
            // btnEstados
            // 
            this.btnEstados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnEstados.FlatAppearance.BorderSize = 0;
            this.btnEstados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstados.Image = ((System.Drawing.Image)(resources.GetObject("btnEstados.Image")));
            this.btnEstados.Location = new System.Drawing.Point(689, 227);
            this.btnEstados.Name = "btnEstados";
            this.btnEstados.Size = new System.Drawing.Size(203, 181);
            this.btnEstados.TabIndex = 8;
            this.btnEstados.UseVisualStyleBackColor = false;
            this.btnEstados.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.Image")));
            this.btn_Fechar.Location = new System.Drawing.Point(953, 12);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(32, 31);
            this.btn_Fechar.TabIndex = 9;
            this.btn_Fechar.UseVisualStyleBackColor = false;
            // 
            // bnt_Maximizar
            // 
            this.bnt_Maximizar.FlatAppearance.BorderSize = 0;
            this.bnt_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Maximizar.ForeColor = System.Drawing.SystemColors.Window;
            this.bnt_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Maximizar.Image")));
            this.bnt_Maximizar.Location = new System.Drawing.Point(915, 12);
            this.bnt_Maximizar.Name = "bnt_Maximizar";
            this.bnt_Maximizar.Size = new System.Drawing.Size(32, 31);
            this.bnt_Maximizar.TabIndex = 10;
            this.bnt_Maximizar.UseVisualStyleBackColor = false;
            // 
            // bnt_Minimizar
            // 
            this.bnt_Minimizar.FlatAppearance.BorderSize = 0;
            this.bnt_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Minimizar.ForeColor = System.Drawing.SystemColors.Window;
            this.bnt_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Minimizar.Image")));
            this.bnt_Minimizar.Location = new System.Drawing.Point(877, 12);
            this.bnt_Minimizar.Name = "bnt_Minimizar";
            this.bnt_Minimizar.Size = new System.Drawing.Size(32, 31);
            this.bnt_Minimizar.TabIndex = 11;
            this.bnt_Minimizar.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(910, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 12;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.GhostWhite;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(945, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 34);
            this.button5.TabIndex = 13;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CLIENTES
            // 
            this.CLIENTES.AutoSize = true;
            this.CLIENTES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(13)))));
            this.CLIENTES.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CLIENTES.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CLIENTES.Location = new System.Drawing.Point(136, 366);
            this.CLIENTES.Name = "CLIENTES";
            this.CLIENTES.Size = new System.Drawing.Size(107, 30);
            this.CLIENTES.TabIndex = 14;
            this.CLIENTES.Text = "CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(413, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "VENDEDORES";
            // 
            // ESTADOS
            // 
            this.ESTADOS.AutoSize = true;
            this.ESTADOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ESTADOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ESTADOS.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ESTADOS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ESTADOS.Location = new System.Drawing.Point(743, 366);
            this.ESTADOS.Name = "ESTADOS";
            this.ESTADOS.Size = new System.Drawing.Size(106, 30);
            this.ESTADOS.TabIndex = 16;
            this.ESTADOS.Text = "ESTADOS";
            this.ESTADOS.Click += new System.EventHandler(this.ESTADOS_Click);
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(997, 614);
            this.Controls.Add(this.ESTADOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLIENTES);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bnt_Minimizar);
            this.Controls.Add(this.bnt_Maximizar);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btnEstados);
            this.Controls.Add(this.btnVendedores);
            this.Controls.Add(this.btnClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVendedores;
        public System.Windows.Forms.Button btnEstados;
        public System.Windows.Forms.Button btn_Fechar;
        public System.Windows.Forms.Button bnt_Maximizar;
        public System.Windows.Forms.Button bnt_Minimizar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label CLIENTES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ESTADOS;
    }
}

