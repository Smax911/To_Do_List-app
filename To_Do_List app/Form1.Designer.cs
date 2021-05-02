
namespace To_Do_List_app
{
    partial class F
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblWriteYourItem = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(3, 51);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(264, 31);
            this.txtItem.TabIndex = 0;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 25;
            this.lstItems.Location = new System.Drawing.Point(483, 36);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(305, 504);
            this.lstItems.TabIndex = 1;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(189, 178);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(263, 34);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblWriteYourItem
            // 
            this.lblWriteYourItem.AutoSize = true;
            this.lblWriteYourItem.Location = new System.Drawing.Point(3, 9);
            this.lblWriteYourItem.Name = "lblWriteYourItem";
            this.lblWriteYourItem.Size = new System.Drawing.Size(136, 25);
            this.lblWriteYourItem.TabIndex = 3;
            this.lblWriteYourItem.Text = "Write your Item";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(189, 466);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(263, 34);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(189, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(263, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load to Textfile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::To_Do_List_app.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblWriteYourItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.txtItem);
            this.Name = "F";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblWriteYourItem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
    }
}

