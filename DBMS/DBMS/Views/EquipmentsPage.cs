using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBMS.Controllers;
using DBMS.Controllers.DB;
using DBMS.Controllers.Interfaces;

namespace DBMS.Views
{
    public partial class EquipmentsPage : Form, IViewHandler
    {
        private Form previousForm;

        private EquipmentsController controller;

        private Equipment currentEquipment;

        private LinkedList<TextBox> textboxes;

        public EquipmentsPage()
        {
            InitializeComponent();
            
            controller = new EquipmentsController();
            controller.Control();

            textboxes = new LinkedList<TextBox>();
            textboxes.AddLast(textBox_equipment_name);
            textboxes.AddLast(textBox_price);
            textboxes.AddLast(textBox_condition);
            textboxes.AddLast(textBox_warranty_duration);

            comboBox.Items.Add("New Equipment");
            if (controller.HasEquipment())
            {
                LinkedList<string> eqs = controller.GetEquipments();
                foreach(string equipment in eqs)
                    comboBox.Items.Add(equipment);
            }
            comboBox.SelectedIndex = 0;
        }

        public void Activate(Form sender)
        {
            Activate();

            previousForm = sender;

            Show();
        }

        public void Destroy()
        {
            Dispose();
            Close();

            ((IViewHandler)previousForm).Destroy();

            GC.Collect();
        }

        public void NavigateTo(IViewHandler form)
        {
            Hide();

            form.Activate(this);
        }

        private void EquipmentsPage_Load(object sender, EventArgs e)
        {

        }

        private void EquipmentsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();

            GC.Collect();
        }

        private void TextBox_price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_price.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox_price.Text = textBox_price.Text.Remove(textBox_price.Text.Length - 1);
            }
        }

        private void TextBox_warranty_duration_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_warranty_duration.Text, "[^0-9|.]"))
            {
                MessageBox.Show("Please enter only numbers or dot.");
                textBox_warranty_duration.Text = textBox_warranty_duration.Text.Remove(textBox_warranty_duration.Text.Length - 1);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_add.Text = comboBox.SelectedItem.Equals("New Equipment") ? "ADD" : "CHANGE";

            if(comboBox.SelectedIndex != 0) {
                button_delete.Visible = true;

                currentEquipment = controller.GetEquipment(Int32.Parse(comboBox.Text.Split('-')[0].Trim()));

                textBox_equipment_name.Text = currentEquipment.Name;
                textBox_price.Text = currentEquipment.Price.ToString();
                textBox_condition.Text = currentEquipment.Condition;
                date_of_arrival.Value = currentEquipment.DateOfArrival;
                textBox_warranty_duration.Text = currentEquipment.WarrantyDuration.ToString();
            } else {
                button_delete.Visible = false;

                foreach(TextBox textbox in textboxes)
                    textbox.Text = "";
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            foreach(TextBox textbox in textboxes)
            {
                if (textbox.Text.Equals(""))
                {
                    MessageBox.Show("Please do not leave any empty fields");
                    return;
                }
            }

            if (button_add.Text.Equals("ADD"))
            {
                currentEquipment = new Equipment(textBox_equipment_name.Text, float.Parse(textBox_price.Text), textBox_condition.Text,
                    DateTime.Parse(date_of_arrival.Text), Int32.Parse(textBox_warranty_duration.Text));

                controller.AddEquipment(currentEquipment);

                EquipmentAdded();
            } else {
                Equipment newEquipment = new Equipment(textBox_equipment_name.Text, float.Parse(textBox_price.Text), textBox_condition.Text,
                    DateTime.Parse(date_of_arrival.Text), int.Parse(textBox_warranty_duration.Text));

                if(currentEquipment.GetDifferences(newEquipment).Count == 0)
                {
                    MessageBox.Show("Nothing has changed.");
                    return;
                }

                controller.ChangeEquipment(currentEquipment, newEquipment);

                MessageBox.Show("Equipment " + currentEquipment.Name + " has changed");

                currentEquipment = newEquipment;

                EquipmentChanged();
            }
        }

        private void EquipmentChanged()
        {
            int i = comboBox.SelectedIndex;

            comboBox.Items.Clear();
            comboBox.Items.Add("New Equipment");
            LinkedList<string> eqs = controller.GetEquipments();
            foreach(string eq in eqs)
                comboBox.Items.Add(eq);

            comboBox.SelectedIndex = i;
        }

        private void EquipmentAdded()
        {
            MessageBox.Show("Equipment " + textBox_equipment_name.Text + " Added");

            comboBox.Items.Clear();

            comboBox.Items.Add("New Equipment");
            if (controller.HasEquipment())
            {
                LinkedList<string> eqs = controller.GetEquipments();
                foreach (string equipment in eqs)
                    comboBox.Items.Add(equipment);
            }
            comboBox.SelectedIndex = comboBox.Items.Count - 1;
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            NavigateTo((IViewHandler) previousForm);
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            controller.DeleteEquipment(currentEquipment);

            EquipmentDeleted();
        }

        private void EquipmentDeleted()
        {
            MessageBox.Show("Equipment " + textBox_equipment_name.Text + " Deleted");

            comboBox.Items.Clear();

            comboBox.Items.Add("New Equipment");
            if (controller.HasEquipment())
            {
                LinkedList<string> eqs = controller.GetEquipments();
                foreach (string equipment in eqs)
                    comboBox.Items.Add(equipment);
            }
            comboBox.SelectedIndex = 0;
        }
    }
}
