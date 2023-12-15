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
            this.NombreNuitValue = new System.Windows.Forms.TextBox();
            this.EnregistrerValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimeValue
            // 
            this.DateTimeValue.Location = new System.Drawing.Point(161, 139);
            this.DateTimeValue.Name = "DateTimeValue";
            this.DateTimeValue.Size = new System.Drawing.Size(200, 22);
            this.DateTimeValue.TabIndex = 0;
            // 
            // RemarqueValue
            // 
            this.RemarqueValue.Location = new System.Drawing.Point(161, 247);
            this.RemarqueValue.Name = "RemarqueValue";
            this.RemarqueValue.Size = new System.Drawing.Size(169, 22);
            this.RemarqueValue.TabIndex = 2;
            // 
            // DateTXT
            // 
            this.DateTXT.AutoSize = true;
            this.DateTXT.Location = new System.Drawing.Point(24, 139);
            this.DateTXT.Name = "DateTXT";
            this.DateTXT.Size = new System.Drawing.Size(98, 16);
            this.DateTXT.TabIndex = 3;
            this.DateTXT.Text = "Date d\'arrivée :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remarque :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de nuit :";
            // 
            // NombreNuitValue
            // 
            this.NombreNuitValue.Location = new System.Drawing.Point(161, 194);
            this.NombreNuitValue.Name = "NombreNuitValue";
            this.NombreNuitValue.Size = new System.Drawing.Size(100, 22);
            this.NombreNuitValue.TabIndex = 6;
            // 
            // EnregistrerValue
            // 
            this.EnregistrerValue.Location = new System.Drawing.Point(291, 327);
            this.EnregistrerValue.Name = "EnregistrerValue";
            this.EnregistrerValue.Size = new System.Drawing.Size(105, 35);
            this.EnregistrerValue.TabIndex = 7;
            this.EnregistrerValue.Text = "Enregistrer";
            this.EnregistrerValue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnregistrerValue);
            this.Controls.Add(this.NombreNuitValue);
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
        private System.Windows.Forms.TextBox NombreNuitValue;
        private System.Windows.Forms.Button EnregistrerValue;
    }
}

