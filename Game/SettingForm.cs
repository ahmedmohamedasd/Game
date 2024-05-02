using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Game
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }
        string path = @"..\..\json\machineDB.json";


        Color newColour = Color.FromArgb(119, 2, 110);

        private void SettingForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            updateGridView();
            panel_add.Visible = true;
            panel_edit.Visible = false;
            var model = getMachineModelFromJsonfile();
            if(model.currentMachine.game_id != "")
            {
                combo_list_machine.Items.Add(model.currentMachine.game_id);
                combo_list_machine.SelectedIndex = 0;
            }
            else
            {
                combo_list_machine.Items.Add("Select Game");
                combo_list_machine.SelectedIndex = 0;
            }
            if (model.allMachine.Length > 0)
            {
                for (int i = 0; i < model.allMachine.Length; i++)
                {
                    if(model.currentMachine.game_id != model.allMachine[i].game_id)
                    {
                       combo_list_machine.Items.Add(model.allMachine[i].game_id);
                    }
                }
            }

            #region Styling Form

            lbl_edit_gameId.ForeColor = newColour;
            lbl_edit_machineId.ForeColor = newColour;
            lbl_game_id.ForeColor = newColour;
            lbl_Machine_id.ForeColor = newColour;

            txt_game_id.ForeColor = newColour;
            txt_machine_id.ForeColor = newColour;
            txt_edit_gameId.ForeColor = newColour;
            txt_edit_machineId.ForeColor = newColour;
            btn_add.ForeColor = newColour;
            btn_save_CurrentMachine.ForeColor = newColour;
            lbl_selectMachine.ForeColor = newColour;
            combo_list_machine.ForeColor = newColour;
            btn_close.BackColor = newColour;
            btn_close.ForeColor = Color.White;
            #endregion

        }
        public machineDbModel getMachineModelFromJsonfile()
        {
            var jsondata = File.ReadAllText(@"..\..\json\machineDB.json");
            machineDbModel model = JsonConvert.DeserializeObject<machineDbModel>(jsondata);
            return model;
        }
        private void updateGridView()
        {
          var model = getMachineModelFromJsonfile();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Game ID");
            dataTable.Columns.Add("Machine ID");

            foreach (var item in model.allMachine)
            {
                dataTable.Rows.Add(item.game_id, item.machine_id);
            }
            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Game ID"].ReadOnly = true;
            dataGridView1.Columns["Machine ID"].ReadOnly = true;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dataGridView1.Columns[i].Width;

                // Remove AutoSizing:
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dataGridView1.Columns[i].Width = colw;
            }
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            panel_edit.Visible = true;
            panel_add.Visible = true;
            txt_edit_gameId.Text = dataGridView1.Rows[e.RowIndex].Cells["Game ID"].Value.ToString();
            txt_edit_machineId.Text = dataGridView1.Rows[e.RowIndex].Cells["Machine ID"].Value.ToString();
            txt_edit_gameId.ReadOnly = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            panel_edit.Visible = false;
            panel_add.Visible = true;
            txt_edit_gameId.Text = "";
            txt_edit_machineId.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var model = getMachineModelFromJsonfile();
            try
            {
                if (model.allMachine.Length > 0)
                {
                    BasicMachineModel md = new BasicMachineModel()
                    {
                        game_id = txt_edit_gameId.Text,
                        machine_id = txt_edit_machineId.Text
                    };
                    for (int i = 0; i < model.allMachine.Length; i++)
                    {
                        if (model.allMachine[i].game_id == md.game_id)
                        {
                            model.allMachine[i].machine_id = md.machine_id;
                        }
                    }
                    string json = JsonConvert.SerializeObject(model, Formatting.Indented);
                    File.WriteAllText(path, json);
                    MessageBox.Show("Game Edit Sucessfully");
                    txt_edit_gameId.Text = "";
                    txt_edit_machineId.Text ="";
                    panel_edit.Visible = false;

                    updateGridView();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var model = getMachineModelFromJsonfile();
                if (model.allMachine.Length > 0)
                {
                    BasicMachineModel md = new BasicMachineModel()
                    {
                        game_id = txt_edit_gameId.Text,
                        machine_id = txt_edit_machineId.Text
                    };

                    List<BasicMachineModel> list = new List<BasicMachineModel>();
                    for (int i = 0; i < model.allMachine.Length; i++)
                    {
                        if (model.allMachine[i].game_id != md.game_id)
                        {
                            list.Add(model.allMachine[i]);
                        }
                    }
                    model.allMachine = list.ToArray();
                    string json = JsonConvert.SerializeObject(model, Formatting.Indented);
                    File.WriteAllText(path, json);
                    MessageBox.Show("Game deleted Sucessfully");
                    txt_edit_gameId.Text = "";
                    txt_edit_machineId.Text = "";
                    panel_edit.Visible = false;
                    updateGridView();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_game_id.Text) || string.IsNullOrWhiteSpace(txt_machine_id.Text))
            {
                MessageBox.Show("Game id and Machine id Can not be empty");
            }
            else
            {
                try
                {
                    var jsondata = File.ReadAllText(path);
                    machineDbModel model = JsonConvert.DeserializeObject<machineDbModel>(jsondata);

                    BasicMachineModel basicMachineModel = new BasicMachineModel()
                    {
                        game_id = txt_game_id.Text,
                        machine_id = txt_machine_id.Text
                    };
                    List<BasicMachineModel> list = new List<BasicMachineModel>();
                    if (model.allMachine.Length > 0)
                    {
                        for (int i = 0; i < model.allMachine.Length; i++)
                        {
                            list.Add(model.allMachine[i]);
                        }

                    }
                    var checkmodel = list.FirstOrDefault(c => c.game_id.ToLower() == txt_game_id.Text.ToLower() || c.machine_id.ToLower() == txt_machine_id.Text.ToLower());
                    if (checkmodel != null)
                    {
                        MessageBox.Show("this Game Id or Machine Id Already Exist please check again");
                    }
                    else
                    {
                        list.Add(basicMachineModel);
                        model.allMachine = list.ToArray();
                        string json = JsonConvert.SerializeObject(model, Formatting.Indented);
                        File.WriteAllText(path, json);

                        txt_game_id.Text = "";
                        txt_machine_id.Text = "";
                        MessageBox.Show("Machine Added Sucessfully");
                        updateGridView();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btn_save_CurrentMachine_Click(object sender, EventArgs e)
        {
            var index = combo_list_machine.SelectedIndex;

            var gameId = combo_list_machine.Items[index];
            if((string)gameId != "Select Game")
            {
                var model = getMachineModelFromJsonfile();
                if (model != null)
                {
                    var curModel = model.allMachine.FirstOrDefault(c=>c.game_id ==(string)gameId);
                    if(curModel != null)
                    {
                        model.currentMachine = curModel;
                        string json = JsonConvert.SerializeObject(model, Formatting.Indented);
                        File.WriteAllText(path, json);

                        MessageBox.Show("Current Game Id Saved sucessfully");
                    }
                }

            }
            else
            {
                MessageBox.Show("Select Game Id First");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            this.Hide();
           
        }
    }
}
