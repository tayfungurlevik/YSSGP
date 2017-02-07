using Braincase.GanttChart;
using Braincase;
namespace YSSGP
{
    partial class ExampleFull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExampleFull));
            this._mChart = new Braincase.GanttChart.Chart();
            this.SuspendLayout();
            // 
            // _mChart
            // 
            this._mChart.AllowTaskDragDrop = false;
            this._mChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mChart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._mChart.FullDateStringFormat = null;
            this._mChart.Location = new System.Drawing.Point(0, 0);
            this._mChart.Margin = new System.Windows.Forms.Padding(0);
            this._mChart.Name = "_mChart";
            this._mChart.Padding = new System.Windows.Forms.Padding(5);
            this._mChart.Size = new System.Drawing.Size(829, 710);
            this._mChart.TabIndex = 5;
            // 
            // ExampleFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(829, 710);
            this.Controls.Add(this._mChart);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExampleFull";
            this.Text = "İş Akış Planı";
            this.Load += new System.EventHandler(this.ExampleFull_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Chart _mChart;
    }
}