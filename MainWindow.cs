using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class MainWindow : Form
{
  private Boutique GSHOP;
  private unsafe int* movingIndex;
  private int max_item_id;
  private SortedList item_id_index_map;
  private SortedList itemDescriptions;
  private ComboBox comboBox_dbSource;
  private TextBox textBox_durationC;
  private TextBox textBox_durationB;
  private TextBox textBox_durationA;
  private ComboBox comboBox_status;
  private Label label14;
  private NumericUpDown numericUpDown_unknown3;
  private NumericUpDown numericUpDown_unknown2;
  private GroupBox groupBox1;
  private Button button_save;
  private Button button_load;
  private TextBox textBox_file;
  private NumericUpDown numericUpDown_unknown1;
  private Label label11;
  private Label label21;
  private Label label20;
  private Label label18;
  private Label label19;
  private MenuStrip menuStrip_mainMenu;
  private ToolStripMenuItem toolStripMenuItem4;
  private Label label2;
  private Label label1;
  private Label label17;
  private TextBox textBox_SubCat;
  private GroupBox groupBox3;
  private TextBox textBox_Cat;
  private ListBox listBox_Cats;
  private ListBox listBox_SubCats;
  private ContextMenuStrip contextMenuStrip_SubCat;
  private ToolStripMenuItem toolStripMenuItem1;
  private ToolStripMenuItem toolStripMenuItem2;
  private ToolStripSeparator toolStripSeparator1;
  private ToolStripMenuItem toolStripMenuItem_moveCat;
  private ListBox listBox_Items;
  private ContextMenuStrip contextMenuStrip_Item;
  private ToolStripMenuItem toolStripMenuItem3;
  private ToolStripMenuItem toolStripMenuItem12;
  private ToolStripSeparator toolStripSeparator2;
  private ToolStripMenuItem toolStripMenuItem_moveItem;
  private GroupBox groupBox2;
  private NumericUpDown numericUpDown_valueC;
  private NumericUpDown numericUpDown_priceC;
  private NumericUpDown numericUpDown_valueB;
  private NumericUpDown numericUpDown_priceB;
  private Label label10;
  private NumericUpDown numericUpDown_valueA;
  private Label label9;
  private NumericUpDown numericUpDown_priceA;
  private Label label8;
  private NumericUpDown numericUpDown_amount;
  private Label label7;
  private ComboBox comboBox_surface;
  private Button button_autoDetect;
  private NumericUpDown numericUpDown_itemID;
  private TextBox textBox_name;
  private Label label6;
  private Label label5;
  private Label label4;
  private Label label3;
  private TextBox textBox_description;
  private PictureBox pictureBox_surface;
  private LinkLabel linkLabel_home;
  private ToolStripMenuItem exitToolStripMenuItem;
  private TextBox textBox_search;
  private Button button_search;
  private IContainer components;

  public unsafe MainWindow()
  {
    // ISSUE: fault handler
    try
    {
      this.InitializeComponent();
      this.initialize();
      this.movingIndex = (int*) \u003CModule\u003E.@new(4U);
      this.Icon = (Icon) new ResourceManager("sTools.icons", Assembly.GetExecutingAssembly()).GetObject("app");
    }
    __fault
    {
      base.Dispose(true);
    }
  }

  private void \u007EMainWindow()
  {
    if (this.components == null)
      return;
    IDisposable components = (IDisposable) this.components;
    int num;
    if (components != null)
    {
      components.Dispose();
      num = 0;
    }
    else
      num = 0;
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new Container();
    this.comboBox_dbSource = new ComboBox();
    this.textBox_durationC = new TextBox();
    this.textBox_durationB = new TextBox();
    this.textBox_durationA = new TextBox();
    this.comboBox_status = new ComboBox();
    this.label14 = new Label();
    this.numericUpDown_unknown3 = new NumericUpDown();
    this.numericUpDown_unknown2 = new NumericUpDown();
    this.groupBox1 = new GroupBox();
    this.button_save = new Button();
    this.button_load = new Button();
    this.textBox_file = new TextBox();
    this.numericUpDown_unknown1 = new NumericUpDown();
    this.label11 = new Label();
    this.label21 = new Label();
    this.label20 = new Label();
    this.label18 = new Label();
    this.label19 = new Label();
    this.menuStrip_mainMenu = new MenuStrip();
    this.toolStripMenuItem4 = new ToolStripMenuItem();
    this.exitToolStripMenuItem = new ToolStripMenuItem();
    this.label2 = new Label();
    this.label1 = new Label();
    this.label17 = new Label();
    this.textBox_SubCat = new TextBox();
    this.groupBox3 = new GroupBox();
    this.textBox_Cat = new TextBox();
    this.listBox_Cats = new ListBox();
    this.listBox_SubCats = new ListBox();
    MainWindow mainWindow1 = this;
    mainWindow1.contextMenuStrip_SubCat = new ContextMenuStrip(mainWindow1.components);
    this.toolStripMenuItem1 = new ToolStripMenuItem();
    this.toolStripMenuItem2 = new ToolStripMenuItem();
    this.toolStripSeparator1 = new ToolStripSeparator();
    this.toolStripMenuItem_moveCat = new ToolStripMenuItem();
    this.listBox_Items = new ListBox();
    MainWindow mainWindow2 = this;
    mainWindow2.contextMenuStrip_Item = new ContextMenuStrip(mainWindow2.components);
    this.toolStripMenuItem3 = new ToolStripMenuItem();
    this.toolStripMenuItem12 = new ToolStripMenuItem();
    this.toolStripSeparator2 = new ToolStripSeparator();
    this.toolStripMenuItem_moveItem = new ToolStripMenuItem();
    this.groupBox2 = new GroupBox();
    this.numericUpDown_valueC = new NumericUpDown();
    this.numericUpDown_priceC = new NumericUpDown();
    this.numericUpDown_valueB = new NumericUpDown();
    this.numericUpDown_priceB = new NumericUpDown();
    this.label10 = new Label();
    this.numericUpDown_valueA = new NumericUpDown();
    this.label9 = new Label();
    this.numericUpDown_priceA = new NumericUpDown();
    this.label8 = new Label();
    this.numericUpDown_amount = new NumericUpDown();
    this.label7 = new Label();
    this.comboBox_surface = new ComboBox();
    this.button_autoDetect = new Button();
    this.numericUpDown_itemID = new NumericUpDown();
    this.textBox_name = new TextBox();
    this.label6 = new Label();
    this.label5 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.textBox_description = new TextBox();
    this.pictureBox_surface = new PictureBox();
    this.linkLabel_home = new LinkLabel();
    this.textBox_search = new TextBox();
    this.button_search = new Button();
    this.numericUpDown_unknown3.BeginInit();
    this.numericUpDown_unknown2.BeginInit();
    this.groupBox1.SuspendLayout();
    this.numericUpDown_unknown1.BeginInit();
    this.menuStrip_mainMenu.SuspendLayout();
    this.groupBox3.SuspendLayout();
    this.contextMenuStrip_SubCat.SuspendLayout();
    this.contextMenuStrip_Item.SuspendLayout();
    this.groupBox2.SuspendLayout();
    this.numericUpDown_valueC.BeginInit();
    this.numericUpDown_priceC.BeginInit();
    this.numericUpDown_valueB.BeginInit();
    this.numericUpDown_priceB.BeginInit();
    this.numericUpDown_valueA.BeginInit();
    this.numericUpDown_priceA.BeginInit();
    this.numericUpDown_amount.BeginInit();
    this.numericUpDown_itemID.BeginInit();
    ((ISupportInitialize) this.pictureBox_surface).BeginInit();
    this.SuspendLayout();
    this.comboBox_dbSource.DropDownStyle = ComboBoxStyle.DropDownList;
    this.comboBox_dbSource.FormattingEnabled = true;
    this.comboBox_dbSource.Items.AddRange(new object[4]
    {
      (object) "pwi",
      (object) "my",
      (object) "ms",
      (object) "ru"
    });
    this.comboBox_dbSource.Location = new Point(81, 44);
    this.comboBox_dbSource.Name = "comboBox_dbSource";
    this.comboBox_dbSource.Size = new Size(65, 21);
    this.comboBox_dbSource.TabIndex = 5;
    this.textBox_durationC.Location = new Point(253, 318);
    this.textBox_durationC.Name = "textBox_durationC";
    this.textBox_durationC.Size = new Size(168, 20);
    this.textBox_durationC.TabIndex = 29;
    this.textBox_durationC.TextAlign = HorizontalAlignment.Center;
    this.textBox_durationC.Leave += new EventHandler(this.edit_item);
    this.textBox_durationB.Location = new Point(253, 292);
    this.textBox_durationB.Name = "textBox_durationB";
    this.textBox_durationB.Size = new Size(168, 20);
    this.textBox_durationB.TabIndex = 25;
    this.textBox_durationB.TextAlign = HorizontalAlignment.Center;
    this.textBox_durationB.Leave += new EventHandler(this.edit_item);
    this.textBox_durationA.Location = new Point(253, 266);
    this.textBox_durationA.Name = "textBox_durationA";
    this.textBox_durationA.Size = new Size(168, 20);
    this.textBox_durationA.TabIndex = 21;
    this.textBox_durationA.TextAlign = HorizontalAlignment.Center;
    this.textBox_durationA.Leave += new EventHandler(this.edit_item);
    this.comboBox_status.DropDownStyle = ComboBoxStyle.DropDownList;
    this.comboBox_status.FormattingEnabled = true;
    this.comboBox_status.Items.AddRange(new object[5]
    {
      (object) "0 - Normal",
      (object) "1 - New",
      (object) "2 - Hot",
      (object) "3 - ",
      (object) "4 - Sale"
    });
    this.comboBox_status.Location = new Point(81, 203);
    this.comboBox_status.Name = "comboBox_status";
    this.comboBox_status.Size = new Size(80, 21);
    this.comboBox_status.TabIndex = 14;
    this.comboBox_status.Leave += new EventHandler(this.edit_item);
    this.label14.AutoSize = true;
    this.label14.Location = new Point(6, 206);
    this.label14.Name = "label14";
    this.label14.Size = new Size(40, 13);
    this.label14.TabIndex = 13;
    this.label14.Text = "Status:";
    this.numericUpDown_unknown3.Location = new Point(253, 379);
    this.numericUpDown_unknown3.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.numericUpDown_unknown3.Minimum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      int.MinValue
    });
    this.numericUpDown_unknown3.Name = "numericUpDown_unknown3";
    this.numericUpDown_unknown3.Size = new Size(80, 20);
    this.numericUpDown_unknown3.TabIndex = 33;
    this.numericUpDown_unknown3.Leave += new EventHandler(this.edit_item);
    this.numericUpDown_unknown2.Location = new Point(167, 379);
    this.numericUpDown_unknown2.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.numericUpDown_unknown2.Minimum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      int.MinValue
    });
    this.numericUpDown_unknown2.Name = "numericUpDown_unknown2";
    this.numericUpDown_unknown2.Size = new Size(80, 20);
    this.numericUpDown_unknown2.TabIndex = 32;
    this.numericUpDown_unknown2.Leave += new EventHandler(this.edit_item);
    this.groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox1.Controls.Add((Control) this.button_save);
    this.groupBox1.Controls.Add((Control) this.button_load);
    this.groupBox1.Controls.Add((Control) this.textBox_file);
    this.groupBox1.Location = new Point(2, 27);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(788, 45);
    this.groupBox1.TabIndex = 1;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "FILE";
    this.button_save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button_save.Location = new Point(729, 19);
    this.button_save.Name = "button_save";
    this.button_save.Size = new Size(54, 20);
    this.button_save.TabIndex = 2;
    this.button_save.Text = "Save";
    this.button_save.UseVisualStyleBackColor = true;
    this.button_save.Click += new EventHandler(this.click_save);
    this.button_load.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button_load.Location = new Point(669, 19);
    this.button_load.Name = "button_load";
    this.button_load.Size = new Size(54, 20);
    this.button_load.TabIndex = 1;
    this.button_load.Text = "Load...";
    this.button_load.UseVisualStyleBackColor = true;
    this.button_load.Click += new EventHandler(this.click_load);
    this.textBox_file.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.textBox_file.Enabled = false;
    this.textBox_file.Location = new Point(6, 19);
    this.textBox_file.Name = "textBox_file";
    this.textBox_file.Size = new Size(657, 20);
    this.textBox_file.TabIndex = 0;
    this.numericUpDown_unknown1.Location = new Point(81, 379);
    this.numericUpDown_unknown1.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.numericUpDown_unknown1.Minimum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      int.MinValue
    });
    this.numericUpDown_unknown1.Name = "numericUpDown_unknown1";
    this.numericUpDown_unknown1.Size = new Size(80, 20);
    this.numericUpDown_unknown1.TabIndex = 31;
    this.numericUpDown_unknown1.Leave += new EventHandler(this.edit_item);
    this.label11.AutoSize = true;
    this.label11.Location = new Point(6, 383);
    this.label11.Name = "label11";
    this.label11.Size = new Size(61, 13);
    this.label11.TabIndex = 30;
    this.label11.Text = "Unknowns:";
    this.label21.AutoSize = true;
    this.label21.Location = new Point(6, 322);
    this.label21.Name = "label21";
    this.label21.Size = new Size(50, 13);
    this.label21.TabIndex = 26;
    this.label21.Text = "Option 3:";
    this.label20.AutoSize = true;
    this.label20.Location = new Point(6, 268);
    this.label20.Name = "label20";
    this.label20.Size = new Size(50, 13);
    this.label20.TabIndex = 18;
    this.label20.Text = "Option 1:";
    this.label18.AutoSize = true;
    this.label18.Location = new Point(157, 19);
    this.label18.Name = "label18";
    this.label18.Size = new Size(35, 13);
    this.label18.TabIndex = 6;
    this.label18.Text = "Items:";
    this.label19.AutoSize = true;
    this.label19.Location = new Point(6, 294);
    this.label19.Name = "label19";
    this.label19.Size = new Size(50, 13);
    this.label19.TabIndex = 22;
    this.label19.Text = "Option 2:";
    this.menuStrip_mainMenu.BackColor = SystemColors.Control;
    this.menuStrip_mainMenu.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.toolStripMenuItem4
    });
    this.menuStrip_mainMenu.Location = new Point(0, 0);
    this.menuStrip_mainMenu.Name = "menuStrip_mainMenu";
    this.menuStrip_mainMenu.Padding = new Padding(0, 2, 2, 2);
    this.menuStrip_mainMenu.RenderMode = ToolStripRenderMode.System;
    this.menuStrip_mainMenu.Size = new Size(792, 24);
    this.menuStrip_mainMenu.TabIndex = 0;
    this.menuStrip_mainMenu.Text = "menuStrip1";
    this.toolStripMenuItem4.DisplayStyle = ToolStripItemDisplayStyle.Text;
    this.toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.exitToolStripMenuItem
    });
    this.toolStripMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
    this.toolStripMenuItem4.Name = "toolStripMenuItem4";
    this.toolStripMenuItem4.Padding = new Padding(0);
    this.toolStripMenuItem4.Size = new Size(27, 20);
    this.toolStripMenuItem4.Text = "File";
    this.toolStripMenuItem4.TextAlign = ContentAlignment.MiddleLeft;
    this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
    this.exitToolStripMenuItem.Size = new Size(92, 22);
    this.exitToolStripMenuItem.Text = "Exit";
    this.exitToolStripMenuItem.Click += new EventHandler(this.click_exit);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(3, 197);
    this.label2.Name = "label2";
    this.label2.Size = new Size(82, 13);
    this.label2.TabIndex = 3;
    this.label2.Text = "Sub Categories:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(3, 19);
    this.label1.Name = "label1";
    this.label1.Size = new Size(60, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Categories:";
    this.label17.AutoSize = true;
    this.label17.Location = new Point(6, 48);
    this.label17.Name = "label17";
    this.label17.Size = new Size(45, 13);
    this.label17.TabIndex = 4;
    this.label17.Text = "Update:";
    this.textBox_SubCat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.textBox_SubCat.Location = new Point(6, 353);
    this.textBox_SubCat.MaxLength = 12;
    this.textBox_SubCat.Name = "textBox_SubCat";
    this.textBox_SubCat.Size = new Size(148, 20);
    this.textBox_SubCat.TabIndex = 5;
    this.textBox_SubCat.TextChanged += new EventHandler(this.rename_subcat);
    this.groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox3.Controls.Add((Control) this.label18);
    this.groupBox3.Controls.Add((Control) this.label2);
    this.groupBox3.Controls.Add((Control) this.label1);
    this.groupBox3.Controls.Add((Control) this.textBox_SubCat);
    this.groupBox3.Controls.Add((Control) this.textBox_Cat);
    this.groupBox3.Controls.Add((Control) this.listBox_Cats);
    this.groupBox3.Controls.Add((Control) this.listBox_SubCats);
    this.groupBox3.Controls.Add((Control) this.listBox_Items);
    this.groupBox3.Location = new Point(2, 78);
    this.groupBox3.Name = "groupBox3";
    this.groupBox3.Size = new Size(355, 379);
    this.groupBox3.TabIndex = 2;
    this.groupBox3.TabStop = false;
    this.groupBox3.Text = "LISTS";
    this.textBox_Cat.Location = new Point(6, 162);
    this.textBox_Cat.MaxLength = 12;
    this.textBox_Cat.Name = "textBox_Cat";
    this.textBox_Cat.Size = new Size(148, 20);
    this.textBox_Cat.TabIndex = 2;
    this.textBox_Cat.TextChanged += new EventHandler(this.rename_cat);
    this.listBox_Cats.FormattingEnabled = true;
    this.listBox_Cats.Location = new Point(6, 35);
    this.listBox_Cats.Name = "listBox_Cats";
    this.listBox_Cats.Size = new Size(148, 121);
    this.listBox_Cats.TabIndex = 1;
    this.listBox_Cats.MouseUp += new MouseEventHandler(this.mouseUp_StopMove);
    this.listBox_Cats.SelectedIndexChanged += new EventHandler(this.change_cat);
    this.listBox_Cats.MouseMove += new MouseEventHandler(this.mouseMove_MoveCat);
    this.listBox_Cats.MouseDown += new MouseEventHandler(this.mouseDown_StartMove);
    this.listBox_SubCats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.listBox_SubCats.ContextMenuStrip = this.contextMenuStrip_SubCat;
    this.listBox_SubCats.FormattingEnabled = true;
    this.listBox_SubCats.Location = new Point(6, 213);
    this.listBox_SubCats.Name = "listBox_SubCats";
    this.listBox_SubCats.Size = new Size(148, 134);
    this.listBox_SubCats.TabIndex = 4;
    this.listBox_SubCats.MouseUp += new MouseEventHandler(this.mouseUp_StopMove);
    this.listBox_SubCats.SelectedIndexChanged += new EventHandler(this.change_subcat);
    this.listBox_SubCats.MouseMove += new MouseEventHandler(this.mouseMove_MoveSubCat);
    this.listBox_SubCats.MouseDown += new MouseEventHandler(this.mouseDown_StartMove);
    this.contextMenuStrip_SubCat.Items.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.toolStripMenuItem1,
      (ToolStripItem) this.toolStripMenuItem2,
      (ToolStripItem) this.toolStripSeparator1,
      (ToolStripItem) this.toolStripMenuItem_moveCat
    });
    this.contextMenuStrip_SubCat.Name = "contextMenuStrip_SubCat";
    this.contextMenuStrip_SubCat.RenderMode = ToolStripRenderMode.System;
    this.contextMenuStrip_SubCat.ShowImageMargin = false;
    this.contextMenuStrip_SubCat.Size = new Size(91, 76);
    this.toolStripMenuItem1.Name = "toolStripMenuItem1";
    this.toolStripMenuItem1.Size = new Size(90, 22);
    this.toolStripMenuItem1.Text = "Add";
    this.toolStripMenuItem1.Click += new EventHandler(this.click_addSubCat);
    this.toolStripMenuItem2.Name = "toolStripMenuItem2";
    this.toolStripMenuItem2.Size = new Size(90, 22);
    this.toolStripMenuItem2.Text = "Delete";
    this.toolStripMenuItem2.Click += new EventHandler(this.click_deleteSubCat);
    this.toolStripSeparator1.Name = "toolStripSeparator1";
    this.toolStripSeparator1.Size = new Size(87, 6);
    this.toolStripMenuItem_moveCat.Name = "toolStripMenuItem_moveCat";
    this.toolStripMenuItem_moveCat.Size = new Size(90, 22);
    this.toolStripMenuItem_moveCat.Text = "Move To";
    this.listBox_Items.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.listBox_Items.ContextMenuStrip = this.contextMenuStrip_Item;
    this.listBox_Items.FormattingEnabled = true;
    this.listBox_Items.Location = new Point(160, 35);
    this.listBox_Items.Name = "listBox_Items";
    this.listBox_Items.Size = new Size(189, 342);
    this.listBox_Items.TabIndex = 7;
    this.listBox_Items.MouseUp += new MouseEventHandler(this.mouseUp_StopMove);
    this.listBox_Items.SelectedIndexChanged += new EventHandler(this.change_item);
    this.listBox_Items.MouseMove += new MouseEventHandler(this.mouseMove_MoveItem);
    this.listBox_Items.MouseDown += new MouseEventHandler(this.mouseDown_StartMove);
    this.contextMenuStrip_Item.Items.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.toolStripMenuItem3,
      (ToolStripItem) this.toolStripMenuItem12,
      (ToolStripItem) this.toolStripSeparator2,
      (ToolStripItem) this.toolStripMenuItem_moveItem
    });
    this.contextMenuStrip_Item.Name = "contextMenuStrip_Item";
    this.contextMenuStrip_Item.RenderMode = ToolStripRenderMode.System;
    this.contextMenuStrip_Item.ShowImageMargin = false;
    this.contextMenuStrip_Item.Size = new Size(91, 76);
    this.toolStripMenuItem3.Name = "toolStripMenuItem3";
    this.toolStripMenuItem3.Size = new Size(90, 22);
    this.toolStripMenuItem3.Text = "Add";
    this.toolStripMenuItem3.Click += new EventHandler(this.click_addItem);
    this.toolStripMenuItem12.Name = "toolStripMenuItem12";
    this.toolStripMenuItem12.Size = new Size(90, 22);
    this.toolStripMenuItem12.Text = "Delete";
    this.toolStripMenuItem12.Click += new EventHandler(this.click_deleteItem);
    this.toolStripSeparator2.Name = "toolStripSeparator2";
    this.toolStripSeparator2.Size = new Size(87, 6);
    this.toolStripMenuItem_moveItem.Name = "toolStripMenuItem_moveItem";
    this.toolStripMenuItem_moveItem.Size = new Size(90, 22);
    this.toolStripMenuItem_moveItem.Text = "Move To";
    this.groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    this.groupBox2.Controls.Add((Control) this.comboBox_dbSource);
    this.groupBox2.Controls.Add((Control) this.textBox_durationC);
    this.groupBox2.Controls.Add((Control) this.textBox_durationB);
    this.groupBox2.Controls.Add((Control) this.textBox_durationA);
    this.groupBox2.Controls.Add((Control) this.comboBox_status);
    this.groupBox2.Controls.Add((Control) this.label14);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_unknown3);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_unknown2);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_unknown1);
    this.groupBox2.Controls.Add((Control) this.label11);
    this.groupBox2.Controls.Add((Control) this.label21);
    this.groupBox2.Controls.Add((Control) this.label20);
    this.groupBox2.Controls.Add((Control) this.label19);
    this.groupBox2.Controls.Add((Control) this.label17);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_valueC);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_priceC);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_valueB);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_priceB);
    this.groupBox2.Controls.Add((Control) this.label10);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_valueA);
    this.groupBox2.Controls.Add((Control) this.label9);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_priceA);
    this.groupBox2.Controls.Add((Control) this.label8);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_amount);
    this.groupBox2.Controls.Add((Control) this.label7);
    this.groupBox2.Controls.Add((Control) this.comboBox_surface);
    this.groupBox2.Controls.Add((Control) this.button_autoDetect);
    this.groupBox2.Controls.Add((Control) this.numericUpDown_itemID);
    this.groupBox2.Controls.Add((Control) this.textBox_name);
    this.groupBox2.Controls.Add((Control) this.label6);
    this.groupBox2.Controls.Add((Control) this.label5);
    this.groupBox2.Controls.Add((Control) this.label4);
    this.groupBox2.Controls.Add((Control) this.label3);
    this.groupBox2.Controls.Add((Control) this.textBox_description);
    this.groupBox2.Controls.Add((Control) this.pictureBox_surface);
    this.groupBox2.Location = new Point(363, 78);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(427, 405);
    this.groupBox2.TabIndex = 3;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "ITEM";
    this.numericUpDown_valueC.Location = new Point(167, 318);
    this.numericUpDown_valueC.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.numericUpDown_valueC.Minimum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      int.MinValue
    });
    this.numericUpDown_valueC.Name = "numericUpDown_valueC";
    this.numericUpDown_valueC.Size = new Size(80, 20);
    this.numericUpDown_valueC.TabIndex = 28;
    this.numericUpDown_valueC.Leave += new EventHandler(this.edit_item);
    this.numericUpDown_priceC.DecimalPlaces = 2;
    this.numericUpDown_priceC.Location = new Point(81, 318);
    this.numericUpDown_priceC.Maximum = new Decimal(new int[4]
    {
      9999999,
      0,
      0,
      131072
    });
    this.numericUpDown_priceC.Name = "numericUpDown_priceC";
    this.numericUpDown_priceC.Size = new Size(80, 20);
    this.numericUpDown_priceC.TabIndex = 27;
    this.numericUpDown_priceC.Leave += new EventHandler(this.edit_item);
    this.numericUpDown_valueB.Location = new Point(167, 292);
    this.numericUpDown_valueB.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.numericUpDown_valueB.Minimum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      int.MinValue
    });
    this.numericUpDown_valueB.Name = "numericUpDown_valueB";
    this.numericUpDown_valueB.Size = new Size(80, 20);
    this.numericUpDown_valueB.TabIndex = 24;
    this.numericUpDown_valueB.Leave += new EventHandler(this.edit_item);
    this.numericUpDown_priceB.DecimalPlaces = 2;
    this.numericUpDown_priceB.Location = new Point(81, 292);
    this.numericUpDown_priceB.Maximum = new Decimal(new int[4]
    {
      9999999,
      0,
      0,
      131072
    });
    this.numericUpDown_priceB.Name = "numericUpDown_priceB";
    this.numericUpDown_priceB.Size = new Size(80, 20);
    this.numericUpDown_priceB.TabIndex = 23;
    this.numericUpDown_priceB.Leave += new EventHandler(this.edit_item);
    this.label10.AutoSize = true;
    this.label10.Location = new Point(250, 250);
    this.label10.Name = "label10";
    this.label10.Size = new Size(117, 13);
    this.label10.TabIndex = 17;
    this.label10.Text = "Expire (dd-HH:MM:SS):";
    this.numericUpDown_valueA.Location = new Point(167, 266);
    this.numericUpDown_valueA.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.numericUpDown_valueA.Minimum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      int.MinValue
    });
    this.numericUpDown_valueA.Name = "numericUpDown_valueA";
    this.numericUpDown_valueA.Size = new Size(80, 20);
    this.numericUpDown_valueA.TabIndex = 20;
    this.numericUpDown_valueA.Leave += new EventHandler(this.edit_item);
    this.label9.AutoSize = true;
    this.label9.Location = new Point(164, 250);
    this.label9.Name = "label9";
    this.label9.Size = new Size(37, 13);
    this.label9.TabIndex = 16;
    this.label9.Text = "Value:";
    this.numericUpDown_priceA.DecimalPlaces = 2;
    this.numericUpDown_priceA.Location = new Point(81, 266);
    this.numericUpDown_priceA.Maximum = new Decimal(new int[4]
    {
      9999999,
      0,
      0,
      131072
    });
    this.numericUpDown_priceA.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      131072
    });
    this.numericUpDown_priceA.Name = "numericUpDown_priceA";
    this.numericUpDown_priceA.Size = new Size(80, 20);
    this.numericUpDown_priceA.TabIndex = 19;
    this.numericUpDown_priceA.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      131072
    });
    this.numericUpDown_priceA.Leave += new EventHandler(this.edit_item);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(78, 250);
    this.label8.Name = "label8";
    this.label8.Size = new Size(34, 13);
    this.label8.TabIndex = 15;
    this.label8.Text = "Price:";
    this.numericUpDown_amount.Location = new Point(220, 19);
    this.numericUpDown_amount.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.numericUpDown_amount.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.numericUpDown_amount.Name = "numericUpDown_amount";
    this.numericUpDown_amount.Size = new Size(65, 20);
    this.numericUpDown_amount.TabIndex = 3;
    this.numericUpDown_amount.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.numericUpDown_amount.Leave += new EventHandler(this.edit_item);
    this.label7.AutoSize = true;
    this.label7.Location = new Point(168, 23);
    this.label7.Name = "label7";
    this.label7.Size = new Size(46, 13);
    this.label7.TabIndex = 2;
    this.label7.Text = "Amount:";
    this.comboBox_surface.FormattingEnabled = true;
    this.comboBox_surface.Location = new Point(81, 155);
    this.comboBox_surface.Name = "comboBox_surface";
    this.comboBox_surface.Size = new Size(340, 21);
    this.comboBox_surface.TabIndex = 12;
    this.comboBox_surface.Leave += new EventHandler(this.edit_item);
    this.comboBox_surface.TextChanged += new EventHandler(this.load_surface);
    this.button_autoDetect.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button_autoDetect.ForeColor = Color.Blue;
    this.button_autoDetect.Location = new Point(152, 44);
    this.button_autoDetect.Name = "button_autoDetect";
    this.button_autoDetect.Size = new Size(133, 21);
    this.button_autoDetect.TabIndex = 6;
    this.button_autoDetect.Text = "www.pwdatabase.com";
    this.button_autoDetect.UseVisualStyleBackColor = true;
    this.button_autoDetect.Click += new EventHandler(this.click_autoDetect);
    this.numericUpDown_itemID.Location = new Point(81, 19);
    this.numericUpDown_itemID.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.numericUpDown_itemID.Name = "numericUpDown_itemID";
    this.numericUpDown_itemID.Size = new Size(65, 20);
    this.numericUpDown_itemID.TabIndex = 1;
    this.numericUpDown_itemID.Leave += new EventHandler(this.edit_item);
    this.textBox_name.Location = new Point(81, 71);
    this.textBox_name.MaxLength = 32;
    this.textBox_name.Name = "textBox_name";
    this.textBox_name.Size = new Size(204, 20);
    this.textBox_name.TabIndex = 8;
    this.textBox_name.Leave += new EventHandler(this.edit_item);
    this.label6.AutoSize = true;
    this.label6.Location = new Point(6, 74);
    this.label6.Name = "label6";
    this.label6.Size = new Size(38, 13);
    this.label6.TabIndex = 7;
    this.label6.Text = "Name:";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(6, 23);
    this.label5.Name = "label5";
    this.label5.Size = new Size(44, 13);
    this.label5.TabIndex = 0;
    this.label5.Text = "Item ID:";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(6, 158);
    this.label4.Name = "label4";
    this.label4.Size = new Size(47, 13);
    this.label4.TabIndex = 11;
    this.label4.Text = "Surface:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(6, 100);
    this.label3.Name = "label3";
    this.label3.Size = new Size(63, 13);
    this.label3.TabIndex = 9;
    this.label3.Text = "Description:";
    this.textBox_description.Location = new Point(81, 97);
    this.textBox_description.MaxLength = 512;
    this.textBox_description.Multiline = true;
    this.textBox_description.Name = "textBox_description";
    this.textBox_description.ScrollBars = ScrollBars.Both;
    this.textBox_description.Size = new Size(204, 52);
    this.textBox_description.TabIndex = 10;
    this.textBox_description.Leave += new EventHandler(this.edit_item);
    this.pictureBox_surface.BackColor = Color.Gray;
    this.pictureBox_surface.BorderStyle = BorderStyle.FixedSingle;
    this.pictureBox_surface.Location = new Point(291, 19);
    this.pictureBox_surface.Name = "pictureBox_surface";
    this.pictureBox_surface.Size = new Size(130, 130);
    this.pictureBox_surface.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox_surface.TabIndex = 6;
    this.pictureBox_surface.TabStop = false;
    this.linkLabel_home.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.linkLabel_home.AutoSize = true;
    this.linkLabel_home.LinkColor = Color.Blue;
    this.linkLabel_home.Location = new Point(661, 4);
    this.linkLabel_home.Name = "linkLabel_home";
    this.linkLabel_home.Size = new Size(129, 13);
    this.linkLabel_home.TabIndex = 4;
    this.linkLabel_home.TabStop = true;
    this.linkLabel_home.Text = "Check Project Homepage";
    this.linkLabel_home.VisitedLinkColor = Color.Blue;
    this.linkLabel_home.LinkClicked += new LinkLabelLinkClickedEventHandler(this.click_home);
    this.textBox_search.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.textBox_search.Location = new Point(2, 463);
    this.textBox_search.Name = "textBox_search";
    this.textBox_search.Size = new Size(256, 20);
    this.textBox_search.TabIndex = 5;
    this.textBox_search.Text = "ID or Name";
    this.textBox_search.TextAlign = HorizontalAlignment.Center;
    this.textBox_search.KeyPress += new KeyPressEventHandler(this.keyPress_search);
    this.button_search.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.button_search.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button_search.Location = new Point(264, 463);
    this.button_search.Name = "button_search";
    this.button_search.Size = new Size(93, 20);
    this.button_search.TabIndex = 6;
    this.button_search.Text = "Find Next";
    this.button_search.UseVisualStyleBackColor = true;
    this.button_search.Click += new EventHandler(this.click_search);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(792, 485);
    this.Controls.Add((Control) this.button_search);
    this.Controls.Add((Control) this.textBox_search);
    this.Controls.Add((Control) this.linkLabel_home);
    this.Controls.Add((Control) this.groupBox1);
    this.Controls.Add((Control) this.menuStrip_mainMenu);
    this.Controls.Add((Control) this.groupBox3);
    this.Controls.Add((Control) this.groupBox2);
    this.MinimumSize = new Size(800, 512);
    this.Name = nameof (MainWindow);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = " sGSHOPedit";
    this.numericUpDown_unknown3.EndInit();
    this.numericUpDown_unknown2.EndInit();
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    this.numericUpDown_unknown1.EndInit();
    this.menuStrip_mainMenu.ResumeLayout(false);
    this.menuStrip_mainMenu.PerformLayout();
    this.groupBox3.ResumeLayout(false);
    this.groupBox3.PerformLayout();
    this.contextMenuStrip_SubCat.ResumeLayout(false);
    this.contextMenuStrip_Item.ResumeLayout(false);
    this.groupBox2.ResumeLayout(false);
    this.groupBox2.PerformLayout();
    this.numericUpDown_valueC.EndInit();
    this.numericUpDown_priceC.EndInit();
    this.numericUpDown_valueB.EndInit();
    this.numericUpDown_priceB.EndInit();
    this.numericUpDown_valueA.EndInit();
    this.numericUpDown_priceA.EndInit();
    this.numericUpDown_amount.EndInit();
    this.numericUpDown_itemID.EndInit();
    ((ISupportInitialize) this.pictureBox_surface).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void initialize()
  {
    this.comboBox_dbSource.SelectedIndex = 0;
    this.comboBox_surface.Items.Clear();
    foreach (string file in Directory.GetFiles(Application.StartupPath + "\\surfaces\\百宝阁"))
      this.comboBox_surface.Items.Add((object) file.Replace(Application.StartupPath + "\\", "").Replace(".jpg", ".dds"));
    this.itemDescriptions = new SortedList();
    if (!System.IO.File.Exists(Application.StartupPath + "\\" + "item_ext_desc.txt"))
      return;
    StreamReader streamReader = new StreamReader(Application.StartupPath + "\\" + "item_ext_desc.txt", Encoding.GetEncoding("Unicode"));
    while (true)
    {
      string str;
      do
      {
        str = streamReader.ReadLine();
        if (str == null)
          goto label_9;
      }
      while (!(str != "") || str.StartsWith("/") || str.StartsWith("#"));
      char[] chArray = new char[1]{ '"' };
      string[] strArray = str.Split(chArray);
      this.itemDescriptions.Add((object) strArray[0].Trim(), (object) strArray[1]);
    }
label_9:
    streamReader.Close();
  }

  private void build_contextMenus()
  {
    this.toolStripMenuItem_moveCat.DropDownItems.Clear();
    this.toolStripMenuItem_moveItem.DropDownItems.Clear();
    for (int index1 = 0; index1 < this.GSHOP.categories.Length; ++index1)
    {
      char[] chArray1 = new char[1]{ char.MinValue };
      ToolStripItemCollection dropDownItems1 = this.toolStripMenuItem_moveCat.DropDownItems;
      MainWindow mainWindow1 = this;
      string text1 = mainWindow1.bytes_to_string(mainWindow1.GSHOP.categories[index1].name, "Unicode").TrimEnd(chArray1);
      dropDownItems1.Add(text1);
      this.toolStripMenuItem_moveCat.DropDownItems[index1].Click += new EventHandler(this.move_subcat);
      char[] chArray2 = new char[1]{ char.MinValue };
      ToolStripItemCollection dropDownItems2 = this.toolStripMenuItem_moveItem.DropDownItems;
      MainWindow mainWindow2 = this;
      string text2 = mainWindow2.bytes_to_string(mainWindow2.GSHOP.categories[index1].name, "Unicode").TrimEnd(chArray2);
      dropDownItems2.Add(text2);
      for (int index2 = 0; index2 < this.GSHOP.categories[index1].sub_cats.Length; ++index2)
      {
        char[] chArray3 = new char[1]{ char.MinValue };
        ToolStripItemCollection dropDownItems3 = ((ToolStripDropDownItem) this.toolStripMenuItem_moveItem.DropDownItems[index1]).DropDownItems;
        MainWindow mainWindow3 = this;
        string text3 = mainWindow3.bytes_to_string(mainWindow3.GSHOP.categories[index1].sub_cats[index2], "Unicode").TrimEnd(chArray3);
        dropDownItems3.Add(text3);
        ((ToolStripDropDownItem) this.toolStripMenuItem_moveItem.DropDownItems[index1]).DropDownItems[index2].Click += new EventHandler(this.move_item);
      }
    }
  }

  private unsafe int string_to_seconds(string time)
  {
    // ISSUE: untyped stack allocation
    int num1 = (int) __untypedstackalloc(\u003CModule\u003E.__CxxQueryExceptionSize() * 1);
    int num2;
    int num3;
    try
    {
      char[] chArray = new char[2]{ '-', ':' };
      string[] strArray = time.Split(chArray);
      num2 = Convert.ToInt32(strArray[0]) * 86400 + Convert.ToInt32(strArray[1]) * 3600 + Convert.ToInt32(strArray[2]) * 60 + Convert.ToInt32(strArray[3]);
      goto label_11;
    }
    catch (Exception ex1) when (
    {
      // ISSUE: unable to correctly present filter
      uint exceptionCode = (uint) Marshal.GetExceptionCode();
      if (\u003CModule\u003E.__CxxExceptionFilter((void*) Marshal.GetExceptionPointers(), (void*) 0, 0, (void*) 0) != 0)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      uint num4 = 0;
      \u003CModule\u003E.__CxxRegisterExceptionObject((void*) Marshal.GetExceptionPointers(), (void*) num1);
      try
      {
        try
        {
          num3 = 0;
          goto label_10;
        }
        catch (Exception ex2) when (
        {
          // ISSUE: unable to correctly present filter
          num4 = (uint) \u003CModule\u003E.__CxxDetectRethrow((void*) Marshal.GetExceptionPointers());
          if (num4 != 0U)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
        }
        if (num4 != 0U)
          throw;
        else
          goto label_11;
      }
      finally
      {
        \u003CModule\u003E.__CxxUnregisterExceptionObject((void*) num1, (int) num4);
      }
    }
label_10:
    num2 = num3;
label_11:
    return num2;
  }

  private unsafe string seconds_to_string(int time)
  {
    // ISSUE: untyped stack allocation
    int num1 = (int) __untypedstackalloc(\u003CModule\u003E.__CxxQueryExceptionSize() * 1);
    string str1;
    string str2;
    try
    {
      int num2 = time / 86400;
      time -= num2 * 86400;
      int num3 = time / 3600;
      time -= num3 * 3600;
      int num4 = time / 60;
      int num5 = time - num4 * 60;
      int num6 = num4;
      int num7 = num3;
      str1 = num2.ToString("D2") + "-" + num7.ToString("D2") + ":" + num6.ToString("D2") + ":" + num5.ToString("D2");
      goto label_11;
    }
    catch (Exception ex1) when (
    {
      // ISSUE: unable to correctly present filter
      uint exceptionCode = (uint) Marshal.GetExceptionCode();
      if (\u003CModule\u003E.__CxxExceptionFilter((void*) Marshal.GetExceptionPointers(), (void*) 0, 0, (void*) 0) != 0)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      uint num2 = 0;
      \u003CModule\u003E.__CxxRegisterExceptionObject((void*) Marshal.GetExceptionPointers(), (void*) num1);
      try
      {
        try
        {
          str2 = "0";
          goto label_10;
        }
        catch (Exception ex2) when (
        {
          // ISSUE: unable to correctly present filter
          num2 = (uint) \u003CModule\u003E.__CxxDetectRethrow((void*) Marshal.GetExceptionPointers());
          if (num2 != 0U)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
        }
        if (num2 != 0U)
          throw;
        else
          goto label_11;
      }
      finally
      {
        \u003CModule\u003E.__CxxUnregisterExceptionObject((void*) num1, (int) num2);
      }
    }
label_10:
    str1 = str2;
label_11:
    return str1;
  }

  private string bytes_to_string(byte[] value, string code)
  {
    return Encoding.GetEncoding(code).GetString(value);
  }

  private byte[] string_to_bytes(string value, string code, int bytes)
  {
    Encoding encoding = Encoding.GetEncoding(code);
    byte[] numArray1 = new byte[bytes];
    byte[] bytes1 = encoding.GetBytes(value);
    if (numArray1.Length > bytes1.Length)
    {
      Array.Copy((Array) bytes1, (Array) numArray1, bytes1.Length);
    }
    else
    {
      byte[] numArray2 = bytes1;
      byte[] numArray3 = numArray1;
      int length = numArray3.Length;
      Array.Copy((Array) numArray2, (Array) numArray3, length);
    }
    return numArray1;
  }

  private void click_load(object sender, EventArgs e)
  {
    OpenFileDialog openFileDialog = new OpenFileDialog();
    openFileDialog.Filter = "Gshop (*.data)|*.data|All Files (*.*)|*.*";
    if (openFileDialog.ShowDialog() != DialogResult.OK)
      return;
    if (!System.IO.File.Exists(openFileDialog.FileName))
      return;
    try
    {
      this.Cursor = Cursors.WaitCursor;
      this.textBox_file.Text = openFileDialog.FileName;
      this.listBox_Cats.Items.Clear();
      this.listBox_SubCats.Items.Clear();
      this.listBox_Items.Items.Clear();
      this.GSHOP = new Boutique();
      this.item_id_index_map = new SortedList();
      this.max_item_id = 0;
      FileStream fileStream = System.IO.File.OpenRead(openFileDialog.FileName);
      BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
      this.GSHOP.timestamp = binaryReader.ReadInt32();
      this.GSHOP.item_count = binaryReader.ReadInt32();
      this.GSHOP.items = new Item[this.GSHOP.item_count];
      for (int index = 0; index < this.GSHOP.items.Length; ++index)
      {
        this.GSHOP.items[index] = new Item();
        this.GSHOP.items[index].shop_id = binaryReader.ReadInt32();
        this.GSHOP.items[index].shop_id = index;
        this.item_id_index_map.Add((object) this.GSHOP.items[index].shop_id, (object) index);
        this.GSHOP.items[index].cat_index = binaryReader.ReadInt32();
        this.GSHOP.items[index].sub_cat_index = binaryReader.ReadInt32();
        this.GSHOP.items[index].surface_path = binaryReader.ReadBytes(128);
        this.GSHOP.items[index].item_id = binaryReader.ReadInt32();
        this.GSHOP.items[index].item_amount = binaryReader.ReadInt32();
        this.GSHOP.items[index].price1 = binaryReader.ReadInt32();
        this.GSHOP.items[index].value1 = binaryReader.ReadInt32();
        this.GSHOP.items[index].duration1 = binaryReader.ReadInt32();
        this.GSHOP.items[index].price2 = binaryReader.ReadInt32();
        this.GSHOP.items[index].value2 = binaryReader.ReadInt32();
        this.GSHOP.items[index].duration2 = binaryReader.ReadInt32();
        this.GSHOP.items[index].price3 = binaryReader.ReadInt32();
        this.GSHOP.items[index].value3 = binaryReader.ReadInt32();
        this.GSHOP.items[index].duration3 = binaryReader.ReadInt32();
        this.GSHOP.items[index].unknown1 = binaryReader.ReadInt32();
        this.GSHOP.items[index].unknown2 = binaryReader.ReadInt32();
        this.GSHOP.items[index].unknown3 = binaryReader.ReadInt32();
        this.GSHOP.items[index].state = binaryReader.ReadInt32();
        this.GSHOP.items[index].description = binaryReader.ReadBytes(1024);
        this.GSHOP.items[index].name = binaryReader.ReadBytes(64);
      }
      MainWindow mainWindow1 = this;
      mainWindow1.max_item_id = mainWindow1.GSHOP.items.Length;
      this.GSHOP.categories = new Category[8];
      for (int index1 = 0; index1 < this.GSHOP.categories.Length; ++index1)
      {
        this.GSHOP.categories[index1] = new Category();
        this.GSHOP.categories[index1].name = binaryReader.ReadBytes(128);
        this.GSHOP.categories[index1].sub_cats_count = binaryReader.ReadInt32();
        this.GSHOP.categories[index1].sub_cats = new byte[this.GSHOP.categories[index1].sub_cats_count][];
        for (int index2 = 0; index2 < this.GSHOP.categories[index1].sub_cats.Length; ++index2)
          this.GSHOP.categories[index1].sub_cats[index2] = binaryReader.ReadBytes(128);
        ListBox.ObjectCollection items = this.listBox_Cats.Items;
        MainWindow mainWindow2 = this;
        string str = mainWindow2.bytes_to_string(mainWindow2.GSHOP.categories[index1].name, "Unicode");
        items.Add((object) str);
      }
      binaryReader.Close();
      fileStream.Close();
      this.build_contextMenus();
      this.Cursor = Cursors.Default;
    }
    catch (Exception ex)
    {
      this.Cursor = Cursors.Default;
      int num = (int) MessageBox.Show("IMPORT ERROR!\n\n" + ex.Message);
    }
  }

  private void click_save(object sender, EventArgs e)
  {
    if (this.GSHOP == null)
      return;
    if (!System.IO.File.Exists(this.textBox_file.Text))
      return;
    try
    {
      this.Cursor = Cursors.WaitCursor;
      FileStream fileStream = new FileStream(this.textBox_file.Text, FileMode.Create, FileAccess.Write);
      BinaryWriter binaryWriter = new BinaryWriter((Stream) fileStream);
      binaryWriter.Write(this.GSHOP.timestamp);
      binaryWriter.Write(this.GSHOP.item_count);
      int num = 0;
      for (int index = 0; index < this.GSHOP.items.Length; ++index)
      {
        if (this.GSHOP.items[index].cat_index <= -1 || this.GSHOP.items[index].sub_cat_index <= -1)
          continue;
        binaryWriter.Write(num);
        binaryWriter.Write(this.GSHOP.items[index].cat_index);
        binaryWriter.Write(this.GSHOP.items[index].sub_cat_index);
        binaryWriter.Write(this.GSHOP.items[index].surface_path);
        binaryWriter.Write(this.GSHOP.items[index].item_id);
        binaryWriter.Write(this.GSHOP.items[index].item_amount);
        binaryWriter.Write(this.GSHOP.items[index].price1);
        binaryWriter.Write(this.GSHOP.items[index].value1);
        binaryWriter.Write(this.GSHOP.items[index].duration1);
        binaryWriter.Write(this.GSHOP.items[index].price2);
        binaryWriter.Write(this.GSHOP.items[index].value2);
        binaryWriter.Write(this.GSHOP.items[index].duration2);
        binaryWriter.Write(this.GSHOP.items[index].price3);
        binaryWriter.Write(this.GSHOP.items[index].value3);
        binaryWriter.Write(this.GSHOP.items[index].duration3);
        binaryWriter.Write(this.GSHOP.items[index].unknown1);
        binaryWriter.Write(this.GSHOP.items[index].unknown2);
        binaryWriter.Write(this.GSHOP.items[index].unknown3);
        binaryWriter.Write(this.GSHOP.items[index].state);
        binaryWriter.Write(this.GSHOP.items[index].description);
        binaryWriter.Write(this.GSHOP.items[index].name);
        ++num;
      }
      for (int index1 = 0; index1 < 8; ++index1)
      {
        binaryWriter.Write(this.GSHOP.categories[index1].name);
        binaryWriter.Write(this.GSHOP.categories[index1].sub_cats.Length);
        for (int index2 = 0; index2 < this.GSHOP.categories[index1].sub_cats.Length; ++index2)
          binaryWriter.Write(this.GSHOP.categories[index1].sub_cats[index2]);
      }
      binaryWriter.Close();
      fileStream.Close();
      this.Cursor = Cursors.Default;
    }
    catch (Exception ex)
    {
      this.Cursor = Cursors.Default;
      int num = (int) MessageBox.Show("EXPORT ERROR!\n\n" + ex.Message);
    }
  }

  private void change_cat(object sender, EventArgs e)
  {
    if (this.GSHOP == null || this.listBox_Cats.SelectedIndex <= -1)
      return;
    if (this.listBox_Cats.SelectedItem.ToString() != this.textBox_Cat.Text)
    {
      TextBox textBoxCat = this.textBox_Cat;
      MainWindow mainWindow = this;
      string str = mainWindow.bytes_to_string(mainWindow.GSHOP.categories[this.listBox_Cats.SelectedIndex].name, "Unicode");
      textBoxCat.Text = str;
    }
    this.listBox_SubCats.Items.Clear();
    this.listBox_Items.Items.Clear();
    for (int index = 0; index < this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats.Length; ++index)
    {
      ListBox.ObjectCollection items = this.listBox_SubCats.Items;
      MainWindow mainWindow = this;
      string str = mainWindow.bytes_to_string(mainWindow.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats[index], "Unicode");
      items.Add((object) str);
    }
  }

  private void change_subcat(object sender, EventArgs e)
  {
    if (this.GSHOP == null || this.listBox_Cats.SelectedIndex <= -1 || this.listBox_SubCats.SelectedIndex <= -1)
      return;
    if (this.listBox_SubCats.SelectedItem.ToString() != this.textBox_SubCat.Text)
    {
      TextBox textBoxSubCat = this.textBox_SubCat;
      MainWindow mainWindow = this;
      string str = mainWindow.bytes_to_string(mainWindow.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats[this.listBox_SubCats.SelectedIndex], "Unicode");
      textBoxSubCat.Text = str;
    }
    this.listBox_Items.Items.Clear();
    for (int index = 0; index < this.GSHOP.items.Length; ++index)
    {
      if (this.GSHOP.items[index].cat_index != this.listBox_Cats.SelectedIndex || this.GSHOP.items[index].sub_cat_index != this.listBox_SubCats.SelectedIndex)
        continue;
      ListBox.ObjectCollection items = this.listBox_Items.Items;
      string str1 = "[" + (object) this.GSHOP.items[index].shop_id + "] ";
      MainWindow mainWindow = this;
      string str2 = mainWindow.bytes_to_string(mainWindow.GSHOP.items[index].name, "Unicode");
      string str3 = str1 + str2;
      items.Add((object) str3);
    }
  }

  private void change_item(object sender, EventArgs e)
  {
    if (this.GSHOP == null || this.listBox_Items.SelectedIndex <= -1)
      return;
    int itemIdIndex = (int) this.item_id_index_map[(object) Convert.ToInt32(this.listBox_Items.SelectedItem.ToString().Substring(1, this.listBox_Items.SelectedItem.ToString().IndexOf("]") - 1))];
    if (itemIdIndex <= -1)
      return;
    this.numericUpDown_itemID.Value = (Decimal) this.GSHOP.items[itemIdIndex].item_id;
    this.numericUpDown_amount.Value = (Decimal) this.GSHOP.items[itemIdIndex].item_amount;
    TextBox textBoxName = this.textBox_name;
    MainWindow mainWindow1 = this;
    string str1 = mainWindow1.bytes_to_string(mainWindow1.GSHOP.items[itemIdIndex].name, "Unicode");
    textBoxName.Text = str1;
    ComboBox comboBoxSurface = this.comboBox_surface;
    MainWindow mainWindow2 = this;
    string str2 = mainWindow2.bytes_to_string(mainWindow2.GSHOP.items[itemIdIndex].surface_path, "GBK");
    comboBoxSurface.Text = str2;
    TextBox textBoxDescription = this.textBox_description;
    MainWindow mainWindow3 = this;
    string str3 = mainWindow3.bytes_to_string(mainWindow3.GSHOP.items[itemIdIndex].description, "Unicode");
    textBoxDescription.Text = str3;
    this.comboBox_status.SelectedIndex = this.GSHOP.items[itemIdIndex].state;
    Decimal num1 = (Decimal) 100;
    this.numericUpDown_priceA.Value = Convert.ToDecimal(this.GSHOP.items[itemIdIndex].price1) / num1;
    this.numericUpDown_valueA.Value = (Decimal) this.GSHOP.items[itemIdIndex].value1;
    TextBox textBoxDurationA = this.textBox_durationA;
    MainWindow mainWindow4 = this;
    string str4 = mainWindow4.seconds_to_string(mainWindow4.GSHOP.items[itemIdIndex].duration1);
    textBoxDurationA.Text = str4;
    Decimal num2 = (Decimal) 100;
    this.numericUpDown_priceB.Value = Convert.ToDecimal(this.GSHOP.items[itemIdIndex].price2) / num2;
    this.numericUpDown_valueB.Value = (Decimal) this.GSHOP.items[itemIdIndex].value2;
    TextBox textBoxDurationB = this.textBox_durationB;
    MainWindow mainWindow5 = this;
    string str5 = mainWindow5.seconds_to_string(mainWindow5.GSHOP.items[itemIdIndex].duration2);
    textBoxDurationB.Text = str5;
    Decimal num3 = (Decimal) 100;
    this.numericUpDown_priceC.Value = Convert.ToDecimal(this.GSHOP.items[itemIdIndex].price3) / num3;
    this.numericUpDown_valueC.Value = (Decimal) this.GSHOP.items[itemIdIndex].value3;
    TextBox textBoxDurationC = this.textBox_durationC;
    MainWindow mainWindow6 = this;
    string str6 = mainWindow6.seconds_to_string(mainWindow6.GSHOP.items[itemIdIndex].duration3);
    textBoxDurationC.Text = str6;
    this.numericUpDown_unknown1.Value = (Decimal) this.GSHOP.items[itemIdIndex].unknown1;
    this.numericUpDown_unknown2.Value = (Decimal) this.GSHOP.items[itemIdIndex].unknown2;
    this.numericUpDown_unknown3.Value = (Decimal) this.GSHOP.items[itemIdIndex].unknown3;
  }

  private unsafe void mouseDown_StartMove(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    this.Cursor = Cursors.SizeNS;
    *this.movingIndex = ((ListBox) sender).SelectedIndex;
  }

  private unsafe void mouseMove_MoveCat(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left || ((ListBox) sender).Items.Count <= 1 || *this.movingIndex == ((ListBox) sender).SelectedIndex)
      return;
    this.listBox_Cats.SelectedIndexChanged -= new EventHandler(this.change_cat);
    if (Math.Abs(*this.movingIndex - ((ListBox) sender).SelectedIndex) == 1)
    {
      Category category = this.GSHOP.categories[*this.movingIndex];
      this.GSHOP.categories[*this.movingIndex] = this.GSHOP.categories[((ListBox) sender).SelectedIndex];
      this.GSHOP.categories[((ListBox) sender).SelectedIndex] = category;
      object obj = ((ListBox) sender).Items[*this.movingIndex];
      ((ListBox) sender).Items[*this.movingIndex] = ((ListBox) sender).Items[((ListBox) sender).SelectedIndex];
      ((ListBox) sender).Items[((ListBox) sender).SelectedIndex] = obj;
      for (int index = 0; index < this.GSHOP.items.Length; ++index)
      {
        if (this.GSHOP.items[index].cat_index != *this.movingIndex)
          goto label_7;
        this.GSHOP.items[index].cat_index = ((ListBox) sender).SelectedIndex;
        continue;
label_7:
        if (this.GSHOP.items[index].cat_index == ((ListBox) sender).SelectedIndex)
          this.GSHOP.items[index].cat_index = *this.movingIndex;
      }
      this.build_contextMenus();
      *this.movingIndex = ((ListBox) sender).SelectedIndex;
    }
    this.listBox_Cats.SelectedIndexChanged += new EventHandler(this.change_cat);
  }

  private unsafe void mouseMove_MoveSubCat(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left || ((ListBox) sender).Items.Count <= 1 || *this.movingIndex == ((ListBox) sender).SelectedIndex)
      return;
    this.listBox_SubCats.SelectedIndexChanged -= new EventHandler(this.change_subcat);
    if (Math.Abs(*this.movingIndex - ((ListBox) sender).SelectedIndex) == 1)
    {
      byte[] subCat = this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats[*this.movingIndex];
      this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats[*this.movingIndex] = this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats[((ListBox) sender).SelectedIndex];
      this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats[((ListBox) sender).SelectedIndex] = subCat;
      object obj = ((ListBox) sender).Items[*this.movingIndex];
      ((ListBox) sender).Items[*this.movingIndex] = ((ListBox) sender).Items[((ListBox) sender).SelectedIndex];
      ((ListBox) sender).Items[((ListBox) sender).SelectedIndex] = obj;
      for (int index = 0; index < this.GSHOP.items.Length; ++index)
      {
        if (this.GSHOP.items[index].cat_index != this.listBox_Cats.SelectedIndex)
          continue;
        if (this.GSHOP.items[index].sub_cat_index == *this.movingIndex)
          this.GSHOP.items[index].sub_cat_index = ((ListBox) sender).SelectedIndex;
        else if (this.GSHOP.items[index].sub_cat_index == ((ListBox) sender).SelectedIndex)
          this.GSHOP.items[index].sub_cat_index = *this.movingIndex;
      }
      this.build_contextMenus();
      *this.movingIndex = ((ListBox) sender).SelectedIndex;
    }
    this.listBox_SubCats.SelectedIndexChanged += new EventHandler(this.change_subcat);
  }

  private unsafe void mouseMove_MoveItem(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left || ((ListBox) sender).Items.Count <= 1 || *this.movingIndex == ((ListBox) sender).SelectedIndex)
      return;
    this.listBox_Items.SelectedIndexChanged -= new EventHandler(this.change_item);
    if (Math.Abs(*this.movingIndex - ((ListBox) sender).SelectedIndex) == 1)
    {
      int int32_1 = Convert.ToInt32(this.listBox_Items.Items[*this.movingIndex].ToString().Substring(1, this.listBox_Items.Items[*this.movingIndex].ToString().IndexOf("]") - 1));
      int int32_2 = Convert.ToInt32(this.listBox_Items.Items[this.listBox_Items.SelectedIndex].ToString().Substring(1, this.listBox_Items.Items[this.listBox_Items.SelectedIndex].ToString().IndexOf("]") - 1));
      Item obj1 = this.GSHOP.items[(int) this.item_id_index_map[(object) int32_1]];
      this.GSHOP.items[(int) this.item_id_index_map[(object) int32_1]] = this.GSHOP.items[(int) this.item_id_index_map[(object) int32_2]];
      this.GSHOP.items[(int) this.item_id_index_map[(object) int32_2]] = obj1;
      int itemIdIndex = (int) this.item_id_index_map[(object) int32_1];
      this.item_id_index_map[(object) int32_1] = this.item_id_index_map[(object) int32_2];
      this.item_id_index_map[(object) int32_2] = (object) itemIdIndex;
      object obj2 = ((ListBox) sender).Items[*this.movingIndex];
      ((ListBox) sender).Items[*this.movingIndex] = ((ListBox) sender).Items[((ListBox) sender).SelectedIndex];
      ((ListBox) sender).Items[((ListBox) sender).SelectedIndex] = obj2;
      *this.movingIndex = ((ListBox) sender).SelectedIndex;
    }
    this.listBox_Items.SelectedIndexChanged += new EventHandler(this.change_item);
  }

  private void mouseUp_StopMove(object sender, MouseEventArgs e)
  {
    this.Cursor = Cursors.Default;
  }

  private void move_subcat(object sender, EventArgs e)
  {
    if (this.GSHOP == null || this.listBox_Cats.SelectedIndex <= -1 || this.listBox_SubCats.SelectedIndex <= -1)
      return;
    int selectedIndex1 = this.listBox_Cats.SelectedIndex;
    int selectedIndex2 = this.listBox_SubCats.SelectedIndex;
    int index1 = this.toolStripMenuItem_moveCat.DropDownItems.IndexOf((ToolStripItem) sender);
    if (this.GSHOP.categories[index1].sub_cats.Length < 8)
    {
      int subCatsCount = this.GSHOP.categories[index1].sub_cats_count;
      ++this.GSHOP.categories[index1].sub_cats_count;
      Array.Resize<byte[]>(ref this.GSHOP.categories[index1].sub_cats, this.GSHOP.categories[index1].sub_cats_count);
      this.GSHOP.categories[index1].sub_cats[this.GSHOP.categories[index1].sub_cats.Length - 1] = this.GSHOP.categories[selectedIndex1].sub_cats[selectedIndex2];
      for (int index2 = 0; index2 < this.GSHOP.items.Length; ++index2)
      {
        if (this.GSHOP.items[index2].cat_index != selectedIndex1 || this.GSHOP.items[index2].sub_cat_index != selectedIndex2)
          continue;
        this.GSHOP.items[index2].cat_index = index1;
        this.GSHOP.items[index2].sub_cat_index = subCatsCount;
      }
      this.click_deleteSubCat((object) null, (EventArgs) null);
      this.build_contextMenus();
    }
    else
    {
      int num = (int) MessageBox.Show("Target already has 8 SubCategories!");
    }
  }

  private void move_item(object sender, EventArgs e)
  {
    if (this.GSHOP == null || this.listBox_Items.SelectedIndex <= -1)
      return;
    int itemIdIndex = (int) this.item_id_index_map[(object) Convert.ToInt32(this.listBox_Items.SelectedItem.ToString().Substring(1, this.listBox_Items.SelectedItem.ToString().IndexOf("]") - 1))];
    for (int index = 0; index < this.toolStripMenuItem_moveItem.DropDownItems.Count; ++index)
    {
      if (((ToolStripDropDownItem) this.toolStripMenuItem_moveItem.DropDownItems[index]).DropDownItems.Contains((ToolStripItem) sender))
      {
        this.GSHOP.items[itemIdIndex].cat_index = index;
        this.GSHOP.items[itemIdIndex].sub_cat_index = ((ToolStripDropDownItem) this.toolStripMenuItem_moveItem.DropDownItems[index]).DropDownItems.IndexOf((ToolStripItem) sender);
        break;
      }
    }
    this.listBox_Items.Items.RemoveAt(this.listBox_Items.SelectedIndex);
  }

  private void rename_cat(object sender, EventArgs e)
  {
    if (this.listBox_Cats.SelectedIndex <= -1)
      return;
    Category category = this.GSHOP.categories[this.listBox_Cats.SelectedIndex];
    MainWindow mainWindow = this;
    byte[] bytes = mainWindow.string_to_bytes(mainWindow.textBox_Cat.Text, "Unicode", 128);
    category.name = bytes;
    this.listBox_Cats.Items[this.listBox_Cats.SelectedIndex] = (object) this.textBox_Cat.Text;
    this.build_contextMenus();
  }

  private void rename_subcat(object sender, EventArgs e)
  {
    if (this.listBox_Cats.SelectedIndex <= -1 || this.listBox_SubCats.SelectedIndex <= -1)
      return;
    byte[][] subCats = this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats;
    int selectedIndex = this.listBox_SubCats.SelectedIndex;
    MainWindow mainWindow = this;
    byte[] bytes = mainWindow.string_to_bytes(mainWindow.textBox_SubCat.Text, "Unicode", 128);
    subCats[selectedIndex] = bytes;
    this.listBox_SubCats.Items[this.listBox_SubCats.SelectedIndex] = (object) this.textBox_SubCat.Text;
    this.build_contextMenus();
  }

  private void edit_item(object sender, EventArgs e)
  {
    if (this.listBox_Items.SelectedIndex <= -1)
      return;
    int itemIdIndex = (int) this.item_id_index_map[(object) Convert.ToInt32(this.listBox_Items.SelectedItem.ToString().Substring(1, this.listBox_Items.SelectedItem.ToString().IndexOf("]") - 1))];
    if ((Control) sender == this.numericUpDown_itemID)
    {
      Decimal num = this.numericUpDown_itemID.Value;
      this.GSHOP.items[itemIdIndex].item_id = Convert.ToInt32(num);
    }
    if ((Control) sender == this.numericUpDown_amount)
    {
      Decimal num = this.numericUpDown_amount.Value;
      this.GSHOP.items[itemIdIndex].item_amount = Convert.ToInt32(num);
    }
    if ((Control) sender == this.textBox_name)
    {
      Item obj = this.GSHOP.items[itemIdIndex];
      MainWindow mainWindow = this;
      byte[] bytes = mainWindow.string_to_bytes(mainWindow.textBox_name.Text, "Unicode", 64);
      obj.name = bytes;
      this.listBox_Items.Items[this.listBox_Items.SelectedIndex] = (object) ("[" + (object) this.GSHOP.items[itemIdIndex].shop_id + "] " + this.textBox_name.Text);
    }
    if ((Control) sender == this.textBox_description)
    {
      Item obj = this.GSHOP.items[itemIdIndex];
      MainWindow mainWindow = this;
      byte[] bytes = mainWindow.string_to_bytes(mainWindow.textBox_description.Text, "Unicode", 1024);
      obj.description = bytes;
    }
    if ((Control) sender == this.comboBox_surface)
    {
      Item obj = this.GSHOP.items[itemIdIndex];
      MainWindow mainWindow = this;
      byte[] bytes = mainWindow.string_to_bytes(mainWindow.comboBox_surface.Text, "GBK", 128);
      obj.surface_path = bytes;
    }
    if ((Control) sender == this.comboBox_status)
      this.GSHOP.items[itemIdIndex].state = this.comboBox_status.SelectedIndex;
    if ((Control) sender == this.numericUpDown_priceA)
    {
      Decimal num = (Decimal) 100 * this.numericUpDown_priceA.Value;
      this.GSHOP.items[itemIdIndex].price1 = Convert.ToInt32(num);
    }
    if ((Control) sender == this.numericUpDown_valueA)
    {
      Decimal num = this.numericUpDown_valueA.Value;
      this.GSHOP.items[itemIdIndex].value1 = Convert.ToInt32(num);
    }
    if ((Control) sender == this.textBox_durationA)
    {
      Item obj = this.GSHOP.items[itemIdIndex];
      MainWindow mainWindow = this;
      int seconds = mainWindow.string_to_seconds(mainWindow.textBox_durationA.Text);
      obj.duration1 = seconds;
    }
    if ((Control) sender == this.numericUpDown_priceB)
    {
      Decimal num = (Decimal) 100 * this.numericUpDown_priceB.Value;
      this.GSHOP.items[itemIdIndex].price2 = Convert.ToInt32(num);
    }
    if ((Control) sender == this.numericUpDown_valueB)
    {
      Decimal num = this.numericUpDown_valueB.Value;
      this.GSHOP.items[itemIdIndex].value2 = Convert.ToInt32(num);
    }
    if ((Control) sender == this.textBox_durationB)
    {
      Item obj = this.GSHOP.items[itemIdIndex];
      MainWindow mainWindow = this;
      int seconds = mainWindow.string_to_seconds(mainWindow.textBox_durationB.Text);
      obj.duration2 = seconds;
    }
    if ((Control) sender == this.numericUpDown_priceC)
    {
      Decimal num = (Decimal) 100 * this.numericUpDown_priceC.Value;
      this.GSHOP.items[itemIdIndex].price3 = Convert.ToInt32(num);
    }
    if ((Control) sender == this.numericUpDown_valueC)
    {
      Decimal num = this.numericUpDown_valueC.Value;
      this.GSHOP.items[itemIdIndex].value3 = Convert.ToInt32(num);
    }
    if ((Control) sender == this.textBox_durationC)
    {
      Item obj = this.GSHOP.items[itemIdIndex];
      MainWindow mainWindow = this;
      int seconds = mainWindow.string_to_seconds(mainWindow.textBox_durationC.Text);
      obj.duration3 = seconds;
    }
    if ((Control) sender == this.numericUpDown_unknown1)
    {
      Decimal num = this.numericUpDown_unknown1.Value;
      this.GSHOP.items[itemIdIndex].unknown1 = Convert.ToInt32(num);
    }
    if ((Control) sender == this.numericUpDown_unknown2)
    {
      Decimal num = this.numericUpDown_unknown2.Value;
      this.GSHOP.items[itemIdIndex].unknown2 = Convert.ToInt32(num);
    }
    if ((Control) sender != this.numericUpDown_unknown3)
      return;
    Decimal num1 = this.numericUpDown_unknown3.Value;
    this.GSHOP.items[itemIdIndex].unknown3 = Convert.ToInt32(num1);
  }

  private unsafe void click_autoDetect(object sender, EventArgs e)
  {
    // ISSUE: untyped stack allocation
    int num1 = (int) __untypedstackalloc(\u003CModule\u003E.__CxxQueryExceptionSize() * 1);
    this.Cursor = Cursors.AppStarting;
    try
    {
      HttpWebRequest httpWebRequest1 = (HttpWebRequest) WebRequest.Create("http://www.pwdatabase.com/" + this.comboBox_dbSource.SelectedItem.ToString() + "/items/" + this.numericUpDown_itemID.Value.ToString());
      httpWebRequest1.Proxy = (IWebProxy) null;
      StreamReader streamReader1 = new StreamReader(((HttpWebResponse) httpWebRequest1.GetResponse()).GetResponseStream());
      string end1 = streamReader1.ReadToEnd();
      streamReader1.Close();
      int startIndex1 = end1.IndexOf("<th class=\"itemHeader\"") + 35;
      if (startIndex1 > 34)
      {
        int length = end1.IndexOf("<a href", startIndex1) - startIndex1;
        string str1 = end1.Substring(startIndex1, length);
        if (str1.Contains("<"))
        {
          string str2 = str1;
          string str3 = str2.Substring(str2.IndexOf(">") + 1);
          str1 = str3.Substring(0, str3.IndexOf("</"));
        }
        this.textBox_name.Text = str1.Replace("&#9734;", "★");
        MainWindow mainWindow = this;
        mainWindow.edit_item((object) mainWindow.textBox_name, (EventArgs) null);
      }
      int startIndex2 = end1.IndexOf("<a href=\"shopitem/", startIndex1) + 18;
      if (startIndex2 > 18)
      {
        int length1 = end1.IndexOf("\">", startIndex2) - startIndex2;
        HttpWebRequest httpWebRequest2 = (HttpWebRequest) WebRequest.Create("http://www.pwdatabase.com/" + this.comboBox_dbSource.SelectedItem.ToString() + "/shopitem/" + end1.Substring(startIndex2, length1));
        httpWebRequest2.Proxy = (IWebProxy) null;
        StreamReader streamReader2 = new StreamReader(((HttpWebResponse) httpWebRequest2.GetResponse()).GetResponseStream());
        string end2 = streamReader2.ReadToEnd();
        streamReader2.Close();
        int startIndex3 = end2.IndexOf("<h3>Description</h3><p>") + 23;
        if (startIndex3 > 22)
        {
          int length2 = end2.IndexOf("</p>", startIndex3) - startIndex3;
          this.textBox_description.Text = end2.Substring(startIndex3, length2).Replace("<span style='color:", "").Replace("#", "^").Replace(";", "").Replace("'>", "").Replace("<br />", "\\r").Replace("<br/>", "\\r").Replace("<br>", "\\r").Replace("</span>", "").Replace("\\r", " \\r");
        }
      }
      else
      {
        string itemDescription = (string) this.itemDescriptions[(object) this.numericUpDown_itemID.Value.ToString()];
        if (itemDescription != null)
          this.textBox_description.Text = itemDescription.Replace("\\r", " \\r");
      }
      MainWindow mainWindow1 = this;
      mainWindow1.edit_item((object) mainWindow1.textBox_description, (EventArgs) null);
    }
    catch (Exception ex1) when (
    {
      // ISSUE: unable to correctly present filter
      uint exceptionCode = (uint) Marshal.GetExceptionCode();
      if (\u003CModule\u003E.__CxxExceptionFilter((void*) Marshal.GetExceptionPointers(), (void*) 0, 0, (void*) 0) != 0)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      uint num2 = 0;
      \u003CModule\u003E.__CxxRegisterExceptionObject((void*) Marshal.GetExceptionPointers(), (void*) num1);
      try
      {
        try
        {
          int num3 = (int) MessageBox.Show("Connection Failed!");
          goto label_19;
        }
        catch (Exception ex2) when (
        {
          // ISSUE: unable to correctly present filter
          num2 = (uint) \u003CModule\u003E.__CxxDetectRethrow((void*) Marshal.GetExceptionPointers());
          if (num2 != 0U)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
        }
        if (num2 != 0U)
          throw;
      }
      finally
      {
        \u003CModule\u003E.__CxxUnregisterExceptionObject((void*) num1, (int) num2);
      }
    }
label_19:
    this.Cursor = Cursors.Default;
  }

  private void click_addSubCat(object sender, EventArgs e)
  {
    if (this.GSHOP == null || this.listBox_Cats.SelectedIndex <= -1)
      return;
    if (this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats.Length < 8)
    {
      ++this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats_count;
      Array.Resize<byte[]>(ref this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats, this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats_count);
      this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats[this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats.Length - 1] = this.string_to_bytes("New", "Unicode", 128);
      this.listBox_SubCats.Items.Add((object) "New");
      this.listBox_SubCats.SelectedIndex = this.listBox_SubCats.Items.Count - 1;
      this.build_contextMenus();
    }
    else
    {
      int num = (int) MessageBox.Show("Maximum of 8 reached!");
    }
  }

  private void click_deleteSubCat(object sender, EventArgs e)
  {
    if (this.GSHOP == null || this.listBox_Cats.SelectedIndex <= -1 || this.listBox_SubCats.SelectedIndex <= -1)
      return;
    --this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats_count;
    byte[][] numArray = new byte[this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats_count][];
    Array.Copy((Array) this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats, 0, (Array) numArray, 0, this.listBox_SubCats.SelectedIndex);
    Array.Copy((Array) this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats, this.listBox_SubCats.SelectedIndex + 1, (Array) numArray, this.listBox_SubCats.SelectedIndex, this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats_count - this.listBox_SubCats.SelectedIndex);
    this.GSHOP.categories[this.listBox_Cats.SelectedIndex].sub_cats = numArray;
    for (int index = 0; index < this.GSHOP.items.Length; ++index)
    {
      if (this.GSHOP.items[index].cat_index != this.listBox_Cats.SelectedIndex)
        continue;
      if (this.GSHOP.items[index].sub_cat_index == this.listBox_SubCats.SelectedIndex)
      {
        --this.GSHOP.item_count;
        this.GSHOP.items[index].cat_index = -1;
        this.GSHOP.items[index].sub_cat_index = -1;
        this.item_id_index_map.Remove((object) this.GSHOP.items[index].shop_id);
      }
      if (this.GSHOP.items[index].sub_cat_index > this.listBox_SubCats.SelectedIndex)
        --this.GSHOP.items[index].sub_cat_index;
    }
    this.listBox_SubCats.Items.RemoveAt(this.listBox_SubCats.SelectedIndex);
    this.listBox_Items.Items.Clear();
  }

  private void click_addItem(object sender, EventArgs e)
  {
    if (this.GSHOP == null || this.listBox_Cats.SelectedIndex <= -1 || this.listBox_SubCats.SelectedIndex <= -1)
      return;
    ++this.GSHOP.item_count;
    Array.Resize<Item>(ref this.GSHOP.items, this.GSHOP.items.Length + 1);
    this.GSHOP.items[this.GSHOP.items.Length - 1] = new Item();
    this.GSHOP.items[this.GSHOP.items.Length - 1].shop_id = this.max_item_id;
    this.GSHOP.items[this.GSHOP.items.Length - 1].cat_index = this.listBox_Cats.SelectedIndex;
    this.GSHOP.items[this.GSHOP.items.Length - 1].sub_cat_index = this.listBox_SubCats.SelectedIndex;
    this.GSHOP.items[this.GSHOP.items.Length - 1].surface_path = this.string_to_bytes("", "GBK", 128);
    this.GSHOP.items[this.GSHOP.items.Length - 1].item_id = 1;
    this.GSHOP.items[this.GSHOP.items.Length - 1].item_amount = 1;
    this.GSHOP.items[this.GSHOP.items.Length - 1].price1 = 1000;
    this.GSHOP.items[this.GSHOP.items.Length - 1].value1 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].duration1 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].price2 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].value2 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].duration2 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].price3 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].value3 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].duration3 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].unknown1 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].unknown2 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].unknown3 = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].state = 0;
    this.GSHOP.items[this.GSHOP.items.Length - 1].description = this.string_to_bytes("", "Unicode", 1024);
    this.GSHOP.items[this.GSHOP.items.Length - 1].name = this.string_to_bytes("New", "Unicode", 64);
    this.item_id_index_map.Add((object) this.max_item_id, (object) (this.GSHOP.items.Length - 1));
    this.listBox_Items.Items.Add((object) ("[" + (object) this.max_item_id + "] New"));
    this.listBox_Items.SelectedIndex = this.listBox_Items.Items.Count - 1;
    ++this.max_item_id;
  }

  private void click_deleteItem(object sender, EventArgs e)
  {
    if (this.GSHOP == null || this.listBox_Items.SelectedIndex <= -1)
      return;
    int itemIdIndex = (int) this.item_id_index_map[(object) Convert.ToInt32(this.listBox_Items.SelectedItem.ToString().Substring(1, this.listBox_Items.SelectedItem.ToString().IndexOf("]") - 1))];
    --this.GSHOP.item_count;
    this.GSHOP.items[itemIdIndex].cat_index = -1;
    this.GSHOP.items[itemIdIndex].sub_cat_index = -1;
    this.item_id_index_map.Remove((object) this.GSHOP.items[itemIdIndex].shop_id);
    this.listBox_Items.Items.RemoveAt(this.listBox_Items.SelectedIndex);
  }

  private void load_surface(object sender, EventArgs e)
  {
    string str1 = Application.StartupPath + "\\" + this.comboBox_surface.Text.Replace(".dds", ".jpg");
    string str2 = str1.Substring(0, str1.LastIndexOf("\\"));
    string str3 = str1;
    string str4 = str3.Substring(str3.LastIndexOf("\\") + 1);
    this.pictureBox_surface.Image = str2.IndexOfAny(Path.GetInvalidPathChars()) >= 0 || str4.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0 || !System.IO.File.Exists(str1) ? (Image) new Bitmap(128, 128) : Image.FromFile(str1);
    GC.Collect();
  }

  private void click_home(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Process.Start("http://sgshopedit.codeplex.com");
  }

  private void click_exit(object sender, EventArgs e)
  {
    this.Close();
  }

  private void keyPress_search(object sender, KeyPressEventArgs e)
  {
    if (e.KeyChar != '\r')
      return;
    this.click_search((object) null, (EventArgs) null);
  }

  private void click_search(object sender, EventArgs e)
  {
    if (this.GSHOP == null)
      return;
    int num1 = 0;
    if (this.listBox_Items.SelectedIndex > -1)
      num1 = (int) this.item_id_index_map[(object) Convert.ToInt32(this.listBox_Items.SelectedItem.ToString().Substring(1, this.listBox_Items.SelectedItem.ToString().IndexOf("]") - 1))] + 1;
    for (int index = num1; index < this.GSHOP.items.Length; ++index)
    {
      if (this.GSHOP.items[index].cat_index <= -1 || this.GSHOP.items[index].sub_cat_index <= -1)
        continue;
      if (!(this.textBox_search.Text == this.GSHOP.items[index].item_id.ToString()))
      {
        MainWindow mainWindow = this;
        if (!mainWindow.bytes_to_string(mainWindow.GSHOP.items[index].name, "Unicode").Contains(this.textBox_search.Text))
          continue;
      }
      this.listBox_Cats.SelectedIndex = this.GSHOP.items[index].cat_index;
      this.listBox_SubCats.SelectedIndex = this.GSHOP.items[index].sub_cat_index;
      int shopId = this.GSHOP.items[index].shop_id;
      ListBox listBoxItems = this.listBox_Items;
      ListBox.ObjectCollection items = this.listBox_Items.Items;
      string str1 = "[" + shopId.ToString() + "] ";
      MainWindow mainWindow1 = this;
      string str2 = mainWindow1.bytes_to_string(mainWindow1.GSHOP.items[index].name, "Unicode");
      string str3 = str1 + str2;
      int num2 = items.IndexOf((object) str3);
      listBoxItems.SelectedIndex = num2;
      return;
    }
    int num3 = (int) MessageBox.Show("Search reached end of List without result");
  }

  protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
  {
    if (_param1)
    {
      try
      {
        this.\u007EMainWindow();
      }
      finally
      {
        base.Dispose(true);
      }
    }
    else
      base.Dispose(false);
  }
}
