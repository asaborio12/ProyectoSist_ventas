﻿namespace proTienda
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblID_PRODUCTO = new System.Windows.Forms.Label();
            this.lblCANTIDAD = new System.Windows.Forms.Label();
            this.txtID_PRODUCTO = new System.Windows.Forms.TextBox();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtGRAND_TOTAL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvVenta = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(6, 16);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(40, 16);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Label";
            // 
            // lblID_PRODUCTO
            // 
            this.lblID_PRODUCTO.AutoSize = true;
            this.lblID_PRODUCTO.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblID_PRODUCTO.Location = new System.Drawing.Point(78, 39);
            this.lblID_PRODUCTO.Name = "lblID_PRODUCTO";
            this.lblID_PRODUCTO.Size = new System.Drawing.Size(122, 16);
            this.lblID_PRODUCTO.TabIndex = 2;
            this.lblID_PRODUCTO.Text = "Clave de producto:";
            // 
            // lblCANTIDAD
            // 
            this.lblCANTIDAD.AutoSize = true;
            this.lblCANTIDAD.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblCANTIDAD.Location = new System.Drawing.Point(237, 39);
            this.lblCANTIDAD.Name = "lblCANTIDAD";
            this.lblCANTIDAD.Size = new System.Drawing.Size(65, 16);
            this.lblCANTIDAD.TabIndex = 3;
            this.lblCANTIDAD.Text = "Cantidad:";
            this.lblCANTIDAD.Click += new System.EventHandler(this.lblCANTIDAD_Click);
            // 
            // txtID_PRODUCTO
            // 
            this.txtID_PRODUCTO.Location = new System.Drawing.Point(81, 58);
            this.txtID_PRODUCTO.Name = "txtID_PRODUCTO";
            this.txtID_PRODUCTO.Size = new System.Drawing.Size(131, 20);
            this.txtID_PRODUCTO.TabIndex = 7;
            this.txtID_PRODUCTO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_PRODUCTO_KeyDown);
            this.txtID_PRODUCTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_PRODUCTO_KeyPress);
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Location = new System.Drawing.Point(240, 58);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(71, 20);
            this.txtCANTIDAD.TabIndex = 8;
            this.txtCANTIDAD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCANTIDAD_KeyDown);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackColor = System.Drawing.Color.Teal;
            this.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRealizarVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRealizarVenta.Location = new System.Drawing.Point(171, 458);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(154, 23);
            this.btnRealizarVenta.TabIndex = 10;
            this.btnRealizarVenta.Text = "Realizar venta (F5)";
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarProducto.Location = new System.Drawing.Point(24, 458);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(141, 23);
            this.btnBuscarProducto.TabIndex = 12;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Teal;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(360, 458);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(85, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIVA);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtGRAND_TOTAL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblIVA);
            this.groupBox1.Controls.Add(this.txtCANTIDAD);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.txtID_PRODUCTO);
            this.groupBox1.Controls.Add(this.lblID_PRODUCTO);
            this.groupBox1.Controls.Add(this.lblCANTIDAD);
            this.groupBox1.Location = new System.Drawing.Point(24, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(643, 35);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 13;
            this.txtIVA.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(479, 63);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 24);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Deshacer";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtGRAND_TOTAL
            // 
            this.txtGRAND_TOTAL.Location = new System.Drawing.Point(643, 63);
            this.txtGRAND_TOTAL.Name = "txtGRAND_TOTAL";
            this.txtGRAND_TOTAL.ReadOnly = true;
            this.txtGRAND_TOTAL.Size = new System.Drawing.Size(100, 20);
            this.txtGRAND_TOTAL.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(595, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total:";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblIVA.Location = new System.Drawing.Point(602, 37);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(32, 16);
            this.lblIVA.TabIndex = 10;
            this.lblIVA.Text = "IVA:";
            this.lblIVA.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 25);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // lvVenta
            // 
            this.lvVenta.Location = new System.Drawing.Point(24, 28);
            this.lvVenta.Name = "lvVenta";
            this.lvVenta.Size = new System.Drawing.Size(728, 284);
            this.lvVenta.TabIndex = 16;
            this.lvVenta.UseCompatibleStateImageBehavior = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(849, 498);
            this.Controls.Add(this.lvVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblID_PRODUCTO;
        private System.Windows.Forms.Label lblCANTIDAD;
        private System.Windows.Forms.TextBox txtID_PRODUCTO;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtGRAND_TOTAL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView lvVenta;
    }
}