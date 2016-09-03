namespace appp
{
    partial class groupformv2
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.time = new DevExpress.XtraEditors.TimeEdit();
            this.days = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lvl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.num = new DevExpress.XtraEditors.TextEdit();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pstart = new DevExpress.XtraEditors.DateEdit();
            this.pend = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.days.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pend.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AutoScroll = false;
            this.layoutControl1.Controls.Add(this.time);
            this.layoutControl1.Controls.Add(this.days);
            this.layoutControl1.Controls.Add(this.lvl);
            this.layoutControl1.Controls.Add(this.num);
            this.layoutControl1.Controls.Add(this.okBtn);
            this.layoutControl1.Controls.Add(this.cancelBtn);
            this.layoutControl1.Controls.Add(this.pstart);
            this.layoutControl1.Controls.Add(this.pend);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Enabled = false;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(586, 313, 598, 350);
            this.layoutControl1.OptionsFocus.AllowFocusGroups = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(246, 479);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            this.layoutControl1.GroupExpandChanged += new DevExpress.XtraLayout.Utils.LayoutGroupEventHandler(this.layoutControl1_GroupExpandChanged);
            // 
            // time
            // 
            this.time.EditValue = new System.DateTime(2016, 4, 4, 0, 0, 0, 0);
            this.time.Location = new System.Drawing.Point(78, 122);
            this.time.Name = "time";
            this.time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.time.Properties.Mask.EditMask = "t";
            this.time.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.time.Size = new System.Drawing.Size(156, 20);
            this.time.StyleController = this.layoutControl1;
            this.time.TabIndex = 8;
            // 
            // days
            // 
            this.days.EditValue = "";
            this.days.Location = new System.Drawing.Point(78, 98);
            this.days.Name = "days";
            this.days.Properties.AllowFocused = false;
            this.days.Properties.AllowMultiSelect = true;
            this.days.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.days.Properties.DropDownRows = 6;
            this.days.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.days.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("1", "mon"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("2", "tue"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("3", "wed"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("4", "thu"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("5", "fri"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("6", "sat")});
            this.days.Properties.PopupSizeable = false;
            this.days.Properties.SelectAllItemVisible = false;
            this.days.Properties.ShowPopupCloseButton = false;
            this.days.Size = new System.Drawing.Size(156, 20);
            this.days.StyleController = this.layoutControl1;
            this.days.TabIndex = 7;
            // 
            // lvl
            // 
            this.lvl.Location = new System.Drawing.Point(78, 36);
            this.lvl.Name = "lvl";
            this.lvl.Properties.AllowFocused = false;
            this.lvl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lvl.Properties.DropDownRows = 6;
            this.lvl.Properties.Items.AddRange(new object[] {
            "beg",
            "elem",
            "pre-int",
            "int",
            "upper-int",
            "adv"});
            this.lvl.ShowToolTips = false;
            this.lvl.Size = new System.Drawing.Size(156, 20);
            this.lvl.StyleController = this.layoutControl1;
            this.lvl.TabIndex = 6;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(78, 12);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(156, 20);
            this.num.StyleController = this.layoutControl1;
            this.num.TabIndex = 5;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(88, 444);
            this.okBtn.Name = "okBtn";
            this.okBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.okBtn.Size = new System.Drawing.Size(66, 23);
            this.okBtn.StyleController = this.layoutControl1;
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "OK";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(168, 444);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cancelBtn.Size = new System.Drawing.Size(66, 23);
            this.cancelBtn.StyleController = this.layoutControl1;
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            // 
            // pstart
            // 
            this.pstart.EditValue = null;
            this.pstart.Location = new System.Drawing.Point(78, 167);
            this.pstart.Name = "pstart";
            this.pstart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pstart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pstart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.pstart.Properties.DisplayFormat.FormatString = "";
            this.pstart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pstart.Properties.EditFormat.FormatString = "";
            this.pstart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pstart.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.pstart.Size = new System.Drawing.Size(156, 20);
            this.pstart.StyleController = this.layoutControl1;
            this.pstart.TabIndex = 10;
            // 
            // pend
            // 
            this.pend.EditValue = null;
            this.pend.Location = new System.Drawing.Point(78, 191);
            this.pend.Name = "pend";
            this.pend.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pend.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pend.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.pend.Properties.DisplayFormat.FormatString = "";
            this.pend.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pend.Properties.EditFormat.FormatString = "";
            this.pend.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pend.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.pend.Size = new System.Drawing.Size(156, 20);
            this.pend.StyleController = this.layoutControl1;
            this.pend.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.simpleSeparator1,
            this.simpleSeparator2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem10,
            this.layoutControlItem9,
            this.simpleLabelItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 15;
            this.layoutControlGroup1.Size = new System.Drawing.Size(246, 479);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.okBtn;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem7.Location = new System.Drawing.Point(76, 432);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(70, 27);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(70, 27);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(70, 27);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "layoutControlItem1";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cancelBtn;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem8.Location = new System.Drawing.Point(156, 432);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(70, 27);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(70, 27);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(70, 27);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "layoutControlItem2";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(146, 432);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 432);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(76, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 203);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(225, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(226, 229);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 48);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(226, 21);
            this.simpleSeparator1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 134);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(226, 21);
            this.simpleSeparator2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.num;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(85, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(226, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "groupno.";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lvl;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(85, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(226, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "level";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.days;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(85, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(226, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "week days";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.time;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(85, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(226, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "day time";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.pend;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 179);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(85, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(226, 24);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "ending";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.pstart;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 155);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(85, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(226, 24);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "started";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(51, 13);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Enabled = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 69);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(226, 17);
            this.simpleLabelItem1.Text = "workout";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(51, 13);
            // 
            // groupformv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "groupformv2";
            this.Size = new System.Drawing.Size(246, 479);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.days.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pend.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TimeEdit time;
        private DevExpress.XtraEditors.CheckedComboBoxEdit days;
        private DevExpress.XtraEditors.ComboBoxEdit lvl;
        private DevExpress.XtraEditors.TextEdit num;
        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.DateEdit pstart;
        private DevExpress.XtraEditors.DateEdit pend;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        public DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
    }
}
