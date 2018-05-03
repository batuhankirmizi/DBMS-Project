using DBMS.Controllers;
using DBMS.Controllers.DB;
using DBMS.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBMS.Views
{
    public partial class Courses : Form, IViewHandler
    {
        private Form previousForm;

        private Course currentCourse;

        private LinkedList<TextBox> boxes = new LinkedList<TextBox>();

        private CoursesController controller;

        public Courses()
        {
            InitializeComponent();

            controller = new CoursesController();
            controller.Control();

            boxes.AddLast(textBox_course_name);
            boxes.AddLast(textBox_trainer);
            boxes.AddLast(textBox_description);
            boxes.AddLast(textBox_day);

            comboBox.Items.Add("New Course");
            if (controller.HasCourse())
            {
                foreach (string course in controller.GetCoursesForComboox())
                    comboBox.Items.Add(course);
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

        private void CoursesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();

            GC.Collect();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            NavigateTo((IViewHandler) previousForm);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex != 0) {
                button_delete.Visible = true;
                button_add.Text = "CHANGE";

                currentCourse = controller.GetCourse(Int32.Parse(comboBox.SelectedItem.ToString().Split(' ')[0]));
                textBox_course_name.Text = currentCourse.Name;
                textBox_trainer.Text = controller.GetEmployeeName(currentCourse.EmployeeId);
                textBox_description.Text = currentCourse.Description;
                textBox_day.Text = currentCourse.Day;
                comboBox_active.SelectedIndex = currentCourse.IsActive ? 0 : 1;
            } else {
                button_delete.Visible = false;
                button_add.Text = "ADD";

                textBox_course_name.Text = "";
                textBox_trainer.Text = "";
                textBox_description.Text = "";
                textBox_day.Text = "";
                comboBox_active.SelectedIndex = 0;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_trainer_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_trainer.Text, "[0-9]"))
            {
                MessageBox.Show("Please do not enter any numbers.");
                textBox_trainer.Text = textBox_trainer.Text.Remove(textBox_trainer.Text.Length - 1);
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (button_add.Text.Equals("ADD"))
            {
                foreach (TextBox box in boxes)
                    if (box.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Please do not leave any empty fields.");
                        return;
                    }

                if (controller.GetEmployeeId(textBox_trainer.Text) == 0)
                {
                    MessageBox.Show("Could not find such employee called " + textBox_trainer.Text);
                    return;
                }

                if (comboBox_active.Text.Equals(""))
                {
                    MessageBox.Show("Please choose if the course is active or not at the moment.");
                    return;
                }

                currentCourse = new Course(controller.GetEmployeeId(textBox_trainer.Text), textBox_course_name.Text,
                    textBox_description.Text, textBox_day.Text, comboBox_active.Text.Equals("Yes") ? true : false);

                controller.AddCourse(currentCourse);

                MessageBox.Show("Course " + textBox_course_name.Text + " has been added.");

                CourseChanged(comboBox.Items.Count);
            } else {
                Course newCourse = new Course(controller.GetEmployeeId(textBox_trainer.Text), textBox_course_name.Text,
                    textBox_description.Text, textBox_day.Text, comboBox_active.Text.Equals("Yes") ? true : false);

                if (currentCourse.GetDifferences(newCourse).Equals(""))
                {
                    MessageBox.Show("Nothing has changed.");
                    return;
                }
                
                if (controller.GetEmployeeId(textBox_trainer.Text) == 0)
                {
                    MessageBox.Show("Could not find such employee called " + textBox_trainer.Text);
                    return;
                }

                controller.Change(currentCourse, newCourse);

                MessageBox.Show("Course " + textBox_course_name.Text + " has been changed.");

                CourseChanged(comboBox.SelectedIndex);
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            controller.DeleteCourse(Int32.Parse(comboBox.SelectedItem.ToString().Split(' ')[0]));

            MessageBox.Show("Course " + currentCourse.Name + " has been deleted.");

            CourseChanged(0);
        }

        private void CourseChanged(int i)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("New Course");
            foreach (string course in controller.GetCoursesForComboox())
                comboBox.Items.Add(course);
            comboBox.SelectedIndex = i;
        }
    }
}
