namespace UIForm
{
    partial class XtraDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraDepartment));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Dock = DockStyle.Right;
            layoutControl1.Location = new Point(312, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(393, 532);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Name = "Root";
            Root.Size = new Size(393, 532);
            Root.TextVisible = false;
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(textEdit1);
            layoutControl2.Dock = DockStyle.Top;
            layoutControl2.Location = new Point(0, 0);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new Size(312, 51);
            layoutControl2.TabIndex = 1;
            layoutControl2.Text = "layoutControl2";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(128, 12);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(172, 22);
            textEdit1.StyleController = layoutControl2;
            textEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(312, 51);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEdit1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.MaxSize = new Size(0, 26);
            layoutControlItem1.MinSize = new Size(182, 26);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(292, 31);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.Text = "Department Name";
            layoutControlItem1.TextSize = new Size(104, 16);
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.Location = new Point(12, 57);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 33);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            // 
            // btnClose
            // 
            btnClose.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Appearance.Options.UseFont = true;
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new Point(161, 57);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(123, 33);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // XtraDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 532);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(layoutControl2);
            Controls.Add(layoutControl1);
            Name = "XtraDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            Load += XtraDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}