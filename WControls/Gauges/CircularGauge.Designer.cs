﻿namespace WControls.Gauges
{
    partial class CircularGauge
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_animationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // m_animationTimer
            // 
            this.m_animationTimer.Tick += new System.EventHandler(this.m_animationTimer_Tick);
            // 
            // Circulargauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CircularGauge";
            this.Shape = WControls.ControlShape.Circular;
            this.Size = new System.Drawing.Size(250, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer m_animationTimer;
    }
}
