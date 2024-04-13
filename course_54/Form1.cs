using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDiscoverTypeInformation(object sender, EventArgs e)
        {
            // Get the type name entered by the user
            string typeName = textBox1.Text;
            //this.textBox1.TextChanged += new System.EventHandler(this.txtTypeName_TextChanged);


            // Clear the list boxes before populating them with new information
            lstMethods.Items.Clear();
            lstProperties.Items.Clear();
            lstConstructors.Items.Clear();

            try
            {
                // Get the Type object for the specified type name
                Type type = Type.GetType(typeName);

                if (type != null)
                {
                    // Get methods of the type and populate the methods list box
                    MethodInfo[] methods = type.GetMethods();
                    foreach (MethodInfo method in methods)
                    {
                        lstMethods.Items.Add(method.ReturnType.Name + " " + method.Name);
                    }

                    // Get properties of the type and populate the properties list box
                    PropertyInfo[] properties = type.GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        lstProperties.Items.Add(property.PropertyType.Name + " " + property.Name);
                    }

                    // Get constructors of the type and populate the constructors list box
                    ConstructorInfo[] constructors = type.GetConstructors();
                    foreach (ConstructorInfo constructor in constructors)
                    {
                        lstConstructors.Items.Add(constructor.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Type not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
