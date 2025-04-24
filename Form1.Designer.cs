namespace MaterialEstimator
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
            clearButton = new Button();
            saveButton = new Button();
            calculateButton = new Button();
            buttonsLayoutPanel = new TableLayoutPanel();
            loadButton = new Button();
            dataGridViewMaterials = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            itemLabel = new Label();
            itemBox = new TextBox();
            quantityBox = new TextBox();
            unitCostBox = new TextBox();
            categoryBox = new ComboBox();
            categoryLabel = new Label();
            quantityLabel = new Label();
            unitCostLabel = new Label();
            addItemButton = new Button();
            categoryColumn = new DataGridViewTextBoxColumn();
            itemColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            unitCostColumn = new DataGridViewTextBoxColumn();
            totalCostColumn = new DataGridViewTextBoxColumn();
            buttonsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterials).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearButton.BackColor = SystemColors.ActiveCaption;
            clearButton.Location = new Point(3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveButton.BackColor = SystemColors.ActiveCaption;
            saveButton.Location = new Point(84, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // calculateButton
            // 
            calculateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            calculateButton.BackColor = SystemColors.ActiveCaption;
            calculateButton.Location = new Point(463, 3);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(69, 24);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // buttonsLayoutPanel
            // 
            buttonsLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonsLayoutPanel.ColumnCount = 4;
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            buttonsLayoutPanel.Controls.Add(loadButton, 2, 0);
            buttonsLayoutPanel.Controls.Add(calculateButton, 3, 0);
            buttonsLayoutPanel.Controls.Add(clearButton, 0, 0);
            buttonsLayoutPanel.Controls.Add(saveButton, 1, 0);
            buttonsLayoutPanel.Location = new Point(12, 451);
            buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            buttonsLayoutPanel.RowCount = 1;
            buttonsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonsLayoutPanel.Size = new Size(535, 30);
            buttonsLayoutPanel.TabIndex = 4;
            // 
            // loadButton
            // 
            loadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            loadButton.BackColor = SystemColors.ActiveCaption;
            loadButton.Location = new Point(165, 4);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 3;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // dataGridViewMaterials
            // 
            dataGridViewMaterials.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMaterials.BackgroundColor = SystemColors.ControlLight;
            dataGridViewMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterials.Columns.AddRange(new DataGridViewColumn[] { categoryColumn, itemColumn, quantityColumn, unitCostColumn, totalCostColumn });
            dataGridViewMaterials.Location = new Point(15, 73);
            dataGridViewMaterials.Name = "dataGridViewMaterials";
            dataGridViewMaterials.Size = new Size(532, 372);
            dataGridViewMaterials.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(itemLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(itemBox, 1, 1);
            tableLayoutPanel1.Controls.Add(quantityBox, 2, 1);
            tableLayoutPanel1.Controls.Add(unitCostBox, 3, 1);
            tableLayoutPanel1.Controls.Add(categoryBox, 0, 1);
            tableLayoutPanel1.Controls.Add(categoryLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(quantityLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(unitCostLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(addItemButton, 4, 1);
            tableLayoutPanel1.Location = new Point(15, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(529, 55);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new Point(108, 0);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(31, 15);
            itemLabel.TabIndex = 13;
            itemLabel.Text = "Item";
            // 
            // itemBox
            // 
            itemBox.Location = new Point(108, 25);
            itemBox.Name = "itemBox";
            itemBox.Size = new Size(76, 23);
            itemBox.TabIndex = 12;
            // 
            // quantityBox
            // 
            quantityBox.Location = new Point(213, 25);
            quantityBox.Name = "quantityBox";
            quantityBox.Size = new Size(76, 23);
            quantityBox.TabIndex = 13;
            // 
            // unitCostBox
            // 
            unitCostBox.Location = new Point(318, 25);
            unitCostBox.Name = "unitCostBox";
            unitCostBox.Size = new Size(76, 23);
            unitCostBox.TabIndex = 14;
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Floor", "Walls", "Openings", "Roof" });
            categoryBox.Location = new Point(3, 25);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(76, 23);
            categoryBox.TabIndex = 12;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(3, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(55, 15);
            categoryLabel.TabIndex = 12;
            categoryLabel.Text = "Category";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(213, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(53, 15);
            quantityLabel.TabIndex = 14;
            quantityLabel.Text = "Quantity";
            // 
            // unitCostLabel
            // 
            unitCostLabel.AutoSize = true;
            unitCostLabel.Location = new Point(318, 0);
            unitCostLabel.Name = "unitCostLabel";
            unitCostLabel.Size = new Size(56, 15);
            unitCostLabel.TabIndex = 15;
            unitCostLabel.Text = "Unit Cost";
            // 
            // addItemButton
            // 
            addItemButton.AutoSize = true;
            addItemButton.BackColor = SystemColors.ActiveCaption;
            addItemButton.Location = new Point(423, 25);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(68, 25);
            addItemButton.TabIndex = 17;
            addItemButton.Text = "Add";
            addItemButton.UseVisualStyleBackColor = false;
            addItemButton.Click += addItemButton_Click;
            // 
            // categoryColumn
            // 
            categoryColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            categoryColumn.HeaderText = "Category";
            categoryColumn.Name = "categoryColumn";
            categoryColumn.Width = 80;
            // 
            // itemColumn
            // 
            itemColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            itemColumn.HeaderText = "Item";
            itemColumn.Name = "itemColumn";
            // 
            // quantityColumn
            // 
            quantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantityColumn.HeaderText = "Quantity";
            quantityColumn.Name = "quantityColumn";
            // 
            // unitCostColumn
            // 
            unitCostColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            unitCostColumn.HeaderText = "Unit Cost";
            unitCostColumn.Name = "unitCostColumn";
            // 
            // totalCostColumn
            // 
            totalCostColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalCostColumn.HeaderText = "Cost";
            totalCostColumn.Name = "totalCostColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(565, 493);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridViewMaterials);
            Controls.Add(buttonsLayoutPanel);
            Name = "Form1";
            Text = "Material Cost Estimator";
            buttonsLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterials).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button clearButton;
        private Button saveButton;
        private Button calculateButton;
        private TableLayoutPanel buttonsLayoutPanel;
        private DataGridView dataGridViewMaterials;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox itemBox;
        private TextBox quantityBox;
        private TextBox unitCostBox;
        private ComboBox categoryBox;
        private Label categoryLabel;
        private Label itemLabel;
        private Label quantityLabel;
        private Label unitCostLabel;
        private Button addItemButton;
        private Button loadButton;
        private DataGridViewTextBoxColumn categoryColumn;
        private DataGridViewTextBoxColumn itemColumn;
        private DataGridViewTextBoxColumn quantityColumn;
        private DataGridViewTextBoxColumn unitCostColumn;
        private DataGridViewTextBoxColumn totalCostColumn;
    }
}
