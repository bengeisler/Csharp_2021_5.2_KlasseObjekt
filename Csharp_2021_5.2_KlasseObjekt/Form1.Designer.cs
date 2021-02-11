
namespace Csharp_2021_5._2_KlasseObjekt
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblAnzeige = new System.Windows.Forms.Label();
			this.btnAnzeigen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblAnzeige
			// 
			this.lblAnzeige.AutoSize = true;
			this.lblAnzeige.Location = new System.Drawing.Point(12, 19);
			this.lblAnzeige.Name = "lblAnzeige";
			this.lblAnzeige.Size = new System.Drawing.Size(35, 13);
			this.lblAnzeige.TabIndex = 0;
			this.lblAnzeige.Text = "label1";
			// 
			// btnAnzeigen
			// 
			this.btnAnzeigen.Location = new System.Drawing.Point(261, 19);
			this.btnAnzeigen.Name = "btnAnzeigen";
			this.btnAnzeigen.Size = new System.Drawing.Size(75, 23);
			this.btnAnzeigen.TabIndex = 1;
			this.btnAnzeigen.Text = "Anzeigen";
			this.btnAnzeigen.UseVisualStyleBackColor = true;
			this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 76);
			this.Controls.Add(this.btnAnzeigen);
			this.Controls.Add(this.lblAnzeige);
			this.Name = "Form1";
			this.Text = "Klasse, Objekt";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAnzeige;
		private System.Windows.Forms.Button btnAnzeigen;
	}
}

