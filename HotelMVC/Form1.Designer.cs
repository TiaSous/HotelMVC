namespace HotelMVC
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateTimeValue = new System.Windows.Forms.DateTimePicker();
            this.RemarqueValue = new System.Windows.Forms.TextBox();
            this.DateTXT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnregistrerValue = new System.Windows.Forms.Button();
            this.NombreDeNuitValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTimeValue
            // 
            this.DateTimeValue.Location = new System.Drawing.Point(163, 100);
            this.DateTimeValue.Name = "DateTimeValue";
            this.DateTimeValue.Size = new System.Drawing.Size(200, 22);
            this.DateTimeValue.TabIndex = 0;
            // 
            // RemarqueValue
            // 
            this.RemarqueValue.Location = new System.Drawing.Point(163, 208);
            this.RemarqueValue.Name = "RemarqueValue";
            this.RemarqueValue.Size = new System.Drawing.Size(169, 22);
            this.RemarqueValue.TabIndex = 2;
            // 
            // DateTXT
            // 
            this.DateTXT.AutoSize = true;
            this.DateTXT.Location = new System.Drawing.Point(26, 100);
            this.DateTXT.Name = "DateTXT";
            this.DateTXT.Size = new System.Drawing.Size(98, 16);
            this.DateTXT.TabIndex = 3;
            this.DateTXT.Text = "Date d\'arrivée :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remarque :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de nuit :";
            // 
            // EnregistrerValue
            // 
            this.EnregistrerValue.Location = new System.Drawing.Point(372, 286);
            this.EnregistrerValue.Name = "EnregistrerValue";
            this.EnregistrerValue.Size = new System.Drawing.Size(105, 35);
            this.EnregistrerValue.TabIndex = 7;
            this.EnregistrerValue.Text = "Enregistrer";
            this.EnregistrerValue.UseVisualStyleBackColor = true;
            this.EnregistrerValue.Click += new System.EventHandler(this.EnregistrerValue_Click);
            // 
            // NombreDeNuitValue
            // 
            this.NombreDeNuitValue.Location = new System.Drawing.Point(163, 155);
            this.NombreDeNuitValue.Name = "NombreDeNuitValue";
            this.NombreDeNuitValue.Size = new System.Drawing.Size(100, 22);
            this.NombreDeNuitValue.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chambre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreDeNuitValue);
            this.Controls.Add(this.EnregistrerValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTXT);
            this.Controls.Add(this.RemarqueValue);
            this.Controls.Add(this.DateTimeValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimeValue;
        private System.Windows.Forms.TextBox RemarqueValue;
        private System.Windows.Forms.Label DateTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EnregistrerValue;
        private System.Windows.Forms.TextBox NombreDeNuitValue;
        private System.Windows.Forms.Label label1;
    }
}

