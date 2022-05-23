namespace CalculoDeCurvas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barra_herramientas = new System.Windows.Forms.ToolStrip();
            this.Agrega_Vertice = new System.Windows.Forms.ToolStripButton();
            this.Elimina_Vertice = new System.Windows.Forms.ToolStripButton();
            this.Mueve_Vertice = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Agrega_Arista = new System.Windows.Forms.ToolStripButton();
            this.Elimina_Arista = new System.Windows.Forms.ToolStripButton();
            this.Mueve_Arista = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.laAmplitud = new System.Windows.Forms.Label();
            this.laRadianes = new System.Windows.Forms.Label();
            this.laPendiente = new System.Windows.Forms.Label();
            this.vdr1 = new System.Windows.Forms.Label();
            this.vdr2 = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.Label();
            this.barra_herramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra_herramientas
            // 
            this.barra_herramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Agrega_Vertice,
            this.Elimina_Vertice,
            this.Mueve_Vertice,
            this.toolStripSeparator1,
            this.Agrega_Arista,
            this.Elimina_Arista,
            this.Mueve_Arista});
            this.barra_herramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.barra_herramientas.Location = new System.Drawing.Point(0, 0);
            this.barra_herramientas.Name = "barra_herramientas";
            this.barra_herramientas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barra_herramientas.Size = new System.Drawing.Size(584, 25);
            this.barra_herramientas.TabIndex = 0;
            this.barra_herramientas.Text = "Barra de herramientas";
            this.barra_herramientas.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barra_herramientas_ItemClicked);
            // 
            // Agrega_Vertice
            // 
            this.Agrega_Vertice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Agrega_Vertice.Image = ((System.Drawing.Image)(resources.GetObject("Agrega_Vertice.Image")));
            this.Agrega_Vertice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Agrega_Vertice.Name = "Agrega_Vertice";
            this.Agrega_Vertice.Size = new System.Drawing.Size(87, 22);
            this.Agrega_Vertice.Text = "Agrega Vertice";
            // 
            // Elimina_Vertice
            // 
            this.Elimina_Vertice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Elimina_Vertice.Image = ((System.Drawing.Image)(resources.GetObject("Elimina_Vertice.Image")));
            this.Elimina_Vertice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Elimina_Vertice.Name = "Elimina_Vertice";
            this.Elimina_Vertice.Size = new System.Drawing.Size(88, 22);
            this.Elimina_Vertice.Text = "Elimina Vertice";
            // 
            // Mueve_Vertice
            // 
            this.Mueve_Vertice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Mueve_Vertice.Image = ((System.Drawing.Image)(resources.GetObject("Mueve_Vertice.Image")));
            this.Mueve_Vertice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Mueve_Vertice.Name = "Mueve_Vertice";
            this.Mueve_Vertice.Size = new System.Drawing.Size(85, 22);
            this.Mueve_Vertice.Text = "Mueve Vertice";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Agrega_Arista
            // 
            this.Agrega_Arista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Agrega_Arista.Image = ((System.Drawing.Image)(resources.GetObject("Agrega_Arista.Image")));
            this.Agrega_Arista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Agrega_Arista.Name = "Agrega_Arista";
            this.Agrega_Arista.Size = new System.Drawing.Size(82, 22);
            this.Agrega_Arista.Text = "Agrega Arista";
            // 
            // Elimina_Arista
            // 
            this.Elimina_Arista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Elimina_Arista.Image = ((System.Drawing.Image)(resources.GetObject("Elimina_Arista.Image")));
            this.Elimina_Arista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Elimina_Arista.Name = "Elimina_Arista";
            this.Elimina_Arista.Size = new System.Drawing.Size(83, 22);
            this.Elimina_Arista.Text = "Elimina Arista";
            // 
            // Mueve_Arista
            // 
            this.Mueve_Arista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Mueve_Arista.Image = ((System.Drawing.Image)(resources.GetObject("Mueve_Arista.Image")));
            this.Mueve_Arista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Mueve_Arista.Name = "Mueve_Arista";
            this.Mueve_Arista.Size = new System.Drawing.Size(82, 22);
            this.Mueve_Arista.Text = "Mueve_Arista";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // laAmplitud
            // 
            this.laAmplitud.AutoSize = true;
            this.laAmplitud.Location = new System.Drawing.Point(458, 25);
            this.laAmplitud.Name = "laAmplitud";
            this.laAmplitud.Size = new System.Drawing.Size(0, 13);
            this.laAmplitud.TabIndex = 2;
            // 
            // laRadianes
            // 
            this.laRadianes.AutoSize = true;
            this.laRadianes.Location = new System.Drawing.Point(458, 42);
            this.laRadianes.Name = "laRadianes";
            this.laRadianes.Size = new System.Drawing.Size(0, 13);
            this.laRadianes.TabIndex = 3;
            // 
            // laPendiente
            // 
            this.laPendiente.AutoSize = true;
            this.laPendiente.Location = new System.Drawing.Point(458, 59);
            this.laPendiente.Name = "laPendiente";
            this.laPendiente.Size = new System.Drawing.Size(0, 13);
            this.laPendiente.TabIndex = 4;
            // 
            // vdr1
            // 
            this.vdr1.AutoSize = true;
            this.vdr1.Location = new System.Drawing.Point(12, 539);
            this.vdr1.Name = "vdr1";
            this.vdr1.Size = new System.Drawing.Size(72, 13);
            this.vdr1.TabIndex = 5;
            this.vdr1.Text = "Vector DR2(,)";
            // 
            // vdr2
            // 
            this.vdr2.AutoSize = true;
            this.vdr2.Location = new System.Drawing.Point(12, 511);
            this.vdr2.Name = "vdr2";
            this.vdr2.Size = new System.Drawing.Size(72, 13);
            this.vdr2.TabIndex = 6;
            this.vdr2.Text = "Vector DR1(,)";
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Location = new System.Drawing.Point(12, 483);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(42, 13);
            this.angle.TabIndex = 7;
            this.angle.Text = "angulo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.vdr2);
            this.Controls.Add(this.vdr1);
            this.Controls.Add(this.laPendiente);
            this.Controls.Add(this.laRadianes);
            this.Controls.Add(this.laAmplitud);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barra_herramientas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curvas";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.barra_herramientas.ResumeLayout(false);
            this.barra_herramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barra_herramientas;
        private System.Windows.Forms.ToolStripButton Agrega_Vertice;
        private System.Windows.Forms.ToolStripButton Elimina_Vertice;
        private System.Windows.Forms.ToolStripButton Mueve_Vertice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Agrega_Arista;
        private System.Windows.Forms.ToolStripButton Elimina_Arista;
        private System.Windows.Forms.ToolStripButton Mueve_Arista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label laAmplitud;
        private System.Windows.Forms.Label laRadianes;
        private System.Windows.Forms.Label laPendiente;
        private System.Windows.Forms.Label vdr1;
        private System.Windows.Forms.Label vdr2;
        private System.Windows.Forms.Label angle;
    }
}

