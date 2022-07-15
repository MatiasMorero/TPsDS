namespace PobreTITO
{
    partial class Reclamo
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
            this.btn_RealizarReclamo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Incidente = new System.Windows.Forms.ComboBox();
            this.cb_subIncidente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RealizarReclamo
            // 
            this.btn_RealizarReclamo.Location = new System.Drawing.Point(117, 384);
            this.btn_RealizarReclamo.Name = "btn_RealizarReclamo";
            this.btn_RealizarReclamo.Size = new System.Drawing.Size(343, 25);
            this.btn_RealizarReclamo.TabIndex = 45;
            this.btn_RealizarReclamo.Text = "Realizar Reclamo";
            this.btn_RealizarReclamo.UseVisualStyleBackColor = true;
            this.btn_RealizarReclamo.Click += new System.EventHandler(this.btn_RealizarReclamo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(508, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Hola! Bienvenidos al sector de reclamos online, complete los siguiente campos par" +
    "a su gestion.";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(49, 222);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(203, 23);
            this.txt_Direccion.TabIndex = 43;
            this.txt_Direccion.Text = "Direccion";
            this.txt_Direccion.Enter += new System.EventHandler(this.txt_Direccion_Enter);
            this.txt_Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Direccion_KeyPress);
            this.txt_Direccion.Leave += new System.EventHandler(this.txt_Direccion_Leave);
            this.txt_Direccion.MouseEnter += new System.EventHandler(this.txt_Direccion_MouseEnter);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(13, 271);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(574, 104);
            this.txt_Descripcion.TabIndex = 40;
            this.txt_Descripcion.Text = "Descripcion";
            this.txt_Descripcion.Enter += new System.EventHandler(this.txt_Descripcion_Enter);
            this.txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Descripcion_KeyPress);
            this.txt_Descripcion.Leave += new System.EventHandler(this.txt_Descripcion_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ingrese todos los datos que crea relevantes para poder indentificar el incidente." +
    "";
            // 
            // cb_Incidente
            // 
            this.cb_Incidente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Incidente.FormattingEnabled = true;
            this.cb_Incidente.Location = new System.Drawing.Point(49, 128);
            this.cb_Incidente.Name = "cb_Incidente";
            this.cb_Incidente.Size = new System.Drawing.Size(203, 23);
            this.cb_Incidente.TabIndex = 49;
            this.cb_Incidente.SelectedIndexChanged += new System.EventHandler(this.cb_Incidente_SelectedIndexChanged);
            // 
            // cb_subIncidente
            // 
            this.cb_subIncidente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_subIncidente.FormattingEnabled = true;
            this.cb_subIncidente.Location = new System.Drawing.Point(49, 178);
            this.cb_subIncidente.Name = "cb_subIncidente";
            this.cb_subIncidente.Size = new System.Drawing.Size(203, 23);
            this.cb_subIncidente.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "OFICINA VIRTUAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "PobreTito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PobreTITO.Properties.Resources.Imagen1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PobreTITO.Properties.Resources.Imagen4;
            this.pictureBox4.Location = new System.Drawing.Point(9, 217);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PobreTITO.Properties.Resources.png_transparent_computer_icons_task_other_categories_miscellaneous_angle_text;
            this.pictureBox2.Location = new System.Drawing.Point(7, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PobreTITO.Properties.Resources.png_transparent_computer_icons_task_other_categories_miscellaneous_angle_text;
            this.pictureBox5.Location = new System.Drawing.Point(7, 119);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 54;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(49, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "Seleccionar categoria.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(49, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "Seleccionar sub categoria.";
            // 
            // Reclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 419);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_subIncidente);
            this.Controls.Add(this.cb_Incidente);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_RealizarReclamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label3);
            this.Name = "Reclamo";
            this.Text = "Reclamo";
            this.Load += new System.EventHandler(this.Reclamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_RealizarReclamo;
        private Label label4;
        private TextBox txt_Direccion;
        private TextBox txt_Descripcion;
        private Label label3;
        private ComboBox cb_Incidente;
        private ComboBox cb_subIncidente;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label6;
    }
}