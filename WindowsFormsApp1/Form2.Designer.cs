namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this._13пршербдDataSet = new WindowsFormsApp1._13пршербдDataSet();
            this.бригада_поездовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бригада_поездовTableAdapter = new WindowsFormsApp1._13пршербдDataSetTableAdapters.Бригада_поездовTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1._13пршербдDataSetTableAdapters.TableAdapterManager();
            this.ведомость_продажи_билетовTableAdapter = new WindowsFormsApp1._13пршербдDataSetTableAdapters.Ведомость_продажи_билетовTableAdapter();
            this.поездаTableAdapter = new WindowsFormsApp1._13пршербдDataSetTableAdapters.ПоездаTableAdapter();
            this.работникиTableAdapter = new WindowsFormsApp1._13пршербдDataSetTableAdapters.РаботникиTableAdapter();
            this.расписание_движения_поездовTableAdapter = new WindowsFormsApp1._13пршербдDataSetTableAdapters.Расписание_движения_поездовTableAdapter();
            this.бригада_поездовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.бригада_поездовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.бригада_поездовDataGridView = new System.Windows.Forms.DataGridView();
            this.номерБригадыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПоездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.машинистDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.техникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проводникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обсуживающийПерсоналDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ведомость_продажи_билетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ведомость_продажи_билетовDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поездаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поездаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.работникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расписание_движения_поездовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписание_движения_поездовDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расписание_движения_поездовTableAdapter1 = new WindowsFormsApp1._13пршербдDataSetTableAdapters.Расписание_движения_поездовTableAdapter();
            this.работникиTableAdapter1 = new WindowsFormsApp1._13пршербдDataSetTableAdapters.РаботникиTableAdapter();
            this.поездаTableAdapter1 = new WindowsFormsApp1._13пршербдDataSetTableAdapters.ПоездаTableAdapter();
            this.ведомость_продажи_билетовTableAdapter1 = new WindowsFormsApp1._13пршербдDataSetTableAdapters.Ведомость_продажи_билетовTableAdapter();
            this.бригада_поездовTableAdapter1 = new WindowsFormsApp1._13пршербдDataSetTableAdapters.Бригада_поездовTableAdapter();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._13пршербдDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бригада_поездовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бригада_поездовBindingNavigator)).BeginInit();
            this.бригада_поездовBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.бригада_поездовDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомость_продажи_билетовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомость_продажи_билетовDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписание_движения_поездовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписание_движения_поездовDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблицы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Бригада поездов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ведомость продажи билетов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Работники";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Поезда";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(265, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Расписание движения поездов";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(265, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Выход";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\andre\\Downloads\\13пршербд." +
    "accdb";
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // _13пршербдDataSet
            // 
            this._13пршербдDataSet.DataSetName = "_13пршербдDataSet";
            this._13пршербдDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бригада_поездовBindingSource
            // 
            this.бригада_поездовBindingSource.DataMember = "Бригада_поездов";
            this.бригада_поездовBindingSource.DataSource = this._13пршербдDataSet;
            // 
            // бригада_поездовTableAdapter
            // 
            this.бригада_поездовTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1._13пршербдDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Бригада_поездовTableAdapter = this.бригада_поездовTableAdapter;
            this.tableAdapterManager.Ведомость_продажи_билетовTableAdapter = this.ведомость_продажи_билетовTableAdapter;
            this.tableAdapterManager.ПоездаTableAdapter = this.поездаTableAdapter;
            this.tableAdapterManager.РаботникиTableAdapter = this.работникиTableAdapter;
            this.tableAdapterManager.Расписание_движения_поездовTableAdapter = this.расписание_движения_поездовTableAdapter;
            // 
            // ведомость_продажи_билетовTableAdapter
            // 
            this.ведомость_продажи_билетовTableAdapter.ClearBeforeFill = true;
            // 
            // поездаTableAdapter
            // 
            this.поездаTableAdapter.ClearBeforeFill = true;
            // 
            // работникиTableAdapter
            // 
            this.работникиTableAdapter.ClearBeforeFill = true;
            // 
            // расписание_движения_поездовTableAdapter
            // 
            this.расписание_движения_поездовTableAdapter.ClearBeforeFill = true;
            // 
            // бригада_поездовBindingNavigator
            // 
            this.бригада_поездовBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.бригада_поездовBindingNavigator.BindingSource = this.бригада_поездовBindingSource;
            this.бригада_поездовBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.бригада_поездовBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.бригада_поездовBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.бригада_поездовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.бригада_поездовBindingNavigatorSaveItem});
            this.бригада_поездовBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.бригада_поездовBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.бригада_поездовBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.бригада_поездовBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.бригада_поездовBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.бригада_поездовBindingNavigator.Name = "бригада_поездовBindingNavigator";
            this.бригада_поездовBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.бригада_поездовBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.бригада_поездовBindingNavigator.TabIndex = 8;
            this.бригада_поездовBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // бригада_поездовBindingNavigatorSaveItem
            // 
            this.бригада_поездовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.бригада_поездовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("бригада_поездовBindingNavigatorSaveItem.Image")));
            this.бригада_поездовBindingNavigatorSaveItem.Name = "бригада_поездовBindingNavigatorSaveItem";
            this.бригада_поездовBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.бригада_поездовBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.бригада_поездовBindingNavigatorSaveItem.Click += new System.EventHandler(this.бригада_поездовBindingNavigatorSaveItem_Click);
            // 
            // бригада_поездовDataGridView
            // 
            this.бригада_поездовDataGridView.AutoGenerateColumns = false;
            this.бригада_поездовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.бригада_поездовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерБригадыDataGridViewTextBoxColumn,
            this.номерПоездаDataGridViewTextBoxColumn,
            this.машинистDataGridViewTextBoxColumn,
            this.техникDataGridViewTextBoxColumn,
            this.проводникDataGridViewTextBoxColumn,
            this.обсуживающийПерсоналDataGridViewTextBoxColumn});
            this.бригада_поездовDataGridView.DataSource = this.бригада_поездовBindingSource;
            this.бригада_поездовDataGridView.Location = new System.Drawing.Point(96, 316);
            this.бригада_поездовDataGridView.Name = "бригада_поездовDataGridView";
            this.бригада_поездовDataGridView.RowHeadersWidth = 51;
            this.бригада_поездовDataGridView.RowTemplate.Height = 24;
            this.бригада_поездовDataGridView.Size = new System.Drawing.Size(677, 220);
            this.бригада_поездовDataGridView.TabIndex = 9;
            this.бригада_поездовDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.бригада_поездовDataGridView_CellContentClick);
            // 
            // номерБригадыDataGridViewTextBoxColumn
            // 
            this.номерБригадыDataGridViewTextBoxColumn.DataPropertyName = "Номер бригады";
            this.номерБригадыDataGridViewTextBoxColumn.HeaderText = "Номер бригады";
            this.номерБригадыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерБригадыDataGridViewTextBoxColumn.Name = "номерБригадыDataGridViewTextBoxColumn";
            this.номерБригадыDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерПоездаDataGridViewTextBoxColumn
            // 
            this.номерПоездаDataGridViewTextBoxColumn.DataPropertyName = "Номер поезда";
            this.номерПоездаDataGridViewTextBoxColumn.HeaderText = "Номер поезда";
            this.номерПоездаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерПоездаDataGridViewTextBoxColumn.Name = "номерПоездаDataGridViewTextBoxColumn";
            this.номерПоездаDataGridViewTextBoxColumn.Width = 125;
            // 
            // машинистDataGridViewTextBoxColumn
            // 
            this.машинистDataGridViewTextBoxColumn.DataPropertyName = "Машинист";
            this.машинистDataGridViewTextBoxColumn.HeaderText = "Машинист";
            this.машинистDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.машинистDataGridViewTextBoxColumn.Name = "машинистDataGridViewTextBoxColumn";
            this.машинистDataGridViewTextBoxColumn.Width = 125;
            // 
            // техникDataGridViewTextBoxColumn
            // 
            this.техникDataGridViewTextBoxColumn.DataPropertyName = "Техник";
            this.техникDataGridViewTextBoxColumn.HeaderText = "Техник";
            this.техникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.техникDataGridViewTextBoxColumn.Name = "техникDataGridViewTextBoxColumn";
            this.техникDataGridViewTextBoxColumn.Width = 125;
            // 
            // проводникDataGridViewTextBoxColumn
            // 
            this.проводникDataGridViewTextBoxColumn.DataPropertyName = "Проводник";
            this.проводникDataGridViewTextBoxColumn.HeaderText = "Проводник";
            this.проводникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.проводникDataGridViewTextBoxColumn.Name = "проводникDataGridViewTextBoxColumn";
            this.проводникDataGridViewTextBoxColumn.Width = 125;
            // 
            // обсуживающийПерсоналDataGridViewTextBoxColumn
            // 
            this.обсуживающийПерсоналDataGridViewTextBoxColumn.DataPropertyName = "Обсуживающий персонал";
            this.обсуживающийПерсоналDataGridViewTextBoxColumn.HeaderText = "Обсуживающий персонал";
            this.обсуживающийПерсоналDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.обсуживающийПерсоналDataGridViewTextBoxColumn.Name = "обсуживающийПерсоналDataGridViewTextBoxColumn";
            this.обсуживающийПерсоналDataGridViewTextBoxColumn.Width = 125;
            // 
            // ведомость_продажи_билетовBindingSource
            // 
            this.ведомость_продажи_билетовBindingSource.DataMember = "Ведомость_продажи_билетов";
            this.ведомость_продажи_билетовBindingSource.DataSource = this._13пршербдDataSet;
            // 
            // ведомость_продажи_билетовDataGridView
            // 
            this.ведомость_продажи_билетовDataGridView.AutoGenerateColumns = false;
            this.ведомость_продажи_билетовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ведомость_продажи_билетовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.ведомость_продажи_билетовDataGridView.DataSource = this.ведомость_продажи_билетовBindingSource;
            this.ведомость_продажи_билетовDataGridView.Location = new System.Drawing.Point(96, 316);
            this.ведомость_продажи_билетовDataGridView.Name = "ведомость_продажи_билетовDataGridView";
            this.ведомость_продажи_билетовDataGridView.RowHeadersWidth = 51;
            this.ведомость_продажи_билетовDataGridView.RowTemplate.Height = 24;
            this.ведомость_продажи_билетовDataGridView.Size = new System.Drawing.Size(677, 220);
            this.ведомость_продажи_билетовDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата продажи";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата продажи";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Время продажи";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время продажи";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn4.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn5.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn6.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Паспортные данные";
            this.dataGridViewTextBoxColumn7.HeaderText = "Паспортные данные";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Номер рейса";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер рейса";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Кол-во билетов";
            this.dataGridViewTextBoxColumn9.HeaderText = "Кол-во билетов";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Наличие льгот";
            this.dataGridViewTextBoxColumn10.HeaderText = "Наличие льгот";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn11.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // поездаBindingSource
            // 
            this.поездаBindingSource.DataMember = "Поезда";
            this.поездаBindingSource.DataSource = this._13пршербдDataSet;
            // 
            // поездаDataGridView
            // 
            this.поездаDataGridView.AutoGenerateColumns = false;
            this.поездаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поездаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.поездаDataGridView.DataSource = this.поездаBindingSource;
            this.поездаDataGridView.Location = new System.Drawing.Point(96, 316);
            this.поездаDataGridView.Name = "поездаDataGridView";
            this.поездаDataGridView.RowHeadersWidth = 51;
            this.поездаDataGridView.RowTemplate.Height = 24;
            this.поездаDataGridView.Size = new System.Drawing.Size(625, 220);
            this.поездаDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn12.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Год выпуска";
            this.dataGridViewTextBoxColumn13.HeaderText = "Год выпуска";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Кол-во вагонов";
            this.dataGridViewTextBoxColumn14.HeaderText = "Кол-во вагонов";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Тип поезда";
            this.dataGridViewTextBoxColumn15.HeaderText = "Тип поезда";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // работникиBindingSource
            // 
            this.работникиBindingSource.DataMember = "Работники";
            this.работникиBindingSource.DataSource = this._13пршербдDataSet;
            // 
            // работникиDataGridView
            // 
            this.работникиDataGridView.AutoGenerateColumns = false;
            this.работникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.работникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27});
            this.работникиDataGridView.DataSource = this.работникиBindingSource;
            this.работникиDataGridView.Location = new System.Drawing.Point(96, 316);
            this.работникиDataGridView.Name = "работникиDataGridView";
            this.работникиDataGridView.RowHeadersWidth = 51;
            this.работникиDataGridView.RowTemplate.Height = 24;
            this.работникиDataGridView.Size = new System.Drawing.Size(677, 220);
            this.работникиDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Код работника";
            this.dataGridViewTextBoxColumn16.HeaderText = "Код работника";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn17.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn18.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn19.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Год рождения";
            this.dataGridViewTextBoxColumn20.HeaderText = "Год рождения";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Год поступления на работу";
            this.dataGridViewTextBoxColumn21.HeaderText = "Год поступления на работу";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn22.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn23.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn24.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Город";
            this.dataGridViewTextBoxColumn25.HeaderText = "Город";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 125;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn26.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Стаж";
            this.dataGridViewTextBoxColumn27.HeaderText = "Стаж";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 125;
            // 
            // расписание_движения_поездовBindingSource
            // 
            this.расписание_движения_поездовBindingSource.DataMember = "Расписание_движения_поездов";
            this.расписание_движения_поездовBindingSource.DataSource = this._13пршербдDataSet;
            // 
            // расписание_движения_поездовDataGridView
            // 
            this.расписание_движения_поездовDataGridView.AutoGenerateColumns = false;
            this.расписание_движения_поездовDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.расписание_движения_поездовDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37});
            this.расписание_движения_поездовDataGridView.DataSource = this.расписание_движения_поездовBindingSource;
            this.расписание_движения_поездовDataGridView.Location = new System.Drawing.Point(96, 316);
            this.расписание_движения_поездовDataGridView.Name = "расписание_движения_поездовDataGridView";
            this.расписание_движения_поездовDataGridView.RowHeadersWidth = 51;
            this.расписание_движения_поездовDataGridView.RowTemplate.Height = 24;
            this.расписание_движения_поездовDataGridView.Size = new System.Drawing.Size(677, 220);
            this.расписание_движения_поездовDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Номер рейса";
            this.dataGridViewTextBoxColumn28.HeaderText = "Номер рейса";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 125;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Номер поезда";
            this.dataGridViewTextBoxColumn29.HeaderText = "Номер поезда";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 125;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Дата отправления";
            this.dataGridViewTextBoxColumn30.HeaderText = "Дата отправления";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 125;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Время отправления";
            this.dataGridViewTextBoxColumn31.HeaderText = "Время отправления";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 125;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Место отправления";
            this.dataGridViewTextBoxColumn32.HeaderText = "Место отправления";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 125;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Дата прибытия";
            this.dataGridViewTextBoxColumn33.HeaderText = "Дата прибытия";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 125;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Время прибытия";
            this.dataGridViewTextBoxColumn34.HeaderText = "Время прибытия";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 125;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Место прибытия";
            this.dataGridViewTextBoxColumn35.HeaderText = "Место прибытия";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Width = 125;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Маршрут";
            this.dataGridViewTextBoxColumn36.HeaderText = "Маршрут";
            this.dataGridViewTextBoxColumn36.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Width = 125;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Стоимость билета";
            this.dataGridViewTextBoxColumn37.HeaderText = "Стоимость билета";
            this.dataGridViewTextBoxColumn37.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Width = 125;
            // 
            // расписание_движения_поездовTableAdapter1
            // 
            this.расписание_движения_поездовTableAdapter1.ClearBeforeFill = true;
            // 
            // работникиTableAdapter1
            // 
            this.работникиTableAdapter1.ClearBeforeFill = true;
            // 
            // поездаTableAdapter1
            // 
            this.поездаTableAdapter1.ClearBeforeFill = true;
            // 
            // ведомость_продажи_билетовTableAdapter1
            // 
            this.ведомость_продажи_билетовTableAdapter1.ClearBeforeFill = true;
            // 
            // бригада_поездовTableAdapter1
            // 
            this.бригада_поездовTableAdapter1.ClearBeforeFill = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(306, 229);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(265, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Расписание движения поездов";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(306, 200);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(265, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Работники";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(306, 171);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(265, 23);
            this.button10.TabIndex = 15;
            this.button10.Text = "Поезда";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(306, 142);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(265, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "Ведомость продажи билетов";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(306, 113);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(265, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "Бригада поездов";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Изменение таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Открытие таблицы";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(605, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 58);
            this.button7.TabIndex = 21;
            this.button7.Text = "Сортировка и фильтрация";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(659, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(659, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Сортировка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Фильтрация";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.расписание_движения_поездовDataGridView);
            this.Controls.Add(this.работникиDataGridView);
            this.Controls.Add(this.поездаDataGridView);
            this.Controls.Add(this.ведомость_продажи_билетовDataGridView);
            this.Controls.Add(this.бригада_поездовDataGridView);
            this.Controls.Add(this.бригада_поездовBindingNavigator);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._13пршербдDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бригада_поездовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бригада_поездовBindingNavigator)).EndInit();
            this.бригада_поездовBindingNavigator.ResumeLayout(false);
            this.бригада_поездовBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.бригада_поездовDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомость_продажи_билетовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомость_продажи_билетовDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписание_движения_поездовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписание_движения_поездовDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private _13пршербдDataSet _13пршербдDataSet;
        private System.Windows.Forms.BindingSource бригада_поездовBindingSource;
        private _13пршербдDataSetTableAdapters.Бригада_поездовTableAdapter бригада_поездовTableAdapter;
        private _13пршербдDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator бригада_поездовBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton бригада_поездовBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView бригада_поездовDataGridView;
        private _13пршербдDataSetTableAdapters.Ведомость_продажи_билетовTableAdapter ведомость_продажи_билетовTableAdapter;
        private System.Windows.Forms.BindingSource ведомость_продажи_билетовBindingSource;
        private _13пршербдDataSetTableAdapters.ПоездаTableAdapter поездаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерБригадыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПоездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn машинистDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn техникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn проводникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обсуживающийПерсоналDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ведомость_продажи_билетовDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource поездаBindingSource;
        private _13пршербдDataSetTableAdapters.РаботникиTableAdapter работникиTableAdapter;
        private System.Windows.Forms.DataGridView поездаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.BindingSource работникиBindingSource;
        private _13пршербдDataSetTableAdapters.Расписание_движения_поездовTableAdapter расписание_движения_поездовTableAdapter;
        private System.Windows.Forms.DataGridView работникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.BindingSource расписание_движения_поездовBindingSource;
        private System.Windows.Forms.DataGridView расписание_движения_поездовDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private _13пршербдDataSetTableAdapters.Расписание_движения_поездовTableAdapter расписание_движения_поездовTableAdapter1;
        private _13пршербдDataSetTableAdapters.РаботникиTableAdapter работникиTableAdapter1;
        private _13пршербдDataSetTableAdapters.ПоездаTableAdapter поездаTableAdapter1;
        private _13пршербдDataSetTableAdapters.Ведомость_продажи_билетовTableAdapter ведомость_продажи_билетовTableAdapter1;
        private _13пршербдDataSetTableAdapters.Бригада_поездовTableAdapter бригада_поездовTableAdapter1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}