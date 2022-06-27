
namespace WindowsFormsApp1
{
    partial class app
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
            this.btnuseradd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnuseradd
            // 
            this.btnuseradd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnuseradd.Location = new System.Drawing.Point(637, 44);
            this.btnuseradd.Name = "btnuseradd";
            this.btnuseradd.Size = new System.Drawing.Size(104, 23);
            this.btnuseradd.TabIndex = 0;
            this.btnuseradd.Text = "Add a user";
            this.btnuseradd.UseVisualStyleBackColor = true;
            this.btnuseradd.Click += new System.EventHandler(this.btnuseradd_Click);
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnuseradd);
            this.Name = "app";
            this.Text = "Uygulama Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnuseradd;
    }
}