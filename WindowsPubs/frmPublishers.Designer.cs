
namespace WindowsPubs
{
    partial class frmPublishers
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
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            this.btnTraerPublisherCiudad = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.btnTraerPublisherCiudadEstado = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnTraerPublisher = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPublisher
            // 
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPublisher.Location = new System.Drawing.Point(0, 150);
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.Size = new System.Drawing.Size(624, 303);
            this.gridPublisher.TabIndex = 0;
            // 
            // btnTraerPublisherCiudad
            // 
            this.btnTraerPublisherCiudad.Location = new System.Drawing.Point(169, 58);
            this.btnTraerPublisherCiudad.Name = "btnTraerPublisherCiudad";
            this.btnTraerPublisherCiudad.Size = new System.Drawing.Size(148, 23);
            this.btnTraerPublisherCiudad.TabIndex = 6;
            this.btnTraerPublisherCiudad.Text = "Traer publicador por ciudad";
            this.btnTraerPublisherCiudad.UseVisualStyleBackColor = true;
            this.btnTraerPublisherCiudad.Click += new System.EventHandler(this.btnTraerCiudad_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(63, 60);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 5;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(11, 63);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(46, 13);
            this.lblCiudad.TabIndex = 4;
            this.lblCiudad.Text = "Ciudad: ";
            // 
            // btnTraerPublisherCiudadEstado
            // 
            this.btnTraerPublisherCiudadEstado.Location = new System.Drawing.Point(169, 87);
            this.btnTraerPublisherCiudadEstado.Name = "btnTraerPublisherCiudadEstado";
            this.btnTraerPublisherCiudadEstado.Size = new System.Drawing.Size(223, 23);
            this.btnTraerPublisherCiudadEstado.TabIndex = 11;
            this.btnTraerPublisherCiudadEstado.Text = "Traer publicador por ciudad y estado";
            this.btnTraerPublisherCiudadEstado.UseVisualStyleBackColor = true;
            this.btnTraerPublisherCiudadEstado.Click += new System.EventHandler(this.btnTraerPublisherCiudadEstado_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(64, 89);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 92);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado: ";
            // 
            // btnTraerPublisher
            // 
            this.btnTraerPublisher.Location = new System.Drawing.Point(431, 118);
            this.btnTraerPublisher.Name = "btnTraerPublisher";
            this.btnTraerPublisher.Size = new System.Drawing.Size(148, 23);
            this.btnTraerPublisher.TabIndex = 8;
            this.btnTraerPublisher.Text = "Traer todos los publicadores";
            this.btnTraerPublisher.UseVisualStyleBackColor = true;
            this.btnTraerPublisher.Click += new System.EventHandler(this.btnTraerPublisher_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Traer publicador por ciudad, estado y pais";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(64, 118);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 13;
            // 
            // lblPais
            // 
            this.lblPais.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 121);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 12;
            this.lblPais.Text = "Pais:";
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.btnTraerPublisherCiudadEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnTraerPublisher);
            this.Controls.Add(this.btnTraerPublisherCiudad);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.gridPublisher);
            this.Name = "frmPublishers";
            this.Text = "frmPublishers";
            this.Load += new System.EventHandler(this.frmPublishers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPublisher;
        private System.Windows.Forms.Button btnTraerPublisherCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Button btnTraerPublisherCiudadEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnTraerPublisher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
    }
}