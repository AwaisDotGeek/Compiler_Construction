
namespace Lab5_SymbolTable_Using_Array
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
            this.tfInput = new System.Windows.Forms.RichTextBox();
            this.tfTokens = new System.Windows.Forms.RichTextBox();
            this.symbolTable = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tfInput
            // 
            this.tfInput.Location = new System.Drawing.Point(12, 12);
            this.tfInput.Name = "tfInput";
            this.tfInput.Size = new System.Drawing.Size(776, 172);
            this.tfInput.TabIndex = 0;
            this.tfInput.Text = "";
            // 
            // tfTokens
            // 
            this.tfTokens.Location = new System.Drawing.Point(12, 190);
            this.tfTokens.Name = "tfTokens";
            this.tfTokens.Size = new System.Drawing.Size(232, 172);
            this.tfTokens.TabIndex = 1;
            this.tfTokens.Text = "";
            // 
            // symbolTable
            // 
            this.symbolTable.Location = new System.Drawing.Point(250, 190);
            this.symbolTable.Name = "symbolTable";
            this.symbolTable.Size = new System.Drawing.Size(538, 172);
            this.symbolTable.TabIndex = 2;
            this.symbolTable.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.symbolTable);
            this.Controls.Add(this.tfTokens);
            this.Controls.Add(this.tfInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tfInput;
        private System.Windows.Forms.RichTextBox tfTokens;
        private System.Windows.Forms.RichTextBox symbolTable;
    }
}

