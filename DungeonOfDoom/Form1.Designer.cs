﻿namespace DungeonOfDoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.goNorth = new System.Windows.Forms.Button();
            this.goWest = new System.Windows.Forms.Button();
            this.goSouth = new System.Windows.Forms.Button();
            this.goEast = new System.Windows.Forms.Button();
            this.pictureFrame = new System.Windows.Forms.TableLayoutPanel();
            this.textField = new System.Windows.Forms.Label();
            this.actionLook = new System.Windows.Forms.Button();
            this.actionUse = new System.Windows.Forms.Button();
            this.actionItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.goNorth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.goWest, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.goSouth, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.goEast, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(547, 323);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // goNorth
            // 
            this.goNorth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goNorth.AutoSize = true;
            this.goNorth.Location = new System.Drawing.Point(88, 13);
            this.goNorth.Name = "goNorth";
            this.goNorth.Size = new System.Drawing.Size(75, 26);
            this.goNorth.TabIndex = 0;
            this.goNorth.Text = "North";
            this.goNorth.UseVisualStyleBackColor = true;
            // 
            // goWest
            // 
            this.goWest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.goWest.AutoSize = true;
            this.goWest.Location = new System.Drawing.Point(6, 49);
            this.goWest.Name = "goWest";
            this.goWest.Size = new System.Drawing.Size(75, 26);
            this.goWest.TabIndex = 1;
            this.goWest.Text = "West";
            this.goWest.UseVisualStyleBackColor = true;
            // 
            // goSouth
            // 
            this.goSouth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.goSouth.AutoSize = true;
            this.goSouth.Location = new System.Drawing.Point(88, 86);
            this.goSouth.Name = "goSouth";
            this.goSouth.Size = new System.Drawing.Size(75, 26);
            this.goSouth.TabIndex = 2;
            this.goSouth.Text = "South";
            this.goSouth.UseVisualStyleBackColor = true;
            // 
            // goEast
            // 
            this.goEast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.goEast.AutoSize = true;
            this.goEast.Location = new System.Drawing.Point(171, 49);
            this.goEast.Name = "goEast";
            this.goEast.Size = new System.Drawing.Size(75, 26);
            this.goEast.TabIndex = 3;
            this.goEast.Text = "East";
            this.goEast.UseVisualStyleBackColor = true;
            // 
            // pictureFrame
            // 
            this.pictureFrame.ColumnCount = 1;
            this.pictureFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pictureFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pictureFrame.Location = new System.Drawing.Point(12, 12);
            this.pictureFrame.Name = "pictureFrame";
            this.pictureFrame.RowCount = 1;
            this.pictureFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pictureFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pictureFrame.Size = new System.Drawing.Size(776, 295);
            this.pictureFrame.TabIndex = 1;
            this.pictureFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // textField
            // 
            this.textField.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textField.Location = new System.Drawing.Point(12, 323);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(529, 124);
            this.textField.TabIndex = 2;
            this.textField.Text = resources.GetString("textField.Text");
            this.textField.Click += new System.EventHandler(this.textField_Click);
            // 
            // actionLook
            // 
            this.actionLook.Font = new System.Drawing.Font("Noto Sans Armenian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLook.Location = new System.Drawing.Point(13, 450);
            this.actionLook.Name = "actionLook";
            this.actionLook.Size = new System.Drawing.Size(85, 49);
            this.actionLook.TabIndex = 3;
            this.actionLook.Text = "Look";
            this.actionLook.UseVisualStyleBackColor = true;
            this.actionLook.Click += new System.EventHandler(this.button1_Click);
            // 
            // actionUse
            // 
            this.actionUse.Font = new System.Drawing.Font("Noto Sans Armenian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionUse.Location = new System.Drawing.Point(104, 450);
            this.actionUse.Name = "actionUse";
            this.actionUse.Size = new System.Drawing.Size(89, 49);
            this.actionUse.TabIndex = 4;
            this.actionUse.Text = "Loot";
            this.actionUse.UseVisualStyleBackColor = true;
            this.actionUse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // actionItem
            // 
            this.actionItem.Font = new System.Drawing.Font("Noto Sans Armenian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionItem.Location = new System.Drawing.Point(327, 450);
            this.actionItem.Name = "actionItem";
            this.actionItem.Size = new System.Drawing.Size(138, 49);
            this.actionItem.TabIndex = 5;
            this.actionItem.Text = "Use item";
            this.actionItem.UseVisualStyleBackColor = true;
            this.actionItem.Click += new System.EventHandler(this.actionItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Noto Naskh Arabic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Items: -";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Noto Sans Armenian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Examine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actionItem);
            this.Controls.Add(this.actionUse);
            this.Controls.Add(this.actionLook);
            this.Controls.Add(this.textField);
            this.Controls.Add(this.pictureFrame);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Dungeon of Doom";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button goNorth;
        private System.Windows.Forms.Button goWest;
        private System.Windows.Forms.Button goSouth;
        private System.Windows.Forms.Button goEast;
        private System.Windows.Forms.TableLayoutPanel pictureFrame;
        private System.Windows.Forms.Label textField;
        private System.Windows.Forms.Button actionLook;
        private System.Windows.Forms.Button actionUse;
        private System.Windows.Forms.Button actionItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

