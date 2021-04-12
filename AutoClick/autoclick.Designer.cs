namespace AutoClick
{
    partial class autoclick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autoclick));
            this.BtnTerminar = new System.Windows.Forms.Button();
            this.TimerClick = new System.Windows.Forms.Timer(this.components);
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioclick = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.ImaagenAyuda = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImaagenAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTerminar
            // 
            this.BtnTerminar.Location = new System.Drawing.Point(231, 257);
            this.BtnTerminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTerminar.Name = "BtnTerminar";
            this.BtnTerminar.Size = new System.Drawing.Size(97, 28);
            this.BtnTerminar.TabIndex = 3;
            this.BtnTerminar.Text = "Detener / Stop ";
            this.BtnTerminar.UseVisualStyleBackColor = true;
            this.BtnTerminar.Click += new System.EventHandler(this.BtnTerminar_Click);
            // 
            // TimerClick
            // 
            this.TimerClick.Tick += new System.EventHandler(this.TimerClick_Tick);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(100, 257);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(97, 28);
            this.BtnIniciar.TabIndex = 8;
            this.BtnIniciar.Text = "Iniciar / Start";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(10, 33);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(187, 20);
            this.TxtTitulo.TabIndex = 13;
            this.TxtTitulo.Text = "Roblox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Velocidad /Speed";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioclick);
            this.panel1.Location = new System.Drawing.Point(214, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 78);
            this.panel1.TabIndex = 16;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(165, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Boton Central / Center Button";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(162, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Botón derecho /Right Button";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioclick
            // 
            this.radioclick.AutoSize = true;
            this.radioclick.Location = new System.Drawing.Point(15, 4);
            this.radioclick.Name = "radioclick";
            this.radioclick.Size = new System.Drawing.Size(159, 17);
            this.radioclick.TabIndex = 13;
            this.radioclick.TabStop = true;
            this.radioclick.Text = "Botón Izquierdo /Left Button";
            this.radioclick.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Location = new System.Drawing.Point(9, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 78);
            this.panel2.TabIndex = 17;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(4, 51);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(131, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Muy Rápido /Very fast";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(4, 28);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(90, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Rapido / Fast";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Normal";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Velocidad /Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Titulo Ventana Aplicación / Window Title";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(12, 298);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(74, 13);
            this.lblmsg.TabIndex = 19;
            this.lblmsg.Text = "Notificaciones";
            // 
            // ImaagenAyuda
            // 
            this.ImaagenAyuda.Image = ((System.Drawing.Image)(resources.GetObject("ImaagenAyuda.Image")));
            this.ImaagenAyuda.Location = new System.Drawing.Point(260, 25);
            this.ImaagenAyuda.Name = "ImaagenAyuda";
            this.ImaagenAyuda.Size = new System.Drawing.Size(297, 107);
            this.ImaagenAyuda.TabIndex = 20;
            this.ImaagenAyuda.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ejemplo titulo ventana / Window title sample";
            // 
            // autoclick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImaagenAyuda);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.BtnTerminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "autoclick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCLick - 1.0 RMusalemB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImaagenAyuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnTerminar;
        private System.Windows.Forms.Timer TimerClick;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioclick;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.PictureBox ImaagenAyuda;
        private System.Windows.Forms.Label label1;
    }
}

