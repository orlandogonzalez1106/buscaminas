
namespace Buscaminas.View
{
    partial class FrmPartida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadFilas = new System.Windows.Forms.NumericUpDown();
            this.txtCantidadColumnas = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.bsPartida = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadColumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPartida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPartida, "NombreJugador", true));
            this.txtUsuario.Location = new System.Drawing.Point(247, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(316, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Filas;";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de Columnas:";
            // 
            // txtCantidadFilas
            // 
            this.txtCantidadFilas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCantidadFilas.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPartida, "CantidadFilas", true));
            this.txtCantidadFilas.Location = new System.Drawing.Point(247, 145);
            this.txtCantidadFilas.Name = "txtCantidadFilas";
            this.txtCantidadFilas.Size = new System.Drawing.Size(120, 20);
            this.txtCantidadFilas.TabIndex = 4;
            // 
            // txtCantidadColumnas
            // 
            this.txtCantidadColumnas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCantidadColumnas.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPartida, "CantidadColumnas", true));
            this.txtCantidadColumnas.Location = new System.Drawing.Point(247, 209);
            this.txtCantidadColumnas.Name = "txtCantidadColumnas";
            this.txtCantidadColumnas.Size = new System.Drawing.Size(120, 20);
            this.txtCantidadColumnas.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(247, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Comenzar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bsPartida
            // 
            this.bsPartida.DataSource = typeof(Buscaminas.BL.BO.Partida);
            // 
            // FrmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCantidadColumnas);
            this.Controls.Add(this.txtCantidadFilas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPartida";
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadColumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPartida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtCantidadFilas;
        private System.Windows.Forms.NumericUpDown txtCantidadColumnas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsPartida;
    }
}