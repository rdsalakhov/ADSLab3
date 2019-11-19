using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class DataInputView : Form
    {

        List<Tuple<char, char>> dependensies = new List<Tuple<char, char>>();
        public DataInputView()
        {
            InitializeComponent();
        }

        private void LimitTextToNumbers(object sender, KeyPressEventArgs args)
        {
            args.Handled = !char.IsDigit(args.KeyChar) & !char.IsControl(args.KeyChar);
        }

        private void TasksNumberFilled(object sender, EventArgs e)
        {
            int alphabetLength = 25;
            
            int numberOfTasks;
            if (!int.TryParse(tasksNumberTextField.Text, out numberOfTasks) || numberOfTasks > alphabetLength)
            {
                MessageBox.Show($"The value {tasksNumberTextField.Text} is improper. Try to fill it with an integer lower or equal to {alphabetLength}");
                numberOfTasks = 0;
                tasksNumberTextField.Text = "";
                tasksNumberTextField.Focus();
                return;
            }
            UpdateNodeBoxes(numberOfTasks);
        }

        private void UpdateNodeBoxes(int numberOfTasks)
        {
            int alphabetOffSet = 65; // offset to convert byte to char

            leftNodeBox.Items.Clear();
            rightNodeBox.Items.Clear();
            for (int i = 0; i < numberOfTasks; i++)
            {
                leftNodeBox.Items.Add((char)(i+alphabetOffSet));
                rightNodeBox.Items.Add((char)(i+alphabetOffSet));
            }
        }

        private void addConnectionButton_Click(object sender, EventArgs e)
        {
            if (rightNodeBox.SelectedItem == null || leftNodeBox.SelectedItem == null)
            {
                MessageBox.Show("One or more jobs were not selected in the checkboxes. Try selecting both!");
                return;
            }

            if (rightNodeBox.SelectedItem.ToString() == leftNodeBox.SelectedItem.ToString())
            {
                MessageBox.Show("Unable to add dependency between simmilar job. Try choosing another job in one of the comboboxes");
                return;
            }
            Tuple<char, char> pairToInput = new Tuple<char, char>(leftNodeBox.SelectedItem.ToString()[0], rightNodeBox.SelectedItem.ToString()[0]);
            if (dependensies.Contains(pairToInput))
            {
                MessageBox.Show("Unable to add dependency that is already in the list!");
                return;
            }
            dependensies.Add(new Tuple<char, char>(pairToInput.Item1, pairToInput.Item2));
            UpdateDependencyList();
        }

        private void UpdateDependencyList()
        {
            dependenciesList.Items.Clear();
            foreach(Tuple<char, char> keyValue in dependensies)
            {
                dependenciesList.Items.Add(keyValue.Item1.ToString() + " -> " + keyValue.Item2.ToString());
            }
        }

        private void removeDependencyButton_Click(object sender, EventArgs e)
        {
            if (dependenciesList.SelectedItem == null)
            {
                MessageBox.Show("No dependency selected to delete. Firstly choose one from the list");
                return;
            }
            string stringFromList = dependenciesList.SelectedItem.ToString();
            Tuple<char, char> valueToDelete = new Tuple<char, char>(stringFromList[0], stringFromList[stringFromList.Length-1]);
            dependensies.Remove(valueToDelete);
            UpdateDependencyList();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            int numberOfEmployees;
            if (!int.TryParse(empNumberTextField.Text, out numberOfEmployees))
            {
                MessageBox.Show($"Unable to convert {empNumberTextField.Text} to integer for NUMBER OF EMPLOYEES. Try again!");
                return;
            }
            if (dependensies.Count == 0)
            {
                MessageBox.Show("There are no dependencies in the list");
                return;
            }
            ComputeWithData(numberOfEmployees, dependensies);
        }

        private void ComputeWithData(int numberOfEmployees, List<Tuple<char, char>> dependecies)
        {
            Console.WriteLine("Data is sent!");
            Console.WriteLine($"Number of workers - {numberOfEmployees}");
            foreach(var dependecy in dependecies)
            {
                Console.WriteLine(dependecy.Item1.ToString() + " " + dependecy.Item2.ToString());
            }
        }
    }
}
