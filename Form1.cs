namespace MaterialEstimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            // Validate input fields before adding new item
            if (string.IsNullOrEmpty(categoryBox.Text) || string.IsNullOrEmpty(itemBox.Text) ||
                string.IsNullOrEmpty(quantityBox.Text) || string.IsNullOrEmpty(unitCostBox.Text))
            {
                MessageBox.Show("Please fill out all fields before adding an item.");
                return;
            }

            // Parse the quantity and unit cost
            if (decimal.TryParse(quantityBox.Text, out decimal quantity) && decimal.TryParse(unitCostBox.Text, out decimal unitCost))
            {
                // Calculate the cost for the item
                decimal cost = quantity * unitCost;

                // Add the new row with category, item, quantity, unit cost, and calculated cost
                dataGridViewMaterials.Rows.Add(categoryBox.Text, itemBox.Text, quantity, unitCost, cost);

                // Clear input fields after adding
                categoryBox.SelectedIndex = -1;
                itemBox.Clear();
                quantityBox.Clear();
                unitCostBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Quantity and Unit Cost.");
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal totalCost = 0;

            // Calculate total cost by iterating through each row, excluding any total row
            foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
            {
                if (row.IsNewRow || row.Tag?.ToString() == "Total") continue; // Skip new row placeholder and total row
                totalCost += Convert.ToDecimal(row.Cells["totalCostColumn"].Value); // Update to the new column name
            }

            // Check if a total row already exists, and remove it if necessary
            if (dataGridViewMaterials.Rows.Count > 0 &&
                dataGridViewMaterials.Rows[dataGridViewMaterials.Rows.Count - 1].Tag?.ToString() == "Total")
            {
                dataGridViewMaterials.Rows.RemoveAt(dataGridViewMaterials.Rows.Count - 1);
            }

            // Add a new row for displaying the total cost at the bottom
            int rowIndex = dataGridViewMaterials.Rows.Add("Total Cost", "", "", "", totalCost);
            DataGridViewRow totalRow = dataGridViewMaterials.Rows[rowIndex];

            // Style the total row to make it visually distinct
            totalRow.DefaultCellStyle.Font = new Font(dataGridViewMaterials.Font, FontStyle.Bold);
            totalRow.DefaultCellStyle.BackColor = Color.LightGray;
            totalRow.Tag = "Total"; // Mark this row as the total row to distinguish it from regular rows
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all data from the DataGridView
            dataGridViewMaterials.Rows.Clear();

            // Reset input fields
            categoryBox.SelectedIndex = -1;
            itemBox.Clear();
            quantityBox.Clear();
            unitCostBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("Category,Item,Quantity,Unit Price,Cost");

                        foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
                        {
                            string category = row.Cells["categoryColumn"].Value?.ToString() ?? "";
                            string item = row.Cells["itemColumn"].Value?.ToString() ?? "";
                            string quantity = row.Cells["quantityColumn"].Value?.ToString() ?? "0";
                            string unitCost = row.Cells["unitCostColumn"].Value?.ToString() ?? "0";
                            string cost = row.Cells["totalCostColumn"].Value?.ToString() ?? "0";

                            writer.WriteLine($"{category},{item},{quantity},{unitCost},{cost}");
                        }
                    }
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        // Skip the header line
                        reader.ReadLine();

                        // Clear existing rows
                        dataGridViewMaterials.Rows.Clear();

                        // Read each line and add it to DataGridView
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] columns = line.Split(',');
                            dataGridViewMaterials.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4]);
                        }
                    }
                }
            }
        }
    }
}
