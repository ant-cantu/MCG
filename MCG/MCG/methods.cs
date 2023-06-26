using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace VIN2Chassis_Converter
{
    class methods
    {
        chassis c = new chassis();

        public void getChassis()
        {
            var f = mainForm.ActiveForm as mainForm;

            //If no model is selected
            if (f.modelBox.SelectedIndex < 0)
            {
                throwError(1);
                return;
            }

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(f.carInfo);

            string carData = f.yearBox.Text + " | " + f.modelBox.Text;
            row.Cells[0].Value = carData;

            for (int i = 0; i <= 2; i++)
            {
                row.Cells[1 + i].Value = chassis.baseChassis[f.modelBox.SelectedIndex, i];
            }
            
            f.carInfo.Rows.Add(row);

            Clipboard.SetText(chassis.baseChassis[f.modelBox.SelectedIndex, 0].Replace(".", ""));
        }
        
        
        public void updateModel()
        {
            var f = mainForm.ActiveForm as mainForm;

            c.setModel(f.yearBox.SelectedIndex);
            c.setChassis(f.yearBox.SelectedIndex);
            f.modelBox.DataSource = chassis.model;
        }

        public void throwError(int errorType)
        {
            if(errorType == 1) //No model has been selected.
            {
                mainForm.errorThrown = true;
                MessageBox.Show("Error: Please select a model.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (errorType == 2) //No year has been selected.
            {
                mainForm.errorThrown = true;
                MessageBox.Show("Error: Please select a year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
