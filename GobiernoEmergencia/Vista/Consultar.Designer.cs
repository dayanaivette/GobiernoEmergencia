namespace GobiernoEmergencia.Vista
{
    partial class Consultar
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
            this.brnAdmin = new System.Windows.Forms.Button();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblBeneficiado = new System.Windows.Forms.Label();
            this.lblMensajeBeneficiado = new System.Windows.Forms.Label();
            this.lblNoEres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brnAdmin
            // 
            this.brnAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.brnAdmin.FlatAppearance.BorderSize = 0;
            this.brnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnAdmin.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnAdmin.Location = new System.Drawing.Point(30, 25);
            this.brnAdmin.Name = "brnAdmin";
            this.brnAdmin.Size = new System.Drawing.Size(75, 28);
            this.brnAdmin.TabIndex = 0;
            this.brnAdmin.Text = "Admin";
            this.brnAdmin.UseVisualStyleBackColor = false;
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.Location = new System.Drawing.Point(199, 70);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(153, 21);
            this.lblConsultar.TabIndex = 1;
            this.lblConsultar.Text = "Consultar N° de DUI:";
            // 
            // txtConsultar
            // 
            this.txtConsultar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultar.Location = new System.Drawing.Point(155, 94);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(256, 19);
            this.txtConsultar.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(435, 86);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 27);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // lblBeneficiado
            // 
            this.lblBeneficiado.AutoSize = true;
            this.lblBeneficiado.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiado.Location = new System.Drawing.Point(188, 134);
            this.lblBeneficiado.Name = "lblBeneficiado";
            this.lblBeneficiado.Size = new System.Drawing.Size(177, 21);
            this.lblBeneficiado.TabIndex = 4;
            this.lblBeneficiado.Text = "Nombre del Beneficiado";
            // 
            // lblMensajeBeneficiado
            // 
            this.lblMensajeBeneficiado.AutoSize = true;
            this.lblMensajeBeneficiado.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeBeneficiado.Location = new System.Drawing.Point(151, 168);
            this.lblMensajeBeneficiado.Name = "lblMensajeBeneficiado";
            this.lblMensajeBeneficiado.Size = new System.Drawing.Size(264, 63);
            this.lblMensajeBeneficiado.TabIndex = 5;
            this.lblMensajeBeneficiado.Text = "Eres beneficiario del bono de $300 \r\nque el Gobierno ha otorgado ante la \r\nEmerge" +
    "ncia del COVID-19";
            this.lblMensajeBeneficiado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoEres
            // 
            this.lblNoEres.AutoSize = true;
            this.lblNoEres.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEres.Location = new System.Drawing.Point(132, 242);
            this.lblNoEres.Name = "lblNoEres";
            this.lblNoEres.Size = new System.Drawing.Size(327, 21);
            this.lblNoEres.TabIndex = 6;
            this.lblNoEres.Text = "Lo Sentimos! No eres Beneficiado por el bono";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 285);
            this.Controls.Add(this.lblNoEres);
            this.Controls.Add(this.lblMensajeBeneficiado);
            this.Controls.Add(this.lblBeneficiado);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.brnAdmin);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnAdmin;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblBeneficiado;
        private System.Windows.Forms.Label lblMensajeBeneficiado;
        private System.Windows.Forms.Label lblNoEres;
    }
}