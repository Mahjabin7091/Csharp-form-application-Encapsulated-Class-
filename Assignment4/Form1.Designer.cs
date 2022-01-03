
namespace Assignment4
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
            this.lblNameServiceSale = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblIsProcedure = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNameSaleService = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lbShowResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameServiceSale
            // 
            this.lblNameServiceSale.AutoSize = true;
            this.lblNameServiceSale.Location = new System.Drawing.Point(274, 99);
            this.lblNameServiceSale.Name = "lblNameServiceSale";
            this.lblNameServiceSale.Size = new System.Drawing.Size(113, 15);
            this.lblNameServiceSale.TabIndex = 0;
            this.lblNameServiceSale.Text = "Name(Sale/Service):";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(326, 142);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 15);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price:";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(326, 185);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(53, 15);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "Minutes:";
            // 
            // lblIsProcedure
            // 
            this.lblIsProcedure.AutoSize = true;
            this.lblIsProcedure.Location = new System.Drawing.Point(459, 226);
            this.lblIsProcedure.Name = "lblIsProcedure";
            this.lblIsProcedure.Size = new System.Drawing.Size(72, 15);
            this.lblIsProcedure.TabIndex = 3;
            this.lblIsProcedure.Text = "Is Procedure";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(438, 226);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(660, 94);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(108, 27);
            this.btnClearInput.TabIndex = 5;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(660, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(660, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 27);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(660, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 27);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(660, 258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 27);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNameSaleService
            // 
            this.txtNameSaleService.Location = new System.Drawing.Point(393, 97);
            this.txtNameSaleService.Name = "txtNameSaleService";
            this.txtNameSaleService.Size = new System.Drawing.Size(202, 23);
            this.txtNameSaleService.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(393, 136);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(202, 23);
            this.txtPrice.TabIndex = 11;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(393, 179);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(202, 23);
            this.txtMinutes.TabIndex = 12;
            // 
            // lbShowResult
            // 
            this.lbShowResult.FormattingEnabled = true;
            this.lbShowResult.ItemHeight = 15;
            this.lbShowResult.Location = new System.Drawing.Point(12, 81);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(256, 334);
            this.lbShowResult.TabIndex = 13;
            this.lbShowResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbShowResult_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(274, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Medical sales & Services";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(305, 309);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNameSaleService);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblIsProcedure);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNameServiceSale);
            this.Name = "Form1";
            this.Text = "Medical";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameServiceSale;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblIsProcedure;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNameSaleService;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.ListBox lbShowResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
    }
}

