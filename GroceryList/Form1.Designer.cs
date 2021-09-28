
namespace GroceryList
{
    partial class Form1
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
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.checkBoxWholeFoods = new System.Windows.Forms.CheckBox();
            this.checkBoxCostco = new System.Windows.Forms.CheckBox();
            this.checkBoxFredMeyer = new System.Windows.Forms.CheckBox();
            this.checkBoxApnaBazaar = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxItems
            // 
            this.textBoxItems.Location = new System.Drawing.Point(63, 87);
            this.textBoxItems.Multiline = true;
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.Size = new System.Drawing.Size(175, 209);
            this.textBoxItems.TabIndex = 0;
            this.textBoxItems.Enter += new System.EventHandler(this.textBoxItems_Enter);
            // 
            // checkBoxWholeFoods
            // 
            this.checkBoxWholeFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWholeFoods.Location = new System.Drawing.Point(397, 89);
            this.checkBoxWholeFoods.Name = "checkBoxWholeFoods";
            this.checkBoxWholeFoods.Size = new System.Drawing.Size(100, 40);
            this.checkBoxWholeFoods.TabIndex = 1;
            this.checkBoxWholeFoods.Text = "Whole Foods";
            this.checkBoxWholeFoods.UseVisualStyleBackColor = true;
            // 
            // checkBoxCostco
            // 
            this.checkBoxCostco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCostco.Location = new System.Drawing.Point(397, 133);
            this.checkBoxCostco.Name = "checkBoxCostco";
            this.checkBoxCostco.Size = new System.Drawing.Size(100, 40);
            this.checkBoxCostco.TabIndex = 2;
            this.checkBoxCostco.Text = "Costco";
            this.checkBoxCostco.UseVisualStyleBackColor = true;
            // 
            // checkBoxFredMeyer
            // 
            this.checkBoxFredMeyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFredMeyer.Location = new System.Drawing.Point(397, 178);
            this.checkBoxFredMeyer.Name = "checkBoxFredMeyer";
            this.checkBoxFredMeyer.Size = new System.Drawing.Size(100, 40);
            this.checkBoxFredMeyer.TabIndex = 3;
            this.checkBoxFredMeyer.Text = "Fred Meyer";
            this.checkBoxFredMeyer.UseVisualStyleBackColor = true;
            // 
            // checkBoxApnaBazaar
            // 
            this.checkBoxApnaBazaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxApnaBazaar.Location = new System.Drawing.Point(397, 230);
            this.checkBoxApnaBazaar.Name = "checkBoxApnaBazaar";
            this.checkBoxApnaBazaar.Size = new System.Drawing.Size(100, 40);
            this.checkBoxApnaBazaar.TabIndex = 4;
            this.checkBoxApnaBazaar.Text = "Apna Bazaar";
            this.checkBoxApnaBazaar.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(123, 351);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonMail
            // 
            this.buttonMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMail.Location = new System.Drawing.Point(420, 351);
            this.buttonMail.Name = "buttonMail";
            this.buttonMail.Size = new System.Drawing.Size(75, 23);
            this.buttonMail.TabIndex = 6;
            this.buttonMail.Text = "Send Mail";
            this.buttonMail.UseVisualStyleBackColor = true;
            this.buttonMail.Click += new System.EventHandler(this.buttonMail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMail);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxApnaBazaar);
            this.Controls.Add(this.checkBoxFredMeyer);
            this.Controls.Add(this.checkBoxCostco);
            this.Controls.Add(this.checkBoxWholeFoods);
            this.Controls.Add(this.textBoxItems);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxItems;
        private System.Windows.Forms.CheckBox checkBoxWholeFoods;
        private System.Windows.Forms.CheckBox checkBoxCostco;
        private System.Windows.Forms.CheckBox checkBoxFredMeyer;
        private System.Windows.Forms.CheckBox checkBoxApnaBazaar;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonMail;
    }
}

