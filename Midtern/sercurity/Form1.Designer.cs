namespace sercurity
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
               this.tabControl1 = new System.Windows.Forms.TabControl();
               this.tabPage1 = new System.Windows.Forms.TabPage();
               this.label4 = new System.Windows.Forms.Label();
               this.button2 = new System.Windows.Forms.Button();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.txtCipher = new System.Windows.Forms.TextBox();
               this.txtText = new System.Windows.Forms.TextBox();
               this.txtKey = new System.Windows.Forms.TextBox();
               this.btnVi = new System.Windows.Forms.Button();
               this.tabPage2 = new System.Windows.Forms.TabPage();
               this.button3 = new System.Windows.Forms.Button();
               this.btnGiaiMa = new System.Windows.Forms.Button();
               this.txtGiaiMa2 = new System.Windows.Forms.TextBox();
               this.txtGiaiMa = new System.Windows.Forms.TextBox();
               this.txtKiTu = new System.Windows.Forms.TextBox();
               this.tabControl1.SuspendLayout();
               this.tabPage1.SuspendLayout();
               this.tabPage2.SuspendLayout();
               this.SuspendLayout();
               // 
               // tabControl1
               // 
               this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.tabControl1.Controls.Add(this.tabPage1);
               this.tabControl1.Controls.Add(this.tabPage2);
               this.tabControl1.Location = new System.Drawing.Point(-3, -3);
               this.tabControl1.Name = "tabControl1";
               this.tabControl1.SelectedIndex = 0;
               this.tabControl1.Size = new System.Drawing.Size(1340, 456);
               this.tabControl1.TabIndex = 13;
               // 
               // tabPage1
               // 
               this.tabPage1.Controls.Add(this.label4);
               this.tabPage1.Controls.Add(this.button2);
               this.tabPage1.Controls.Add(this.label3);
               this.tabPage1.Controls.Add(this.label2);
               this.tabPage1.Controls.Add(this.label1);
               this.tabPage1.Controls.Add(this.txtCipher);
               this.tabPage1.Controls.Add(this.txtText);
               this.tabPage1.Controls.Add(this.txtKey);
               this.tabPage1.Controls.Add(this.btnVi);
               this.tabPage1.Location = new System.Drawing.Point(4, 29);
               this.tabPage1.Name = "tabPage1";
               this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage1.Size = new System.Drawing.Size(1332, 423);
               this.tabPage1.TabIndex = 0;
               this.tabPage1.Text = "Vigernere";
               this.tabPage1.UseVisualStyleBackColor = true;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(704, 51);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(0, 20);
               this.label4.TabIndex = 17;
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(584, 312);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(104, 56);
               this.button2.TabIndex = 16;
               this.button2.Text = "<<<<<";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(972, 123);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(55, 20);
               this.label3.TabIndex = 15;
               this.label3.Text = "Cipher";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(32, 123);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(39, 20);
               this.label2.TabIndex = 14;
               this.label2.Text = "Text";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(80, 19);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(35, 20);
               this.label1.TabIndex = 13;
               this.label1.Text = "Key";
               // 
               // txtCipher
               // 
               this.txtCipher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
               this.txtCipher.Location = new System.Drawing.Point(736, 176);
               this.txtCipher.Multiline = true;
               this.txtCipher.Name = "txtCipher";
               this.txtCipher.Size = new System.Drawing.Size(528, 224);
               this.txtCipher.TabIndex = 12;
               // 
               // txtText
               // 
               this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
               this.txtText.Location = new System.Drawing.Point(56, 179);
               this.txtText.Multiline = true;
               this.txtText.Name = "txtText";
               this.txtText.Size = new System.Drawing.Size(488, 224);
               this.txtText.TabIndex = 11;
               // 
               // txtKey
               // 
               this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.txtKey.Location = new System.Drawing.Point(136, 19);
               this.txtKey.Multiline = true;
               this.txtKey.Name = "txtKey";
               this.txtKey.Size = new System.Drawing.Size(748, 48);
               this.txtKey.TabIndex = 10;
               // 
               // btnVi
               // 
               this.btnVi.Location = new System.Drawing.Point(584, 208);
               this.btnVi.Name = "btnVi";
               this.btnVi.Size = new System.Drawing.Size(104, 56);
               this.btnVi.TabIndex = 9;
               this.btnVi.Text = ">>>>>";
               this.btnVi.UseVisualStyleBackColor = true;
               this.btnVi.Click += new System.EventHandler(this.btnVi_Click);
               // 
               // tabPage2
               // 
               this.tabPage2.Controls.Add(this.button3);
               this.tabPage2.Controls.Add(this.btnGiaiMa);
               this.tabPage2.Controls.Add(this.txtGiaiMa2);
               this.tabPage2.Controls.Add(this.txtGiaiMa);
               this.tabPage2.Controls.Add(this.txtKiTu);
               this.tabPage2.Location = new System.Drawing.Point(4, 29);
               this.tabPage2.Name = "tabPage2";
               this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage2.Size = new System.Drawing.Size(1332, 423);
               this.tabPage2.TabIndex = 1;
               this.tabPage2.Text = "RSA";
               this.tabPage2.UseVisualStyleBackColor = true;
               // 
               // button3
               // 
               this.button3.Location = new System.Drawing.Point(424, 40);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(144, 40);
               this.button3.TabIndex = 4;
               this.button3.Text = "Mã hóa";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // btnGiaiMa
               // 
               this.btnGiaiMa.Location = new System.Drawing.Point(784, 40);
               this.btnGiaiMa.Name = "btnGiaiMa";
               this.btnGiaiMa.Size = new System.Drawing.Size(144, 40);
               this.btnGiaiMa.TabIndex = 3;
               this.btnGiaiMa.Text = "Giải mã";
               this.btnGiaiMa.UseVisualStyleBackColor = true;
               this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
               // 
               // txtGiaiMa2
               // 
               this.txtGiaiMa2.Location = new System.Drawing.Point(712, 88);
               this.txtGiaiMa2.Multiline = true;
               this.txtGiaiMa2.Name = "txtGiaiMa2";
               this.txtGiaiMa2.Size = new System.Drawing.Size(304, 320);
               this.txtGiaiMa2.TabIndex = 2;
               // 
               // txtGiaiMa
               // 
               this.txtGiaiMa.Location = new System.Drawing.Point(368, 88);
               this.txtGiaiMa.Multiline = true;
               this.txtGiaiMa.Name = "txtGiaiMa";
               this.txtGiaiMa.Size = new System.Drawing.Size(304, 320);
               this.txtGiaiMa.TabIndex = 1;
               // 
               // txtKiTu
               // 
               this.txtKiTu.Location = new System.Drawing.Point(16, 88);
               this.txtKiTu.Multiline = true;
               this.txtKiTu.Name = "txtKiTu";
               this.txtKiTu.Size = new System.Drawing.Size(304, 320);
               this.txtKiTu.TabIndex = 0;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.ClientSize = new System.Drawing.Size(1334, 450);
               this.Controls.Add(this.tabControl1);
               this.Name = "Form1";
               this.Text = "Vigenere Cipher - HKT\'s Production";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.tabControl1.ResumeLayout(false);
               this.tabPage1.ResumeLayout(false);
               this.tabPage1.PerformLayout();
               this.tabPage2.ResumeLayout(false);
               this.tabPage2.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.TabControl tabControl1;
          public System.Windows.Forms.TabPage tabPage1;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox txtCipher;
          private System.Windows.Forms.TextBox txtText;
          private System.Windows.Forms.TextBox txtKey;
          private System.Windows.Forms.Button btnVi;
          private System.Windows.Forms.TabPage tabPage2;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button btnGiaiMa;
          private System.Windows.Forms.TextBox txtGiaiMa2;
          private System.Windows.Forms.TextBox txtGiaiMa;
          private System.Windows.Forms.TextBox txtKiTu;
     }
}

