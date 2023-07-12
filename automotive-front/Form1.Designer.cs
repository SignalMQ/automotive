namespace automotive_front
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
            tabPage2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            dataGridView3 = new DataGridView();
            IsStarted = new DataGridViewTextBoxColumn();
            FuelLevel = new DataGridViewTextBoxColumn();
            PowerLevel = new DataGridViewTextBoxColumn();
            AntiFreezeLevel = new DataGridViewTextBoxColumn();
            OilLevel = new DataGridViewTextBoxColumn();
            TransmissionOilLevel = new DataGridViewTextBoxColumn();
            BrakeFluidLevel = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            EnginePower = new DataGridViewTextBoxColumn();
            EngineModel = new DataGridViewTextBoxColumn();
            EngineFuel = new DataGridViewTextBoxColumn();
            EngineConsumption = new DataGridViewTextBoxColumn();
            EngineCilindersCount = new DataGridViewTextBoxColumn();
            EngineCapacity = new DataGridViewTextBoxColumn();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            CarPosition = new DataGridViewTextBoxColumn();
            TransportName = new DataGridViewTextBoxColumn();
            TransportModel = new DataGridViewTextBoxColumn();
            TransportYear = new DataGridViewTextBoxColumn();
            TransportMileage = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            dataGridView4 = new DataGridView();
            ChassisMaterial = new DataGridViewTextBoxColumn();
            ChassisWheelCount = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            dataGridView5 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView6 = new DataGridView();
            WheelMaterialType = new DataGridViewTextBoxColumn();
            WheelDiameter = new DataGridViewTextBoxColumn();
            Height = new DataGridViewTextBoxColumn();
            Width = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1000, 509);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Engine";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(994, 503);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(988, 246);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "EngineState";
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { IsStarted, FuelLevel, PowerLevel, AntiFreezeLevel, OilLevel, TransmissionOilLevel, BrakeFluidLevel });
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 19);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(982, 224);
            dataGridView3.TabIndex = 5;
            // 
            // IsStarted
            // 
            IsStarted.DataPropertyName = "IsStarted";
            IsStarted.HeaderText = "IsStarted";
            IsStarted.Name = "IsStarted";
            // 
            // FuelLevel
            // 
            FuelLevel.DataPropertyName = "FuelLevel";
            FuelLevel.HeaderText = "FuelLevel";
            FuelLevel.Name = "FuelLevel";
            // 
            // PowerLevel
            // 
            PowerLevel.DataPropertyName = "PowerLevel";
            PowerLevel.HeaderText = "PowerLevel";
            PowerLevel.Name = "PowerLevel";
            // 
            // AntiFreezeLevel
            // 
            AntiFreezeLevel.DataPropertyName = "AntiFreezeLevel";
            AntiFreezeLevel.HeaderText = "AntiFreezeLevel";
            AntiFreezeLevel.Name = "AntiFreezeLevel";
            // 
            // OilLevel
            // 
            OilLevel.DataPropertyName = "OilLevel";
            OilLevel.HeaderText = "OilLevel";
            OilLevel.Name = "OilLevel";
            // 
            // TransmissionOilLevel
            // 
            TransmissionOilLevel.DataPropertyName = "TransmissionOilLevel";
            TransmissionOilLevel.HeaderText = "TransmissionOilLevel";
            TransmissionOilLevel.Name = "TransmissionOilLevel";
            // 
            // BrakeFluidLevel
            // 
            BrakeFluidLevel.DataPropertyName = "BrakeFluidLevel";
            BrakeFluidLevel.HeaderText = "BrakeFluidLevel";
            BrakeFluidLevel.Name = "BrakeFluidLevel";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(988, 245);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "EngineInfo";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { EnginePower, EngineModel, EngineFuel, EngineConsumption, EngineCilindersCount, EngineCapacity });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(982, 223);
            dataGridView2.TabIndex = 3;
            // 
            // EnginePower
            // 
            EnginePower.DataPropertyName = "EnginePower";
            EnginePower.HeaderText = "EnginePower";
            EnginePower.Name = "EnginePower";
            // 
            // EngineModel
            // 
            EngineModel.DataPropertyName = "EngineModel";
            EngineModel.HeaderText = "EngineModel";
            EngineModel.Name = "EngineModel";
            // 
            // EngineFuel
            // 
            EngineFuel.DataPropertyName = "EngineFuel";
            EngineFuel.HeaderText = "EngineFuel";
            EngineFuel.Name = "EngineFuel";
            // 
            // EngineConsumption
            // 
            EngineConsumption.DataPropertyName = "EngineConsumption";
            EngineConsumption.HeaderText = "EngineConsumption";
            EngineConsumption.Name = "EngineConsumption";
            // 
            // EngineCilindersCount
            // 
            EngineCilindersCount.DataPropertyName = "EngineCilindersCount";
            EngineCilindersCount.HeaderText = "EngineCilindersCount";
            EngineCilindersCount.Name = "EngineCilindersCount";
            // 
            // EngineCapacity
            // 
            EngineCapacity.DataPropertyName = "EngineCapacity";
            EngineCapacity.HeaderText = "EngineCapacity";
            EngineCapacity.Name = "EngineCapacity";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1000, 509);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "TransportInfo";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CarPosition, TransportName, TransportModel, TransportYear, TransportMileage });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(994, 503);
            dataGridView1.TabIndex = 1;
            // 
            // CarPosition
            // 
            CarPosition.DataPropertyName = "CarPosition";
            CarPosition.HeaderText = "CarPosition";
            CarPosition.Name = "CarPosition";
            // 
            // TransportName
            // 
            TransportName.DataPropertyName = "TransportName";
            TransportName.HeaderText = "TransportName";
            TransportName.Name = "TransportName";
            // 
            // TransportModel
            // 
            TransportModel.DataPropertyName = "TransportModel";
            TransportModel.HeaderText = "TransportModel";
            TransportModel.Name = "TransportModel";
            // 
            // TransportYear
            // 
            TransportYear.DataPropertyName = "TransportYear";
            TransportYear.HeaderText = "TransportYear";
            TransportYear.Name = "TransportYear";
            // 
            // TransportMileage
            // 
            TransportMileage.DataPropertyName = "TransportMileage";
            TransportMileage.HeaderText = "TransportMileage";
            TransportMileage.Name = "TransportMileage";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1008, 537);
            tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1000, 509);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Misc";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox5, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(994, 503);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView4);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(491, 245);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chassis";
            // 
            // dataGridView4
            // 
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { ChassisMaterial, ChassisWheelCount });
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(3, 19);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(485, 223);
            dataGridView4.TabIndex = 0;
            // 
            // ChassisMaterial
            // 
            ChassisMaterial.DataPropertyName = "ChassisMaterial";
            ChassisMaterial.HeaderText = "ChassisMaterial";
            ChassisMaterial.Name = "ChassisMaterial";
            // 
            // ChassisWheelCount
            // 
            ChassisWheelCount.DataPropertyName = "ChassisWheelCount";
            ChassisWheelCount.HeaderText = "ChassisWheelCount";
            ChassisWheelCount.Name = "ChassisWheelCount";
            // 
            // groupBox4
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox4, 2);
            groupBox4.Controls.Add(dataGridView5);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 254);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(988, 246);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Body";
            // 
            // dataGridView5
            // 
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { Height, Width, Color, Material });
            dataGridView5.Dock = DockStyle.Fill;
            dataGridView5.Location = new Point(3, 19);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new Size(982, 224);
            dataGridView5.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView6);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(500, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(491, 245);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Wheel";
            // 
            // dataGridView6
            // 
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Columns.AddRange(new DataGridViewColumn[] { WheelMaterialType, WheelDiameter });
            dataGridView6.Dock = DockStyle.Fill;
            dataGridView6.Location = new Point(3, 19);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowTemplate.Height = 25;
            dataGridView6.Size = new Size(485, 223);
            dataGridView6.TabIndex = 0;
            // 
            // WheelMaterialType
            // 
            WheelMaterialType.DataPropertyName = "WheelMaterialType";
            WheelMaterialType.HeaderText = "WheelMaterialType";
            WheelMaterialType.Name = "WheelMaterialType";
            // 
            // WheelDiameter
            // 
            WheelDiameter.DataPropertyName = "WheelDiameter";
            WheelDiameter.HeaderText = "WheelDiameter";
            WheelDiameter.Name = "WheelDiameter";
            // 
            // Height
            // 
            Height.DataPropertyName = "Height";
            Height.HeaderText = "Height";
            Height.Name = "Height";
            // 
            // Width
            // 
            Width.DataPropertyName = "Width";
            Width.HeaderText = "Width";
            Width.Name = "Width";
            // 
            // Color
            // 
            Color.DataPropertyName = "Color";
            Color.HeaderText = "Color";
            Color.Name = "Color";
            // 
            // Material
            // 
            Material.DataPropertyName = "Material";
            Material.HeaderText = "Material";
            Material.Name = "Material";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 537);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn IsStarted;
        private DataGridViewTextBoxColumn FuelLevel;
        private DataGridViewTextBoxColumn PowerLevel;
        private DataGridViewTextBoxColumn AntiFreezeLevel;
        private DataGridViewTextBoxColumn OilLevel;
        private DataGridViewTextBoxColumn TransmissionOilLevel;
        private DataGridViewTextBoxColumn BrakeFluidLevel;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn EnginePower;
        private DataGridViewTextBoxColumn EngineModel;
        private DataGridViewTextBoxColumn EngineFuel;
        private DataGridViewTextBoxColumn EngineConsumption;
        private DataGridViewTextBoxColumn EngineCilindersCount;
        private DataGridViewTextBoxColumn EngineCapacity;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CarPosition;
        private DataGridViewTextBoxColumn TransportName;
        private DataGridViewTextBoxColumn TransportModel;
        private DataGridViewTextBoxColumn TransportYear;
        private DataGridViewTextBoxColumn TransportMileage;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox3;
        private DataGridView dataGridView4;
        private GroupBox groupBox4;
        private DataGridView dataGridView5;
        private GroupBox groupBox5;
        private DataGridView dataGridView6;
        private DataGridViewTextBoxColumn ChassisMaterial;
        private DataGridViewTextBoxColumn ChassisWheelCount;
        private DataGridViewTextBoxColumn WheelMaterialType;
        private DataGridViewTextBoxColumn WheelDiameter;
        private DataGridViewTextBoxColumn Height;
        private DataGridViewTextBoxColumn Width;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn Material;
    }
}