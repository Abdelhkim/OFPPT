namespace Gestion_Absence
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Title_Lable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Minimise_pictureBox = new System.Windows.Forms.PictureBox();
            this.Maximise_pictureBox = new System.Windows.Forms.PictureBox();
            this.Close_pictureBox = new System.Windows.Forms.PictureBox();
            this.Humbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Logo_Panel = new System.Windows.Forms.Panel();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Gap_panel = new System.Windows.Forms.Panel();
            this.Tree_Menu_panel = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Humbutton)).BeginInit();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.Tree_Menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Title_Lable
            // 
            this.Title_Lable.AutoSize = true;
            this.Title_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Lable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_Lable.Location = new System.Drawing.Point(51, 17);
            this.Title_Lable.Name = "Title_Lable";
            this.Title_Lable.Size = new System.Drawing.Size(145, 20);
            this.Title_Lable.TabIndex = 1;
            this.Title_Lable.Text = "Gestion D\'absence";
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.Header_Panel.Controls.Add(this.Minimise_pictureBox);
            this.Header_Panel.Controls.Add(this.Maximise_pictureBox);
            this.Header_Panel.Controls.Add(this.Close_pictureBox);
            this.Header_Panel.Controls.Add(this.Title_Lable);
            this.Header_Panel.Controls.Add(this.Humbutton);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(958, 54);
            this.Header_Panel.TabIndex = 4;
            this.Header_Panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Header_Panel_MouseDoubleClick);
            // 
            // Minimise_pictureBox
            // 
            this.Minimise_pictureBox.Image = global::Gestion_Absence.Properties.Resources.Reduire;
            this.Minimise_pictureBox.Location = new System.Drawing.Point(865, 27);
            this.Minimise_pictureBox.Name = "Minimise_pictureBox";
            this.Minimise_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.Minimise_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimise_pictureBox.TabIndex = 4;
            this.Minimise_pictureBox.TabStop = false;
            // 
            // Maximise_pictureBox
            // 
            this.Maximise_pictureBox.Image = global::Gestion_Absence.Properties.Resources.Agrendire;
            this.Maximise_pictureBox.Location = new System.Drawing.Point(897, 21);
            this.Maximise_pictureBox.Name = "Maximise_pictureBox";
            this.Maximise_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.Maximise_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximise_pictureBox.TabIndex = 3;
            this.Maximise_pictureBox.TabStop = false;
            this.Maximise_pictureBox.Click += new System.EventHandler(this.Maximise_pictureBox_Click);
            // 
            // Close_pictureBox
            // 
            this.Close_pictureBox.Image = global::Gestion_Absence.Properties.Resources.Close;
            this.Close_pictureBox.Location = new System.Drawing.Point(930, 21);
            this.Close_pictureBox.Name = "Close_pictureBox";
            this.Close_pictureBox.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Close_pictureBox.Size = new System.Drawing.Size(16, 16);
            this.Close_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_pictureBox.TabIndex = 2;
            this.Close_pictureBox.TabStop = false;
            this.Close_pictureBox.Click += new System.EventHandler(this.Close_pictureBox_Click);
            // 
            // Humbutton
            // 
            this.Humbutton.BackColor = System.Drawing.Color.Transparent;
            this.Humbutton.Image = global::Gestion_Absence.Properties.Resources.menu;
            this.Humbutton.ImageActive = null;
            this.Humbutton.Location = new System.Drawing.Point(17, 13);
            this.Humbutton.Name = "Humbutton";
            this.Humbutton.Size = new System.Drawing.Size(25, 25);
            this.Humbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Humbutton.TabIndex = 0;
            this.Humbutton.TabStop = false;
            this.Humbutton.Zoom = 10;
            this.Humbutton.Click += new System.EventHandler(this.Humbutton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header_Panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Logo_Panel
            // 
            this.Logo_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.Logo_Panel.Controls.Add(this.Logo_PictureBox);
            this.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_Panel.Location = new System.Drawing.Point(0, 0);
            this.Logo_Panel.Name = "Logo_Panel";
            this.Logo_Panel.Size = new System.Drawing.Size(256, 181);
            this.Logo_Panel.TabIndex = 0;
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.Image = global::Gestion_Absence.Properties.Resources.OFPPT;
            this.Logo_PictureBox.Location = new System.Drawing.Point(12, 34);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(232, 123);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            // 
            // Gap_panel
            // 
            this.Gap_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gap_panel.Location = new System.Drawing.Point(0, 181);
            this.Gap_panel.Name = "Gap_panel";
            this.Gap_panel.Size = new System.Drawing.Size(256, 84);
            this.Gap_panel.TabIndex = 4;
            // 
            // Tree_Menu_panel
            // 
            this.Tree_Menu_panel.BackColor = System.Drawing.Color.White;
            this.Tree_Menu_panel.Controls.Add(this.bunifuFlatButton3);
            this.Tree_Menu_panel.Controls.Add(this.bunifuFlatButton5);
            this.Tree_Menu_panel.Controls.Add(this.bunifuFlatButton4);
            this.Tree_Menu_panel.Controls.Add(this.bunifuFlatButton2);
            this.Tree_Menu_panel.Controls.Add(this.bunifuFlatButton1);
            this.Tree_Menu_panel.Controls.Add(this.Gap_panel);
            this.Tree_Menu_panel.Controls.Add(this.bunifuFlatButton8);
            this.Tree_Menu_panel.Controls.Add(this.Logo_Panel);
            this.Tree_Menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tree_Menu_panel.Location = new System.Drawing.Point(0, 54);
            this.Tree_Menu_panel.Name = "Tree_Menu_panel";
            this.Tree_Menu_panel.Size = new System.Drawing.Size(256, 577);
            this.Tree_Menu_panel.TabIndex = 5;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(155)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Les Modules";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::Gestion_Absence.Properties.Resources.Les_Modules;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 70D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(3, 477);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(254, 48);
            this.bunifuFlatButton3.TabIndex = 11;
            this.bunifuFlatButton3.Text = "Les Modules";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Les Stagiaires";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::Gestion_Absence.Properties.Resources.Student1;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 60D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 269);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(257, 48);
            this.bunifuFlatButton5.TabIndex = 13;
            this.bunifuFlatButton5.Text = "Les Stagiaires";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Archive";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::Gestion_Absence.Properties.Resources.archive;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 70D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(3, 529);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(254, 48);
            this.bunifuFlatButton4.TabIndex = 12;
            this.bunifuFlatButton4.Text = "Archive";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Les Groupes";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::Gestion_Absence.Properties.Resources.Les_Groups;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 425);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(257, 48);
            this.bunifuFlatButton2.TabIndex = 10;
            this.bunifuFlatButton2.Text = "Les Groupes";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Les Filiers";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Gestion_Absence.Properties.Resources.Filiers;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 373);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(257, 48);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "Les Filiers";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(86)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Absence";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = global::Gestion_Absence.Properties.Resources.Clock;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 70D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(0, 321);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(257, 48);
            this.bunifuFlatButton8.TabIndex = 8;
            this.bunifuFlatButton8.Text = "Absence";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 631);
            this.Controls.Add(this.Tree_Menu_panel);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximise_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Humbutton)).EndInit();
            this.Logo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.Tree_Menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Tree_Menu_panel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel Gap_panel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private System.Windows.Forms.Panel Logo_Panel;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.PictureBox Minimise_pictureBox;
        private System.Windows.Forms.PictureBox Maximise_pictureBox;
        private System.Windows.Forms.PictureBox Close_pictureBox;
        private Bunifu.Framework.UI.BunifuCustomLabel Title_Lable;
        private Bunifu.Framework.UI.BunifuImageButton Humbutton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timer1;
    }
}

