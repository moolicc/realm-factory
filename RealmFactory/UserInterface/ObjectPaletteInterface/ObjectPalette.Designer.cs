﻿namespace Starbound.RealmFactory.UserInterface
{
    partial class ObjectPalette
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ObjectPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ObjectPalette";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectPalette_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ObjectPalette_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectPalette_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
