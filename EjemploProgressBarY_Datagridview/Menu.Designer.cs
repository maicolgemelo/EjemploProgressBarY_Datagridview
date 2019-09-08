namespace EjemploProgressBarY_Datagridview
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUsoGroupBox = new System.Windows.Forms.Button();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Uso de Datagridview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsoGroupBox
            // 
            this.btnUsoGroupBox.Location = new System.Drawing.Point(145, 225);
            this.btnUsoGroupBox.Name = "btnUsoGroupBox";
            this.btnUsoGroupBox.Size = new System.Drawing.Size(223, 66);
            this.btnUsoGroupBox.TabIndex = 2;
            this.btnUsoGroupBox.Text = "Uso GroupBox";
            this.btnUsoGroupBox.UseVisualStyleBackColor = true;
            this.btnUsoGroupBox.Click += new System.EventHandler(this.btnUsoGroupBox_Click);
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.Location = new System.Drawing.Point(215, 327);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(75, 23);
            this.btnSalirMenu.TabIndex = 3;
            this.btnSalirMenu.Text = "Salir";
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirMenu);
            this.Controls.Add(this.btnUsoGroupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUsoGroupBox;
        private System.Windows.Forms.Button btnSalirMenu;
    }
}