namespace EstruturasDeRepeticao2
{
    partial class FrmTabuada
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnDescobrir = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(230, 103);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(116, 34);
            this.txtNumero.TabIndex = 0;
            // 
            // btnDescobrir
            // 
            this.btnDescobrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescobrir.Location = new System.Drawing.Point(410, 103);
            this.btnDescobrir.Name = "btnDescobrir";
            this.btnDescobrir.Size = new System.Drawing.Size(100, 35);
            this.btnDescobrir.TabIndex = 1;
            this.btnDescobrir.Text = "Descobrir";
            this.btnDescobrir.UseVisualStyleBackColor = true;
            this.btnDescobrir.Click += new System.EventHandler(this.btnDescobrir_Click);
            // 
            // txtLista
            // 
            this.txtLista.FormattingEnabled = true;
            this.txtLista.Location = new System.Drawing.Point(138, 166);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(372, 199);
            this.txtLista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tabuada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número:";
            // 
            // FrmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.btnDescobrir);
            this.Controls.Add(this.txtNumero);
            this.Name = "FrmTabuada";
            this.Text = "FrmTabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnDescobrir;
        private System.Windows.Forms.ListBox txtLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}