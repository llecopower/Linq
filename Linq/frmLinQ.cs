using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class frmLinQ : Form
    {
        public frmLinQ()
        {
            InitializeComponent();
        }

        List<ClsStudent> tabStudents = new List<ClsStudent>();

        private void frmLinQ_Load(object sender, EventArgs e)
        {

            tabStudents.Add(new ClsStudent("Alex", "Fashion", 5));
            tabStudents.Add(new ClsStudent("Maria", "Computer", 80));
            tabStudents.Add(new ClsStudent("Abran", "Fashion", 95));
            tabStudents.Add(new ClsStudent("Julia", "Accounting", 60));
            tabStudents.Add(new ClsStudent("Juan", "Computer", 78));
            tabStudents.Add(new ClsStudent("Nani", "Fashion", 12));

            //fill the combobox with the Programs
            var allPrograms = (from element in tabStudents
                               select element.Program).Distinct(); //WE LOVE LINQ

            cboProgram.DisplayMember = "Program";
            cboProgram.DataSource = allPrograms.ToList();


            var Students = from element in tabStudents
                           select element;

            GridResult.DataSource = Students.ToList();

        }

        private void cboProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            var findStudents = from element in tabStudents
                               where element.Program == cboProgram.SelectedItem.ToString()
                               select element;
                GridResult.DataSource = findStudents.ToList();



        }
    }
}
