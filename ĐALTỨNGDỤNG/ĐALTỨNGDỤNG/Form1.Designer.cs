using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ĐALTỨNGDỤNG
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.tinhAs = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.tinhHamLuong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Thép = new System.Windows.Forms.ComboBox();
            this.BeTong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.U = new System.Windows.Forms.TextBox();
            this.As = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.phiTDai = new System.Windows.Forms.TextBox();
            this.phiTDoc = new System.Windows.Forms.TextBox();
            this.thepDai = new System.Windows.Forms.TextBox();
            this.thepDoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.m = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.q = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gr)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.tinhAs,
            this.barCheckItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.tinhHamLuong,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage5});
            this.ribbonControl1.Size = new System.Drawing.Size(1358, 199);
            // 
            // tinhAs
            // 
            this.tinhAs.Caption = "As";
            this.tinhAs.Id = 1;
            this.tinhAs.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.highlightcellsrules_16x16;
            this.tinhAs.ImageOptions.LargeImage = global::ĐALTỨNGDỤNG.Properties.Resources.highlightcellsrules_32x32;
            this.tinhAs.Name = "tinhAs";
            this.tinhAs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 2;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Load DB";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.export_16x16;
            this.barButtonItem2.ImageOptions.LargeImage = global::ĐALTỨNGDỤNG.Properties.Resources.export_32x32;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Load dữ liệu";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.save_16x16;
            this.barButtonItem3.ImageOptions.LargeImage = global::ĐALTỨNGDỤNG.Properties.Resources.save_32x32;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Load dữ liệu\r\n";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.changechartseriestype_16x16;
            this.barButtonItem5.ImageOptions.LargeImage = global::ĐALTỨNGDỤNG.Properties.Resources.changechartseriestype_32x32;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Xuất excel";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.sendxls_16x16;
            this.barButtonItem6.ImageOptions.LargeImage = global::ĐALTỨNGDỤNG.Properties.Resources.sendxls_32x32;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // tinhHamLuong
            // 
            this.tinhHamLuong.Caption = "U%";
            this.tinhHamLuong.Id = 8;
            this.tinhHamLuong.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.formatnumberpercent_16x16;
            this.tinhHamLuong.ImageOptions.LargeImage = global::ĐALTỨNGDỤNG.Properties.Resources.formatnumberpercent_32x32;
            this.tinhHamLuong.Name = "tinhHamLuong";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Phép Tính";
            this.barButtonItem8.Id = 9;
            this.barButtonItem8.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.boemployee_16x16;
            this.barButtonItem8.ImageOptions.LargeImage = global::ĐALTỨNGDỤNG.Properties.Resources.boemployee_32x32;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Thép Đai";
            this.barButtonItem9.Id = 10;
            this.barButtonItem9.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.iconsettrafficlights4_16x16;
            this.barButtonItem9.ImageOptions.LargeImage = global::ĐALTỨNGDỤNG.Properties.Resources.iconsettrafficlights4_32x32;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Thép Dọc";
            this.barButtonItem10.Id = 11;
            this.barButtonItem10.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.iconsetredtoblack4_16x16;
            this.barButtonItem10.ImageOptions.LargeImage = global::ĐALTỨNGDỤNG.Properties.Resources.iconsetredtoblack4_32x32;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Thép";
            this.barButtonItem11.Id = 12;
            this.barButtonItem11.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.iconsetquarters5_16x16;
            this.barButtonItem11.ImageOptions.LargeImage = global::ĐALTỨNGDỤNG.Properties.Resources.iconsetquarters5_32x32;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Dữ Liệu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Tính Toán";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.tinhAs);
            this.ribbonPageGroup3.ItemLinks.Add(this.tinhHamLuong);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage5.ImageOptions.Image = global::ĐALTỨNGDỤNG.Properties.Resources.addchartpane_32x32;
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Chuyển Tab";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.h);
            this.groupBox1.Controls.Add(this.b);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Số Liệu Cột";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // l
            // 
            this.l.Location = new System.Drawing.Point(162, 46);
            this.l.Multiline = true;
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(167, 30);
            this.l.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "Chiều rộng tiết diện  ";
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(162, 151);
            this.h.Multiline = true;
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(167, 30);
            this.h.TabIndex = 1;
            this.h.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(162, 104);
            this.b.Multiline = true;
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(167, 30);
            this.b.TabIndex = 1;
            this.b.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chiều cao tiết diện ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiều cao cột ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(34, 210);
            this.textEdit1.MenuManager = this.ribbonControl1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(356, 22);
            this.textEdit1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Thép);
            this.groupBox2.Controls.Add(this.BeTong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(419, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 236);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vật Liệu";
            // 
            // Thép
            // 
            this.Thép.FormattingEnabled = true;
            this.Thép.Items.AddRange(new object[] {
            "CB 240-T",
            "CB 300-T",
            "CB 400-V",
            "CB 300-T",
            "CB 500-V"});
            this.Thép.Location = new System.Drawing.Point(137, 120);
            this.Thép.Name = "Thép";
            this.Thép.Size = new System.Drawing.Size(130, 24);
            this.Thép.TabIndex = 2;
            // 
            // BeTong
            // 
            this.BeTong.FormattingEnabled = true;
            this.BeTong.Items.AddRange(new object[] {
            "B15",
            "B20",
            "B25",
            "B30"});
            this.BeTong.Location = new System.Drawing.Point(137, 54);
            this.BeTong.Name = "BeTong";
            this.BeTong.Size = new System.Drawing.Size(130, 24);
            this.BeTong.TabIndex = 2;
            this.BeTong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thép";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bê Tông";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.U);
            this.groupBox3.Controls.Add(this.As);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(419, 498);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 192);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // U
            // 
            this.U.Location = new System.Drawing.Point(79, 88);
            this.U.Multiline = true;
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(188, 23);
            this.U.TabIndex = 1;
            // 
            // As
            // 
            this.As.Location = new System.Drawing.Point(79, 38);
            this.As.Multiline = true;
            this.As.Name = "As";
            this.As.Size = new System.Drawing.Size(188, 23);
            this.As.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "U%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "As";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.phiTDai);
            this.groupBox4.Controls.Add(this.phiTDoc);
            this.groupBox4.Controls.Add(this.thepDai);
            this.groupBox4.Controls.Add(this.thepDoc);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(758, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(565, 229);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Số lượng thép";
            // 
            // phiTDai
            // 
            this.phiTDai.Location = new System.Drawing.Point(443, 116);
            this.phiTDai.Name = "phiTDai";
            this.phiTDai.Size = new System.Drawing.Size(96, 22);
            this.phiTDai.TabIndex = 2;
            // 
            // phiTDoc
            // 
            this.phiTDoc.Location = new System.Drawing.Point(443, 51);
            this.phiTDoc.Name = "phiTDoc";
            this.phiTDoc.Size = new System.Drawing.Size(96, 22);
            this.phiTDoc.TabIndex = 2;
            // 
            // thepDai
            // 
            this.thepDai.Location = new System.Drawing.Point(177, 114);
            this.thepDai.Name = "thepDai";
            this.thepDai.Size = new System.Drawing.Size(216, 22);
            this.thepDai.TabIndex = 1;
            // 
            // thepDoc
            // 
            this.thepDoc.Location = new System.Drawing.Point(177, 49);
            this.thepDoc.Name = "thepDoc";
            this.thepDoc.Size = new System.Drawing.Size(216, 22);
            this.thepDoc.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Phi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng thép đai";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng thép dọc";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.m);
            this.groupBox5.Controls.Add(this.n);
            this.groupBox5.Controls.Add(this.q);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(759, 494);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 221);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Số liệu nội lực";
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(105, 114);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(212, 22);
            this.m.TabIndex = 1;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(105, 75);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(212, 22);
            this.n.TabIndex = 1;
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(105, 40);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(212, 22);
            this.q.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mômen";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Lực nén";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lực cắt";
            // 
            // gr
            // 
            this.gr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gr.Location = new System.Drawing.Point(45, 498);
            this.gr.Name = "gr";
            this.gr.RowHeadersWidth = 51;
            this.gr.RowTemplate.Height = 24;
            this.gr.Size = new System.Drawing.Size(332, 150);
            this.gr.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 720);
            this.Controls.Add(this.gr);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem tinhAs;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem tinhHamLuong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Thép;
        private System.Windows.Forms.ComboBox BeTong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox U;
        private System.Windows.Forms.TextBox As;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox phiTDai;
        private System.Windows.Forms.TextBox phiTDoc;
        private System.Windows.Forms.TextBox thepDai;
        private System.Windows.Forms.TextBox thepDoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox q;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox l;
        private DataGridView gr;
    }
}

