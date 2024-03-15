
namespace _5
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
            this.btnTransparency = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.btnSuperMegaButton = new System.Windows.Forms.Button();
            this.chkChangeTransparency = new System.Windows.Forms.CheckBox();
            this.chkChangeColor = new System.Windows.Forms.CheckBox();
            this.chkChangeHelloWorld = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTransparency
            // 
            this.btnTransparency.Location = new System.Drawing.Point(35, 24);
            this.btnTransparency.Name = "btnTransparency";
            this.btnTransparency.Size = new System.Drawing.Size(122, 34);
            this.btnTransparency.TabIndex = 0;
            this.btnTransparency.Text = "Прозорість";
            this.btnTransparency.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(211, 24);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(122, 34);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Колір тла";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Location = new System.Drawing.Point(388, 24);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(122, 34);
            this.btnHelloWorld.TabIndex = 2;
            this.btnHelloWorld.Text = "Hello World";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            // 
            // btnSuperMegaButton
            // 
            this.btnSuperMegaButton.Location = new System.Drawing.Point(126, 64);
            this.btnSuperMegaButton.Name = "btnSuperMegaButton";
            this.btnSuperMegaButton.Size = new System.Drawing.Size(300, 34);
            this.btnSuperMegaButton.TabIndex = 3;
            this.btnSuperMegaButton.Text = "Супермегакнопка";
            this.btnSuperMegaButton.UseVisualStyleBackColor = true;
            // 
            // chkChangeTransparency
            // 
            this.chkChangeTransparency.AutoSize = true;
            this.chkChangeTransparency.Location = new System.Drawing.Point(35, 127);
            this.chkChangeTransparency.Name = "chkChangeTransparency";
            this.chkChangeTransparency.Size = new System.Drawing.Size(265, 19);
            this.chkChangeTransparency.TabIndex = 4;
            this.chkChangeTransparency.Text = "\"Cупермегакнопка\" поглинає \"Прозорість\"";
            this.chkChangeTransparency.UseVisualStyleBackColor = true;
            // 
            // chkChangeColor
            // 
            this.chkChangeColor.AutoSize = true;
            this.chkChangeColor.Location = new System.Drawing.Point(35, 152);
            this.chkChangeColor.Name = "chkChangeColor";
            this.chkChangeColor.Size = new System.Drawing.Size(255, 19);
            this.chkChangeColor.TabIndex = 5;
            this.chkChangeColor.Text = "\"Cупермегакнопка\" поглинає \"Kолір тла\"";
            this.chkChangeColor.UseVisualStyleBackColor = true;
            // 
            // chkChangeHelloWorld
            // 
            this.chkChangeHelloWorld.AutoSize = true;
            this.chkChangeHelloWorld.Location = new System.Drawing.Point(35, 177);
            this.chkChangeHelloWorld.Name = "chkChangeHelloWorld";
            this.chkChangeHelloWorld.Size = new System.Drawing.Size(266, 19);
            this.chkChangeHelloWorld.TabIndex = 6;
            this.chkChangeHelloWorld.Text = "\"Супермегакнопка\" поглинає \"Hello World\"";
            this.chkChangeHelloWorld.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 238);
            this.Controls.Add(this.chkChangeHelloWorld);
            this.Controls.Add(this.chkChangeColor);
            this.Controls.Add(this.chkChangeTransparency);
            this.Controls.Add(this.btnSuperMegaButton);
            this.Controls.Add(this.btnHelloWorld);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnTransparency);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransparency;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Button btnSuperMegaButton;
        private System.Windows.Forms.CheckBox chkChangeTransparency;
        private System.Windows.Forms.CheckBox chkChangeColor;
        private System.Windows.Forms.CheckBox chkChangeHelloWorld;
    }
}

