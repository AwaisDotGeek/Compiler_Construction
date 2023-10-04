
namespace Lab4_Lexical_Analyzer
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
            this.Btn_Input = new System.Windows.Forms.Button();
            this.tfInput = new System.Windows.Forms.RichTextBox();
            this.tfTokens = new System.Windows.Forms.RichTextBox();
            this.symbolTable = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Btn_Input
            // 
            this.Btn_Input.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Input.Location = new System.Drawing.Point(0, 365);
            this.Btn_Input.Name = "Btn_Input";
            this.Btn_Input.Size = new System.Drawing.Size(629, 136);
            this.Btn_Input.TabIndex = 0;
            this.Btn_Input.Text = "button";
            this.Btn_Input.UseVisualStyleBackColor = true;
            this.Btn_Input.Click += new System.EventHandler(this.Btn_Input_Click);
            // 
            // tfInput
            // 
            this.tfInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.tfInput.Location = new System.Drawing.Point(0, 0);
            this.tfInput.Name = "tfInput";
            this.tfInput.Size = new System.Drawing.Size(629, 185);
            this.tfInput.TabIndex = 1;
            this.tfInput.Text = "";
            // 
            // tfTokens
            // 
            this.tfTokens.Location = new System.Drawing.Point(0, 191);
            this.tfTokens.Name = "tfTokens";
            this.tfTokens.Size = new System.Drawing.Size(214, 168);
            this.tfTokens.TabIndex = 2;
            this.tfTokens.Text = "";
            // 
            // symbolTable
            // 
            this.symbolTable.Location = new System.Drawing.Point(220, 191);
            this.symbolTable.Name = "symbolTable";
            this.symbolTable.Size = new System.Drawing.Size(409, 168);
            this.symbolTable.TabIndex = 3;
            this.symbolTable.Text = "s";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(629, 501);
            this.Controls.Add(this.symbolTable);
            this.Controls.Add(this.tfTokens);
            this.Controls.Add(this.tfInput);
            this.Controls.Add(this.Btn_Input);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Input;
        private System.Windows.Forms.RichTextBox tfInput;
        private System.Windows.Forms.RichTextBox tfTokens;
        private System.Windows.Forms.RichTextBox symbolTable;
    }
}

