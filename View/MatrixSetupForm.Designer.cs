﻿using System.Windows.Forms;

namespace View
{
    partial class MatrixSetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixSetupForm));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.hideButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.sizeYinput = new System.Windows.Forms.TextBox();
            this.divideButton = new System.Windows.Forms.Button();
            this.sizeXinput = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.combineButton = new System.Windows.Forms.Button();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.topPanel = new View.SelectRectPanel();
            this.controlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.hideButton);
            this.controlPanel.Controls.Add(this.showButton);
            this.controlPanel.Controls.Add(this.sizeYinput);
            this.controlPanel.Controls.Add(this.divideButton);
            this.controlPanel.Controls.Add(this.sizeXinput);
            this.controlPanel.Controls.Add(this.xLabel);
            this.controlPanel.Controls.Add(this.combineButton);
            resources.ApplyResources(this.controlPanel, "controlPanel");
            this.controlPanel.Name = "controlPanel";
            // 
            // hideButton
            // 
            resources.ApplyResources(this.hideButton, "hideButton");
            this.hideButton.Name = "hideButton";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // showButton
            // 
            resources.ApplyResources(this.showButton, "showButton");
            this.showButton.Name = "showButton";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // sizeYinput
            // 
            resources.ApplyResources(this.sizeYinput, "sizeYinput");
            this.sizeYinput.Name = "sizeYinput";
            this.sizeYinput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IntInput_KeyDown);
            this.sizeYinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInput_KeyPress);
            this.sizeYinput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IntInput_KeyUp);
            // 
            // divideButton
            // 
            resources.ApplyResources(this.divideButton, "divideButton");
            this.divideButton.Name = "divideButton";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // sizeXinput
            // 
            resources.ApplyResources(this.sizeXinput, "sizeXinput");
            this.sizeXinput.Name = "sizeXinput";
            this.sizeXinput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IntInput_KeyDown);
            this.sizeXinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInput_KeyPress);
            this.sizeXinput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IntInput_KeyUp);
            // 
            // xLabel
            // 
            resources.ApplyResources(this.xLabel, "xLabel");
            this.xLabel.Name = "xLabel";
            // 
            // combineButton
            // 
            resources.ApplyResources(this.combineButton, "combineButton");
            this.combineButton.Name = "combineButton";
            this.combineButton.UseVisualStyleBackColor = true;
            this.combineButton.Click += new System.EventHandler(this.CombineButton_Click);
            // 
            // gridPanel
            // 
            resources.ApplyResources(this.gridPanel, "gridPanel");
            this.gridPanel.Name = "gridPanel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.saveButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // topPanel
            // 
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Name = "topPanel";
            // 
            // MatrixSetupForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MatrixSetupForm";
            this.Shown += new System.EventHandler(this.MatrixSetupForm_Shown);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel controlPanel;
        private TextBox sizeYinput;
        private Button divideButton;
        private TextBox sizeXinput;
        private Label xLabel;
        private Button combineButton;
        private Button hideButton;
        private Button showButton;
        private Panel gridPanel;
        private Panel panel1;
        private Button cancelButton;
        private Button saveButton;
        private SelectRectPanel topPanel;
    }
}