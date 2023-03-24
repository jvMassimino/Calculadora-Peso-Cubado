namespace CalcPeso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCalcular = new MetroFramework.Controls.MetroButton();
            txbox1 = new TextBox();
            txbox2 = new TextBox();
            txbox3 = new TextBox();
            txtResultado = new MetroFramework.Controls.MetroLabel();
            labelA = new MetroFramework.Controls.MetroLabel();
            labelB = new MetroFramework.Controls.MetroLabel();
            labelC = new MetroFramework.Controls.MetroLabel();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            btnSair = new MetroFramework.Controls.MetroButton();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            resources.ApplyResources(btnCalcular, "btnCalcular");
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Name = "btnCalcular";
            btnCalcular.UseSelectable = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txbox1
            // 
            resources.ApplyResources(txbox1, "txbox1");
            txbox1.Name = "txbox1";
            // 
            // txbox2
            // 
            resources.ApplyResources(txbox2, "txbox2");
            txbox2.Name = "txbox2";
            // 
            // txbox3
            // 
            resources.ApplyResources(txbox3, "txbox3");
            txbox3.Name = "txbox3";
            // 
            // txtResultado
            // 
            resources.ApplyResources(txtResultado, "txtResultado");
            txtResultado.Name = "txtResultado";
            // 
            // labelA
            // 
            resources.ApplyResources(labelA, "labelA");
            labelA.Name = "labelA";
            // 
            // labelB
            // 
            resources.ApplyResources(labelB, "labelB");
            labelB.Name = "labelB";
            // 
            // labelC
            // 
            resources.ApplyResources(labelC, "labelC");
            labelC.Name = "labelC";
            // 
            // metroLabel1
            // 
            resources.ApplyResources(metroLabel1, "metroLabel1");
            metroLabel1.Name = "metroLabel1";
            // 
            // btnSair
            // 
            resources.ApplyResources(btnSair, "btnSair");
            btnSair.Cursor = Cursors.Hand;
            btnSair.Highlight = true;
            btnSair.Name = "btnSair";
            btnSair.Style = MetroFramework.MetroColorStyle.Black;
            btnSair.TabStop = false;
            btnSair.UseSelectable = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalcular;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSair;
            ControlBox = false;
            Controls.Add(txbox3);
            Controls.Add(btnSair);
            Controls.Add(metroLabel1);
            Controls.Add(txtResultado);
            Controls.Add(txbox2);
            Controls.Add(txbox1);
            Controls.Add(btnCalcular);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(labelC);
            Name = "Form1";
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Red;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCalcular;
        private TextBox txbox1;
        private TextBox txbox2;
        private TextBox txbox3;
        private MetroFramework.Controls.MetroLabel txtResultado;
        private MetroFramework.Controls.MetroLabel labelA;
        private MetroFramework.Controls.MetroLabel labelB;
        private MetroFramework.Controls.MetroLabel labelC;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSair;
    }
}