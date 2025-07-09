namespace NBAScheduleApp

{

    partial class Form1

    {

        /// <summary>

        /// Обязательная переменная конструктора.

        /// </summary>

        private System.ComponentModel.IContainer components = null;



        /// <summary>

        /// Освободить все используемые ресурсы.

        /// </summary>

        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>

        protected override void Dispose(bool disposing)

        {

            if (disposing && (components != null))

            {

                components.Dispose();

            }

            base.Dispose(disposing);

        }



        #region Код, автоматически созданный конструктором форм Windows



        /// <summary>

        /// Требуемый метод для поддержки конструктора — не изменяйте 

        /// содержимое этого метода с помощью редактора кода.

        /// </summary>

        private void InitializeComponent()

        {

            this.listViewMatches = new System.Windows.Forms.ListView();

            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.lblStatus = new System.Windows.Forms.Label();

            this.cbTeams = new System.Windows.Forms.ComboBox();

            this.cbSeasons = new System.Windows.Forms.ComboBox();

            this.btnLoadMatches = new System.Windows.Forms.Button();

            this.label1 = new System.Windows.Forms.Label();

            this.label2 = new System.Windows.Forms.Label();

            this.SuspendLayout();



            // 

            // listViewMatches

            // 

            this.listViewMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {

            this.columnHeader1,

            this.columnHeader2,

            this.columnHeader3,

            this.columnHeader4});

            this.listViewMatches.FullRowSelect = true;

            this.listViewMatches.GridLines = true;

            this.listViewMatches.HideSelection = false;

            this.listViewMatches.Location = new System.Drawing.Point(20, 120);

            this.listViewMatches.Name = "listViewMatches";

            this.listViewMatches.Size = new System.Drawing.Size(650, 350);

            this.listViewMatches.TabIndex = 0;

            this.listViewMatches.UseCompatibleStateImageBehavior = false;

            this.listViewMatches.View = System.Windows.Forms.View.Details;

            // 

            // columnHeader1

            // 

            this.columnHeader1.Text = "Дата";

            this.columnHeader1.Width = 100;

            // 

            // columnHeader2

            // 

            this.columnHeader2.Text = "Хозяева";

            this.columnHeader2.Width = 200;

            // 

            // columnHeader3

            // 

            this.columnHeader3.Text = "Гости";

            this.columnHeader3.Width = 200;

            // 

            // columnHeader4

            // 

            this.columnHeader4.Text = "Счёт";

            this.columnHeader4.Width = 100;

            // 

            // lblStatus

            // 

            this.lblStatus.AutoSize = true;

            this.lblStatus.Location = new System.Drawing.Point(20, 480);

            this.lblStatus.Name = "lblStatus";

            this.lblStatus.Size = new System.Drawing.Size(0, 20);

            this.lblStatus.TabIndex = 1;

            // 

            // cbTeams

            // 

            this.cbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbTeams.FormattingEnabled = true;

            this.cbTeams.Location = new System.Drawing.Point(20, 40);

            this.cbTeams.Name = "cbTeams";

            this.cbTeams.Size = new System.Drawing.Size(300, 28);

            this.cbTeams.TabIndex = 2;

            // 

            // cbSeasons

            // 

            this.cbSeasons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbSeasons.FormattingEnabled = true;

            this.cbSeasons.Items.AddRange(new object[] {

            "2023-2024",

            "2022-2023",

            "2021-2022"});

            this.cbSeasons.Location = new System.Drawing.Point(20, 80);

            this.cbSeasons.Name = "cbSeasons";

            this.cbSeasons.Size = new System.Drawing.Size(300, 28);

            this.cbSeasons.TabIndex = 3;

            // 

            // btnLoadMatches

            // 

            this.btnLoadMatches.Location = new System.Drawing.Point(350, 40);

            this.btnLoadMatches.Name = "btnLoadMatches";

            this.btnLoadMatches.Size = new System.Drawing.Size(150, 60);

            this.btnLoadMatches.TabIndex = 4;

            this.btnLoadMatches.Text = "Загрузить матчи";

            this.btnLoadMatches.UseVisualStyleBackColor = true;

            this.btnLoadMatches.Click += new System.EventHandler(this.btnLoadMatches_Click);

            // 

            // label1

            // 

            this.label1.AutoSize = true;

            this.label1.Location = new System.Drawing.Point(20, 15);

            this.label1.Name = "label1";

            this.label1.Size = new System.Drawing.Size(68, 20);

            this.label1.TabIndex = 5;

            this.label1.Text = "Команда";

            // 

            // label2

            // 

            this.label2.AutoSize = true;

            this.label2.Location = new System.Drawing.Point(20, 65);

            this.label2.Name = "label2";

            this.label2.Size = new System.Drawing.Size(56, 20);

            this.label2.TabIndex = 6;

            this.label2.Text = "Сезон";

            // 

            // Form1

            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(700, 520);

            this.Controls.Add(this.label2);

            this.Controls.Add(this.label1);

            this.Controls.Add(this.btnLoadMatches);

            this.Controls.Add(this.cbSeasons);

            this.Controls.Add(this.cbTeams);

            this.Controls.Add(this.lblStatus);

            this.Controls.Add(this.listViewMatches);

            this.Name = "Form1";

            this.Text = "NBA Schedule App";

            this.Load += new System.EventHandler(this.Form1_Load);

            this.ResumeLayout(false);

            this.PerformLayout();



        }



        #endregion



        private System.Windows.Forms.ListView listViewMatches;

        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.ComboBox cbTeams;

        private System.Windows.Forms.ComboBox cbSeasons;

        private System.Windows.Forms.Button btnLoadMatches;

        private System.Windows.Forms.ColumnHeader columnHeader1;

        private System.Windows.Forms.ColumnHeader columnHeader2;

        private System.Windows.Forms.ColumnHeader columnHeader3;

        private System.Windows.Forms.ColumnHeader columnHeader4;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;

    }

}
