using System;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class NumberList : Form
    {
        //  constant variable which holds the max value the listbox can hold
        public const int MAX_SIZE = 30;

        public NumberList()
        {
            InitializeComponent();
            btnCondition();
            lbNumber.AllowDrop = true;
            pbxBin.AllowDrop = true;
        }

        private void listStatus()
        {
            lblCount.Text = Convert.ToString(lbNumber.Items.Count);

            if (lbNumber.Items.Count == 0)
            {
                lblFirstValue.Text = "0";
                lblLastValue.Text = "0";
                lblMinValue.Text = "0";
                lblMaxValue.Text = "0";
            }
            else
            {
                lblFirstValue.Text = Convert.ToString(lbNumber.Items[0]);
                int lastvalueindex = lbNumber.Items.Count - 1;
                lblLastValue.Text = Convert.ToString(lbNumber.Items[lastvalueindex]);
            }

            if (lbNumber.Items.Count != 0)
            {
                //  finding smallest value in listbox
                int smallest = Convert.ToInt32(lbNumber.Items[0]);

                foreach (int element in lbNumber.Items)
                {
                    if (element <= smallest)
                    {
                        smallest = element;
                        lblMinValue.Text = Convert.ToString(smallest);
                    }
                }
                //  finding largest value in listbox
                int largest = Convert.ToInt32(lbNumber.Items[0]);

                foreach (int elements in lbNumber.Items)
                {
                    if (elements >= largest)
                    {
                        largest = elements;
                        lblMaxValue.Text = Convert.ToString(largest);
                    }
                }
            }
        }

        private void btnCondition()
        {
            if (lbNumber.Items.Count < MAX_SIZE)
            {
                btnInitialize.Enabled = true;
                btnInsert.Enabled = true;
            }
            else if (lbNumber.Items.Count >= MAX_SIZE)
            {
                btnInitialize.Enabled = false;
                btnInsert.Enabled = false;
            }

            if (lbNumber.Items.Count >= 2)
            {
                if (rbBinarySearch.Checked)
                {
                    btnShuffle.Enabled = false;
                }
                else btnShuffle.Enabled = true;
            }
            else btnShuffle.Enabled = false;

            if (rbUnsorted.Checked)
            {
                rbLinearSearch.Enabled = true;
                rbBinarySearch.Enabled = false;
            }
            else if (rbSorted.Checked)
            {
                rbBinarySearch.Enabled = true;
                rbLinearSearch.Enabled = false;
                btnShuffle.Enabled = false;
            }

            if (lbNumber.Items.Count == 0)
            {
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSearch.Enabled = false;
                rbSorted.Enabled = false;
                rbLinearSearch.Enabled = false;
                rbBinarySearch.Enabled = false;
                rbUnsorted.Checked = true;
            }
            else
            {
                btnDelete.Enabled = true;
                btnClear.Enabled = true;
                btnSearch.Enabled = true;
                rbSorted.Enabled = true;
            }
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            initializeList();
            btnCondition();
            listStatus();
        }

        private void initializeList()
        {
            Random rndInsert = new Random();
            int rnd = rndInsert.Next();
            bool found = false;

            do
            {
                rnd = rndInsert.Next(0, 100);

                if (lbNumber.Items.Count == 0)
                {
                    lbNumber.Items.Add(rnd);
                    found = true;
                }

                for (int i = 0; i <= lbNumber.Items.Count - 1; i++)
                {
                    if (Convert.ToInt32(lbNumber.Items[i]) == rnd)
                    {
                        found = true;
                        break;
                    }
                    else found = false;
                }

                if (!found)
                {
                    lbNumber.Items.Add(rnd);
                }

            } while ((lbNumber.Items.Count != MAX_SIZE));
        }

        private void sortList()
        {
            int size = Convert.ToInt32(lbNumber.Items.Count);

            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    if (Convert.ToInt32(lbNumber.Items[i]) > Convert.ToInt32(lbNumber.Items[j]))
                    {
                        int temp = Convert.ToInt32(lbNumber.Items[i]);
                        lbNumber.Items[i] = Convert.ToInt32(lbNumber.Items[j]);
                        lbNumber.Items[j] = temp;
                    }
                }
            }
        }

        private void rbUnsorted_CheckedChanged(object sender, EventArgs e)
        {
            btnCondition();
        }

        private void rbSorted_CheckedChanged(object sender, EventArgs e)
        {
            sortList();
            listStatus();
            btnCondition();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // textbox is empty
            if ((!string.IsNullOrWhiteSpace(txtInsert.Text)))
            {
                if ((Convert.ToInt32(txtInsert.Text) <= 0) || (Convert.ToInt32(txtInsert.Text) <= 100))
                {
                    bool found = false;
                    // if listbox doesnt contain inserted value (duplicate)
                    for (int i = 0; i < lbNumber.Items.Count; i++)
                    {
                        if (Convert.ToInt32(lbNumber.Items[i]) == (Convert.ToInt32(txtInsert.Text)))
                        {
                            found = true;
                        }
                    }

                    if (found)
                    {
                        MessageBox.Show("Error! Duplicate value!");
                    }
                    else if (!found)
                    {
                        insertValue();
                    }
                }
                else MessageBox.Show("Please enter a value between 0-100!");
            }
            else MessageBox.Show("Textbox is empty!");

            btnCondition();
            listStatus();
        }

        private void insertValue()
        {
            if (rbUnsorted.Checked) // if maxcount is full, button should be disabled
            {
                lbNumber.Items.Add(Convert.ToInt32(txtInsert.Text));
            }
            // rbSorted.Checked
            else orderedInsert();
        }

        // used only when listbox is sorted
        private void orderedInsert()
        {
            int targetvalue = Convert.ToInt32(txtInsert.Text);
            int insertionpoint = 0;

            for (int i = 0; i < lbNumber.Items.Count; i++)
            {
                if (Convert.ToInt32(lbNumber.Items[i]) > targetvalue)
                {
                    insertionpoint = i;
                    break;
                }
                else insertionpoint = lbNumber.Items.Count;
            }

            lbNumber.Items.Add(0);

            for (int i = lbNumber.Items.Count - 1; i >= 0; i--)
            {
                if (i == insertionpoint)
                {
                    lbNumber.Items[i] = targetvalue;
                    break;
                }
                else lbNumber.Items[i] = lbNumber.Items[i - 1];
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbLinearSearch.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtInsert.Text))
                {
                    MessageBox.Show("Textbox is empty!");
                }
                else linearSearch();
            }
            else if (rbBinarySearch.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtInsert.Text))
                {
                    MessageBox.Show("Textbox is empty!");
                }
                else binarySearch();
            }
            else MessageBox.Show("Please select a search option!");
        }

        private void linearSearch()
        {
            int searchvalue = Convert.ToInt32(txtInsert.Text);
            int index = 0;
            bool found = false;

            while (!found)
            {
                if (Convert.ToInt32(lbNumber.Items[index]) == searchvalue)
                {
                    found = true;
                }
                else index++;

                if (index >= lbNumber.Items.Count)
                {
                    break;
                }
            }

            if (found)
            {
                MessageBox.Show(Convert.ToString(searchvalue) + " was found at Index: " + Convert.ToString(index));
            }
            else MessageBox.Show("The value specified cannot be found.");
        }

        private void binarySearch()
        {
            int searchvalue = Convert.ToInt32(txtInsert.Text);
            int min = 0;
            int max = lbNumber.Items.Count - 1;
            bool found = false;

            while (min <= max)
            {
                int midpoint = (min + max) / 2;

                if (searchvalue == Convert.ToInt32(lbNumber.Items[midpoint]))
                {
                    MessageBox.Show(Convert.ToString(searchvalue + " was found at Index: " + Convert.ToString(midpoint)));
                    found = true;
                    break;
                }
                else if (searchvalue < Convert.ToInt32(lbNumber.Items[midpoint]))
                {
                    max = midpoint - 1;
                }
                else min = midpoint + 1;
            }

            if (!found)
            {
                MessageBox.Show("The value specified cannot be found.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbNumber.Items.Count == 0)
            {
                MessageBox.Show("There are no values to delete.");
            }
            else if (lbNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item!");
            }
            else deleteValue();

            btnCondition();
            listStatus();
        }

        private void deleteValue()
        {
            int selectedindex = lbNumber.SelectedIndex;

            for (int i = selectedindex; i < lbNumber.Items.Count - 1; i++)
            {
                lbNumber.Items[i] = lbNumber.Items[i + 1];
            }

            lbNumber.Items.RemoveAt(lbNumber.Items.Count - 1);
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            //  shuffles listBox elements
            Random rndShuffle = new Random();

            if (rbUnsorted.Checked)
            {
                ListBox.ObjectCollection list = lbNumber.Items;
                int listcount = list.Count;
                //  shuffles listBox elements
                lbNumber.BeginUpdate();
                while (listcount > 1)
                {
                    listcount--;
                    int k = rndShuffle.Next(listcount + 1);
                    object value = list[k];
                    list[k] = list[listcount];
                    list[listcount] = value;
                }
                lbNumber.EndUpdate();
                lbNumber.Invalidate();
            }

            btnCondition();
            listStatus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbNumber.Items.Clear();
            btnCondition();
            listStatus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            // prevents non-integer values from being entered e.g. string
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a numeric value!");
            }
        }

        private void lbNumber_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbNumber.Items.Count > 0)
            {
                lbNumber.DoDragDrop(lbNumber.SelectedIndex, DragDropEffects.Move);
            }
            else MessageBox.Show("There are no items to select!");
        }

        private void pbxBin_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pbxBin_DragDrop(object sender, DragEventArgs e)
        {
            deleteValue();
            btnCondition();
            listStatus();
        }
    }
}