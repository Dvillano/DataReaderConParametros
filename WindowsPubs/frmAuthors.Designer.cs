
namespace WindowsPubs
{
    partial class frmAuthors
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
            this.gridAuthors = new System.Windows.Forms.DataGridView();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnTraerCiudad = new System.Windows.Forms.Button();
            this.btnTraerAutor = new System.Windows.Forms.Button();
            this.btnTraerAutorCiudadEstado = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAuthors
            // 
            this.gridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAuthors.Location = new System.Drawing.Point(0, 141);
            this.gridAuthors.Name = "gridAuthors";
            this.gridAuthors.Size = new System.Drawing.Size(800, 309);
            this.gridAuthors.TabIndex = 0;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(4, 80);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(46, 13);
            this.lblCiudad.TabIndex = 1;
            this.lblCiudad.Text = "Ciudad: ";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(56, 77);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 2;
            // 
            // btnTraerCiudad
            // 
            this.btnTraerCiudad.Location = new System.Drawing.Point(162, 75);
            this.btnTraerCiudad.Name = "btnTraerCiudad";
            this.btnTraerCiudad.Size = new System.Drawing.Size(148, 23);
            this.btnTraerCiudad.TabIndex = 3;
            this.btnTraerCiudad.Text = "Traer autor por ciudad";
            this.btnTraerCiudad.UseVisualStyleBackColor = true;
            this.btnTraerCiudad.Click += new System.EventHandler(this.btnTraerCiudad_Click);
            // 
            // btnTraerAutor
            // 
            this.btnTraerAutor.Location = new System.Drawing.Point(353, 104);
            this.btnTraerAutor.Name = "btnTraerAutor";
            this.btnTraerAutor.Size = new System.Drawing.Size(148, 23);
            this.btnTraerAutor.TabIndex = 4;
            this.btnTraerAutor.Text = "Traer todos los autores";
            this.btnTraerAutor.UseVisualStyleBackColor = true;
            this.btnTraerAutor.Click += new System.EventHandler(this.btnTraerAutor_Click);
            // 
            // btnTraerAutorCiudadEstado
            // 
            this.btnTraerAutorCiudadEstado.Location = new System.Drawing.Point(162, 104);
            this.btnTraerAutorCiudadEstado.Name = "btnTraerAutorCiudadEstado";
            this.btnTraerAutorCiudadEstado.Size = new System.Drawing.Size(185, 23);
            this.btnTraerAutorCiudadEstado.TabIndex = 7;
            this.btnTraerAutorCiudadEstado.Text = "Traer autor por ciudad y estado";
            this.btnTraerAutorCiudadEstado.UseVisualStyleBackColor = true;
            this.btnTraerAutorCiudadEstado.Click += new System.EventHandler(this.btnTraerAutorCiudadEstado_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(56, 106);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(4, 109);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado: ";
            // 
            // frmAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTraerAutorCiudadEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnTraerAutor);
            this.Controls.Add(this.btnTraerCiudad);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.gridAuthors);
            this.Name = "frmAuthors";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAuthors;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnTraerCiudad;
        private System.Windows.Forms.Button btnTraerAutor;
        private System.Windows.Forms.Button btnTraerAutorCiudadEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}

