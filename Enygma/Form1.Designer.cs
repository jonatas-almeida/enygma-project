
namespace Enygma
{
    partial class Enygma
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.btnCreateKeys = new System.Windows.Forms.Label();
            this.btnImportPublicKey = new System.Windows.Forms.Label();
            this.btnExportPublicKey = new System.Windows.Forms.Label();
            this.btnGetPrivateKey = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.openFileDialogEncrypt = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDecrypt = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enygma";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(214)))), ((int)(((byte)(117)))));
            this.panel1.Location = new System.Drawing.Point(43, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 3);
            this.panel1.TabIndex = 1;
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDescriptografar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescriptografar.FlatAppearance.BorderSize = 0;
            this.btnDescriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescriptografar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescriptografar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDescriptografar.Location = new System.Drawing.Point(187, 221);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(134, 33);
            this.btnDescriptografar.TabIndex = 3;
            this.btnDescriptografar.Text = "Descriptografar";
            this.btnDescriptografar.UseVisualStyleBackColor = false;
            this.btnDescriptografar.Click += new System.EventHandler(this.btnDescriptografar_Click);
            // 
            // btnCreateKeys
            // 
            this.btnCreateKeys.AutoSize = true;
            this.btnCreateKeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateKeys.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateKeys.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateKeys.Location = new System.Drawing.Point(38, 23);
            this.btnCreateKeys.Name = "btnCreateKeys";
            this.btnCreateKeys.Size = new System.Drawing.Size(80, 15);
            this.btnCreateKeys.TabIndex = 4;
            this.btnCreateKeys.Text = "Criar chaves";
            this.btnCreateKeys.Click += new System.EventHandler(this.btnCreateKeys_Click);
            // 
            // btnImportPublicKey
            // 
            this.btnImportPublicKey.AutoSize = true;
            this.btnImportPublicKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportPublicKey.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportPublicKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportPublicKey.Location = new System.Drawing.Point(144, 23);
            this.btnImportPublicKey.Name = "btnImportPublicKey";
            this.btnImportPublicKey.Size = new System.Drawing.Size(99, 15);
            this.btnImportPublicKey.TabIndex = 5;
            this.btnImportPublicKey.Text = "Importar chave";
            // 
            // btnExportPublicKey
            // 
            this.btnExportPublicKey.AutoSize = true;
            this.btnExportPublicKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPublicKey.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPublicKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportPublicKey.Location = new System.Drawing.Point(266, 23);
            this.btnExportPublicKey.Name = "btnExportPublicKey";
            this.btnExportPublicKey.Size = new System.Drawing.Size(97, 15);
            this.btnExportPublicKey.TabIndex = 6;
            this.btnExportPublicKey.Text = "Exportar chave";
            // 
            // btnGetPrivateKey
            // 
            this.btnGetPrivateKey.AutoSize = true;
            this.btnGetPrivateKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetPrivateKey.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPrivateKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetPrivateKey.Location = new System.Drawing.Point(483, 23);
            this.btnGetPrivateKey.Name = "btnGetPrivateKey";
            this.btnGetPrivateKey.Size = new System.Drawing.Size(128, 15);
            this.btnGetPrivateKey.TabIndex = 7;
            this.btnGetPrivateKey.Text = "Obter chave privada";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(214)))), ((int)(((byte)(117)))));
            this.panel2.Location = new System.Drawing.Point(79, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 3);
            this.panel2.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(512, 360);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 29);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnCriptografar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriptografar.FlatAppearance.BorderSize = 0;
            this.btnCriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriptografar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptografar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCriptografar.Location = new System.Drawing.Point(43, 221);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(134, 33);
            this.btnCriptografar.TabIndex = 10;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = false;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "As chaves irão aparecer abaixo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(214)))), ((int)(((byte)(117)))));
            this.panel3.Location = new System.Drawing.Point(79, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 3);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(214)))), ((int)(((byte)(117)))));
            this.panel4.Location = new System.Drawing.Point(43, 329);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 3);
            this.panel4.TabIndex = 12;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelMessage.Location = new System.Drawing.Point(41, 355);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(156, 16);
            this.labelMessage.TabIndex = 14;
            this.labelMessage.Text = "Nenhuma chave gerada";
            // 
            // openFileDialogEncrypt
            // 
            this.openFileDialogEncrypt.FileName = "openFileDialog1";
            // 
            // openFileDialogDecrypt
            // 
            this.openFileDialogDecrypt.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Extensão do arquivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(43, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Digite a extensão do arquivo antes de descriptografar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = ".";
            // 
            // Enygma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(648, 416);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGetPrivateKey);
            this.Controls.Add(this.btnExportPublicKey);
            this.Controls.Add(this.btnImportPublicKey);
            this.Controls.Add(this.btnCreateKeys);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Enygma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enygma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.Label btnCreateKeys;
        private System.Windows.Forms.Label btnImportPublicKey;
        private System.Windows.Forms.Label btnExportPublicKey;
        private System.Windows.Forms.Label btnGetPrivateKey;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.OpenFileDialog openFileDialogEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialogDecrypt;
        private System.Windows.Forms.TextBox fileExtension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

