namespace Game
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combo_list_machine = new System.Windows.Forms.ComboBox();
            this.lbl_selectMachine = new System.Windows.Forms.Label();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.panel_add = new System.Windows.Forms.Panel();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_edit_gameId = new System.Windows.Forms.TextBox();
            this.txt_edit_machineId = new System.Windows.Forms.TextBox();
            this.lbl_edit_gameId = new System.Windows.Forms.Label();
            this.lbl_edit_machineId = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_game_id = new System.Windows.Forms.TextBox();
            this.txt_machine_id = new System.Windows.Forms.TextBox();
            this.lbl_game_id = new System.Windows.Forms.Label();
            this.lbl_Machine_id = new System.Windows.Forms.Label();
            this.btn_save_CurrentMachine = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_grid.SuspendLayout();
            this.panel_add.SuspendLayout();
            this.panel_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 212);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // combo_list_machine
            // 
            this.combo_list_machine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_list_machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_list_machine.FormattingEnabled = true;
            this.combo_list_machine.Location = new System.Drawing.Point(209, 599);
            this.combo_list_machine.Name = "combo_list_machine";
            this.combo_list_machine.Size = new System.Drawing.Size(138, 32);
            this.combo_list_machine.TabIndex = 6;
            // 
            // lbl_selectMachine
            // 
            this.lbl_selectMachine.AutoSize = true;
            this.lbl_selectMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectMachine.Location = new System.Drawing.Point(43, 602);
            this.lbl_selectMachine.Name = "lbl_selectMachine";
            this.lbl_selectMachine.Size = new System.Drawing.Size(160, 25);
            this.lbl_selectMachine.TabIndex = 7;
            this.lbl_selectMachine.Text = "Select Machine";
            // 
            // panel_grid
            // 
            this.panel_grid.Controls.Add(this.dataGridView1);
            this.panel_grid.Location = new System.Drawing.Point(45, 368);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(422, 218);
            this.panel_grid.TabIndex = 8;
            // 
            // panel_add
            // 
            this.panel_add.Controls.Add(this.btn_add);
            this.panel_add.Controls.Add(this.txt_game_id);
            this.panel_add.Controls.Add(this.txt_machine_id);
            this.panel_add.Controls.Add(this.lbl_game_id);
            this.panel_add.Controls.Add(this.lbl_Machine_id);
            this.panel_add.Location = new System.Drawing.Point(45, 159);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(422, 193);
            this.panel_add.TabIndex = 9;
            // 
            // panel_edit
            // 
            this.panel_edit.Controls.Add(this.btn_cancel);
            this.panel_edit.Controls.Add(this.btn_delete);
            this.panel_edit.Controls.Add(this.btn_edit);
            this.panel_edit.Controls.Add(this.txt_edit_gameId);
            this.panel_edit.Controls.Add(this.txt_edit_machineId);
            this.panel_edit.Controls.Add(this.lbl_edit_gameId);
            this.panel_edit.Controls.Add(this.lbl_edit_machineId);
            this.panel_edit.Location = new System.Drawing.Point(42, 159);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(422, 190);
            this.panel_edit.TabIndex = 10;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gray;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(273, 118);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 39);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(138, 118);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(114, 39);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(8, 118);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(113, 39);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_edit_gameId
            // 
            this.txt_edit_gameId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edit_gameId.Location = new System.Drawing.Point(160, 55);
            this.txt_edit_gameId.Name = "txt_edit_gameId";
            this.txt_edit_gameId.Size = new System.Drawing.Size(245, 26);
            this.txt_edit_gameId.TabIndex = 12;
            // 
            // txt_edit_machineId
            // 
            this.txt_edit_machineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edit_machineId.Location = new System.Drawing.Point(160, 16);
            this.txt_edit_machineId.Name = "txt_edit_machineId";
            this.txt_edit_machineId.Size = new System.Drawing.Size(245, 26);
            this.txt_edit_machineId.TabIndex = 11;
            // 
            // lbl_edit_gameId
            // 
            this.lbl_edit_gameId.AutoSize = true;
            this.lbl_edit_gameId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_gameId.Location = new System.Drawing.Point(14, 54);
            this.lbl_edit_gameId.Name = "lbl_edit_gameId";
            this.lbl_edit_gameId.Size = new System.Drawing.Size(107, 29);
            this.lbl_edit_gameId.TabIndex = 10;
            this.lbl_edit_gameId.Text = "Game ID";
            // 
            // lbl_edit_machineId
            // 
            this.lbl_edit_machineId.AutoSize = true;
            this.lbl_edit_machineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_machineId.Location = new System.Drawing.Point(14, 12);
            this.lbl_edit_machineId.Name = "lbl_edit_machineId";
            this.lbl_edit_machineId.Size = new System.Drawing.Size(133, 29);
            this.lbl_edit_machineId.TabIndex = 9;
            this.lbl_edit_machineId.Text = "Machine ID";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(8, 118);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(397, 44);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_game_id
            // 
            this.txt_game_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_game_id.Location = new System.Drawing.Point(160, 71);
            this.txt_game_id.Name = "txt_game_id";
            this.txt_game_id.Size = new System.Drawing.Size(245, 29);
            this.txt_game_id.TabIndex = 8;
            // 
            // txt_machine_id
            // 
            this.txt_machine_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_machine_id.Location = new System.Drawing.Point(160, 17);
            this.txt_machine_id.Name = "txt_machine_id";
            this.txt_machine_id.Size = new System.Drawing.Size(245, 29);
            this.txt_machine_id.TabIndex = 7;
            // 
            // lbl_game_id
            // 
            this.lbl_game_id.AutoSize = true;
            this.lbl_game_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game_id.Location = new System.Drawing.Point(3, 70);
            this.lbl_game_id.Name = "lbl_game_id";
            this.lbl_game_id.Size = new System.Drawing.Size(107, 29);
            this.lbl_game_id.TabIndex = 6;
            this.lbl_game_id.Text = "Game ID";
            // 
            // lbl_Machine_id
            // 
            this.lbl_Machine_id.AutoSize = true;
            this.lbl_Machine_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Machine_id.Location = new System.Drawing.Point(3, 16);
            this.lbl_Machine_id.Name = "lbl_Machine_id";
            this.lbl_Machine_id.Size = new System.Drawing.Size(133, 29);
            this.lbl_Machine_id.TabIndex = 5;
            this.lbl_Machine_id.Text = "Machine ID";
            // 
            // btn_save_CurrentMachine
            // 
            this.btn_save_CurrentMachine.BackColor = System.Drawing.Color.White;
            this.btn_save_CurrentMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_CurrentMachine.Location = new System.Drawing.Point(353, 596);
            this.btn_save_CurrentMachine.Name = "btn_save_CurrentMachine";
            this.btn_save_CurrentMachine.Size = new System.Drawing.Size(113, 39);
            this.btn_save_CurrentMachine.TabIndex = 16;
            this.btn_save_CurrentMachine.Text = "Save";
            this.btn_save_CurrentMachine.UseVisualStyleBackColor = false;
            this.btn_save_CurrentMachine.Click += new System.EventHandler(this.btn_save_CurrentMachine_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(461, 65);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(52, 47);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logo.Location = new System.Drawing.Point(139, 65);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(229, 88);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 19;
            this.Logo.TabStop = false;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 705);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel_edit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save_CurrentMachine);
            this.Controls.Add(this.panel_add);
            this.Controls.Add(this.panel_grid);
            this.Controls.Add(this.lbl_selectMachine);
            this.Controls.Add(this.combo_list_machine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_grid.ResumeLayout(false);
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_list_machine;
        private System.Windows.Forms.Label lbl_selectMachine;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_game_id;
        private System.Windows.Forms.TextBox txt_machine_id;
        private System.Windows.Forms.Label lbl_game_id;
        private System.Windows.Forms.Label lbl_Machine_id;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_edit_gameId;
        private System.Windows.Forms.TextBox txt_edit_machineId;
        private System.Windows.Forms.Label lbl_edit_gameId;
        private System.Windows.Forms.Label lbl_edit_machineId;
        private System.Windows.Forms.Button btn_save_CurrentMachine;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Logo;
    }
}