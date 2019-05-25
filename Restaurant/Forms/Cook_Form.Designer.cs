﻿namespace Restaurant {
    partial class Cook_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cook_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Order_Textbox = new System.Windows.Forms.RichTextBox();
            this.Order_List = new System.Windows.Forms.ListView();
            this.Cook_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Ready_Button = new System.Windows.Forms.Button();
            this.Undo_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.Order_Readier = new System.ComponentModel.BackgroundWorker();
            this.Username_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.Order_Textbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Order_List, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 315);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Order_Textbox
            // 
            this.Order_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Order_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Textbox.Location = new System.Drawing.Point(251, 5);
            this.Order_Textbox.Margin = new System.Windows.Forms.Padding(5);
            this.Order_Textbox.Name = "Order_Textbox";
            this.Order_Textbox.Size = new System.Drawing.Size(564, 305);
            this.Order_Textbox.TabIndex = 0;
            this.Order_Textbox.Text = "";
            // 
            // Order_List
            // 
            this.Order_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Order_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_List.Location = new System.Drawing.Point(5, 5);
            this.Order_List.Margin = new System.Windows.Forms.Padding(5);
            this.Order_List.Name = "Order_List";
            this.Order_List.Size = new System.Drawing.Size(236, 305);
            this.Order_List.TabIndex = 1;
            this.Order_List.UseCompatibleStateImageBehavior = false;
            // 
            // Cook_Label
            // 
            this.Cook_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cook_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cook_Label.Location = new System.Drawing.Point(17, 24);
            this.Cook_Label.Name = "Cook_Label";
            this.Cook_Label.Size = new System.Drawing.Size(810, 37);
            this.Cook_Label.TabIndex = 1;
            this.Cook_Label.Text = "Cook";
            this.Cook_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel2.Controls.Add(this.Ready_Button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Undo_Button, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(582, 392);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 70);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Ready_Button
            // 
            this.Ready_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ready_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ready_Button.Location = new System.Drawing.Point(87, 5);
            this.Ready_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Ready_Button.Name = "Ready_Button";
            this.Ready_Button.Padding = new System.Windows.Forms.Padding(10);
            this.Ready_Button.Size = new System.Drawing.Size(158, 60);
            this.Ready_Button.TabIndex = 0;
            this.Ready_Button.TabStop = false;
            this.Ready_Button.Text = "Ready";
            this.Ready_Button.UseVisualStyleBackColor = true;
            // 
            // Undo_Button
            // 
            this.Undo_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Undo_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Undo_Button.Location = new System.Drawing.Point(5, 5);
            this.Undo_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Undo_Button.Name = "Undo_Button";
            this.Undo_Button.Padding = new System.Windows.Forms.Padding(10);
            this.Undo_Button.Size = new System.Drawing.Size(72, 60);
            this.Undo_Button.TabIndex = 1;
            this.Undo_Button.TabStop = false;
            this.Undo_Button.Text = "↶";
            this.Undo_Button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.Logout_Button, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 392);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(120, 70);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // Logout_Button
            // 
            this.Logout_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.Location = new System.Drawing.Point(5, 5);
            this.Logout_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Padding = new System.Windows.Forms.Padding(10);
            this.Logout_Button.Size = new System.Drawing.Size(110, 60);
            this.Logout_Button.TabIndex = 0;
            this.Logout_Button.TabStop = false;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = true;
            // 
            // Order_Readier
            // 
            this.Order_Readier.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Order_Readier_DoWork);
            // 
            // Username_Label
            // 
            this.Username_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.Location = new System.Drawing.Point(17, 4);
            this.Username_Label.Margin = new System.Windows.Forms.Padding(3, 100, 3, 0);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(810, 20);
            this.Username_Label.TabIndex = 11;
            this.Username_Label.Text = "Username";
            this.Username_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Cook_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 481);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Cook_Label);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 520);
            this.Name = "Cook_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView Order_List;
        private System.Windows.Forms.Label Cook_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Ready_Button;
        private System.Windows.Forms.Button Undo_Button;
        private System.Windows.Forms.RichTextBox Order_Textbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Logout_Button;
        private System.ComponentModel.BackgroundWorker Order_Readier;
        private System.Windows.Forms.Label Username_Label;
    }
}