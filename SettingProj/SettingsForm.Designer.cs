namespace SettingProj
{
    partial class SettingsForm
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
            this.settingsTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.UsersTab = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.aaddTesteeButton = new DevExpress.XtraEditors.SimpleButton();
            this.usersGridControl = new DevExpress.XtraGrid.GridControl();
            this.userView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.loginColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firstNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.emailColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trainingsColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrainingTab = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.trainingsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.trainingNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdditionalTab = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsTabControl)).BeginInit();
            this.settingsTabControl.SuspendLayout();
            this.UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).BeginInit();
            this.TrainingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.AdditionalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabControl.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.settingsTabControl.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.settingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedTabPage = this.UsersTab;
            this.settingsTabControl.Size = new System.Drawing.Size(656, 254);
            this.settingsTabControl.TabIndex = 0;
            this.settingsTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.UsersTab,
            this.TrainingTab,
            this.AdditionalTab});
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.simpleButton1);
            this.UsersTab.Controls.Add(this.simpleButton2);
            this.UsersTab.Controls.Add(this.aaddTesteeButton);
            this.UsersTab.Controls.Add(this.usersGridControl);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Size = new System.Drawing.Size(589, 248);
            this.UsersTab.Text = "Users";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(511, 203);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Load Testees";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton2.Location = new System.Drawing.Point(303, 213);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Edit Testee";
            // 
            // aaddTesteeButton
            // 
            this.aaddTesteeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.aaddTesteeButton.Location = new System.Drawing.Point(213, 213);
            this.aaddTesteeButton.Name = "aaddTesteeButton";
            this.aaddTesteeButton.Size = new System.Drawing.Size(75, 23);
            this.aaddTesteeButton.TabIndex = 1;
            this.aaddTesteeButton.Text = "Add Testee";
            this.aaddTesteeButton.Click += new System.EventHandler(this.aaddTesteeButton_Click);
            // 
            // usersGridControl
            // 
            this.usersGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersGridControl.Location = new System.Drawing.Point(0, 0);
            this.usersGridControl.MainView = this.userView;
            this.usersGridControl.Name = "usersGridControl";
            this.usersGridControl.Size = new System.Drawing.Size(589, 197);
            this.usersGridControl.TabIndex = 0;
            this.usersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userView});
            this.usersGridControl.DoubleClick += new System.EventHandler(this.usersGridControl_DoubleClick);
            // 
            // userView
            // 
            this.userView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.loginColumn,
            this.firstNameColumn,
            this.lastNameColumn,
            this.emailColumn,
            this.trainingsColumn});
            this.userView.GridControl = this.usersGridControl;
            this.userView.Name = "userView";
            // 
            // loginColumn
            // 
            this.loginColumn.Caption = "login";
            this.loginColumn.Name = "loginColumn";
            this.loginColumn.Visible = true;
            this.loginColumn.VisibleIndex = 0;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.Caption = "first name";
            this.firstNameColumn.Name = "firstNameColumn";
            this.firstNameColumn.Visible = true;
            this.firstNameColumn.VisibleIndex = 1;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.Caption = "last name";
            this.lastNameColumn.Name = "lastNameColumn";
            this.lastNameColumn.Visible = true;
            this.lastNameColumn.VisibleIndex = 2;
            // 
            // emailColumn
            // 
            this.emailColumn.Caption = "email";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.Visible = true;
            this.emailColumn.VisibleIndex = 3;
            // 
            // trainingsColumn
            // 
            this.trainingsColumn.Caption = "trainings";
            this.trainingsColumn.Name = "trainingsColumn";
            this.trainingsColumn.Visible = true;
            this.trainingsColumn.VisibleIndex = 4;
            // 
            // TrainingTab
            // 
            this.TrainingTab.Controls.Add(this.simpleButton5);
            this.TrainingTab.Controls.Add(this.simpleButton6);
            this.TrainingTab.Controls.Add(this.trainingsGridControl);
            this.TrainingTab.Name = "TrainingTab";
            this.TrainingTab.Size = new System.Drawing.Size(589, 248);
            this.TrainingTab.Text = "Training";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton5.Location = new System.Drawing.Point(303, 213);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 5;
            this.simpleButton5.Text = "Edit Training";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton6.Location = new System.Drawing.Point(213, 213);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 23);
            this.simpleButton6.TabIndex = 4;
            this.simpleButton6.Text = "Add Training";
            // 
            // trainingsGridControl
            // 
            this.trainingsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainingsGridControl.Location = new System.Drawing.Point(0, 0);
            this.trainingsGridControl.MainView = this.gridView1;
            this.trainingsGridControl.Name = "trainingsGridControl";
            this.trainingsGridControl.Size = new System.Drawing.Size(589, 197);
            this.trainingsGridControl.TabIndex = 1;
            this.trainingsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.trainingNameColumn});
            this.gridView1.GridControl = this.trainingsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // trainingNameColumn
            // 
            this.trainingNameColumn.Caption = "trainings";
            this.trainingNameColumn.Name = "trainingNameColumn";
            this.trainingNameColumn.Visible = true;
            this.trainingNameColumn.VisibleIndex = 0;
            // 
            // AdditionalTab
            // 
            this.AdditionalTab.Controls.Add(this.labelControl4);
            this.AdditionalTab.Controls.Add(this.labelControl3);
            this.AdditionalTab.Controls.Add(this.labelControl2);
            this.AdditionalTab.Controls.Add(this.labelControl1);
            this.AdditionalTab.Controls.Add(this.textEdit4);
            this.AdditionalTab.Controls.Add(this.textEdit3);
            this.AdditionalTab.Controls.Add(this.textEdit2);
            this.AdditionalTab.Controls.Add(this.textEdit1);
            this.AdditionalTab.Name = "AdditionalTab";
            this.AdditionalTab.Size = new System.Drawing.Size(589, 248);
            this.AdditionalTab.Text = "Additional";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton3.Location = new System.Drawing.Point(275, 260);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Save All";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton4.Location = new System.Drawing.Point(365, 260);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Cancel All";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(130, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(130, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "login";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(375, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Question amount";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(375, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Question frequency";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(267, 58);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(100, 20);
            this.textEdit4.TabIndex = 14;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(24, 58);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 13;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(267, 24);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 12;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(24, 24);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 11;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 293);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.settingsTabControl);
            this.MinimumSize = new System.Drawing.Size(660, 300);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settingsTabControl)).EndInit();
            this.settingsTabControl.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).EndInit();
            this.TrainingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainingsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.AdditionalTab.ResumeLayout(false);
            this.AdditionalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl settingsTabControl;
        private DevExpress.XtraTab.XtraTabPage UsersTab;
        private DevExpress.XtraTab.XtraTabPage TrainingTab;
        private DevExpress.XtraTab.XtraTabPage AdditionalTab;
        private DevExpress.XtraGrid.GridControl usersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView userView;
        private DevExpress.XtraGrid.Columns.GridColumn loginColumn;
        private DevExpress.XtraGrid.Columns.GridColumn firstNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn lastNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn emailColumn;
        private DevExpress.XtraGrid.Columns.GridColumn trainingsColumn;
        private DevExpress.XtraGrid.GridControl trainingsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn trainingNameColumn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton aaddTesteeButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;

    }
}

