namespace Delegated_0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInvoke = new System.Windows.Forms.Button();
            this.btn2Invoke = new System.Windows.Forms.Button();
            this.btn3Invoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvoke
            // 
            this.btnInvoke.Location = new System.Drawing.Point(95, 86);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(214, 29);
            this.btnInvoke.TabIndex = 0;
            this.btnInvoke.Text = "Delegate Çalıştır";
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // btn2Invoke
            // 
            this.btn2Invoke.Location = new System.Drawing.Point(397, 86);
            this.btn2Invoke.Name = "btn2Invoke";
            this.btn2Invoke.Size = new System.Drawing.Size(217, 29);
            this.btn2Invoke.TabIndex = 1;
            this.btn2Invoke.Text = "Delegate Çalıştırma 2";
            this.btn2Invoke.UseVisualStyleBackColor = true;
            this.btn2Invoke.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn3Invoke
            // 
            this.btn3Invoke.Location = new System.Drawing.Point(297, 186);
            this.btn3Invoke.Name = "btn3Invoke";
            this.btn3Invoke.Size = new System.Drawing.Size(239, 29);
            this.btn3Invoke.TabIndex = 2;
            this.btn3Invoke.Text = "Islem Yap";
            this.btn3Invoke.UseVisualStyleBackColor = true;
            this.btn3Invoke.Click += new System.EventHandler(this.btn3Invoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn3Invoke);
            this.Controls.Add(this.btn2Invoke);
            this.Controls.Add(this.btnInvoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnInvoke;
        private Button btn2Invoke;
        private Button btn3Invoke;
    }
}