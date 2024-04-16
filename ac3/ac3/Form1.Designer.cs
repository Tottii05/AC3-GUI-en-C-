namespace ac3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            totalTextBox = new Label();
            domesticCapitaTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            activitiesTextBox = new TextBox();
            domesticXarxaTextBox = new TextBox();
            poblationTextBox = new TextBox();
            label4 = new Label();
            comarcaComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            yearComboBox = new ComboBox();
            label1 = new Label();
            saveBtn = new Button();
            clearBtn = new Button();
            groupBox2 = new GroupBox();
            lowestConsumShowValue = new Label();
            biggestConsumShowValue = new Label();
            domesticAverageShowValue = new Label();
            biggerPoblationShowValue = new Label();
            label10 = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            comarquesDataGrid = new DataGridView();
            consumBindingSource1 = new BindingSource(components);
            consumBindingSource = new BindingSource(components);
            poblationErrorProvider = new ErrorProvider(components);
            domesticXarxaErrorProvider = new ErrorProvider(components);
            AEErrorProvider = new ErrorProvider(components);
            PerCapitaErrorProvider = new ErrorProvider(components);
            TotalErrorProvider = new ErrorProvider(components);
            yearErrorProvider = new ErrorProvider(components);
            comarcaErrorProvider = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comarquesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consumBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consumBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)poblationErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)domesticXarxaErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AEErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PerCapitaErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comarcaErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(totalTextBox);
            groupBox1.Controls.Add(domesticCapitaTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(activitiesTextBox);
            groupBox1.Controls.Add(domesticXarxaTextBox);
            groupBox1.Controls.Add(poblationTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comarcaComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(yearComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(419, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // totalTextBox
            // 
            totalTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            totalTextBox.Location = new Point(306, 108);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(41, 18);
            totalTextBox.TabIndex = 10;
            totalTextBox.Text = "Total";
            // 
            // domesticCapitaTextBox
            // 
            domesticCapitaTextBox.Location = new Point(419, 70);
            domesticCapitaTextBox.Name = "domesticCapitaTextBox";
            domesticCapitaTextBox.Size = new Size(100, 23);
            domesticCapitaTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(306, 73);
            label6.Name = "label6";
            label6.Size = new Size(123, 35);
            label6.TabIndex = 8;
            label6.Text = "Consum domèstic per càpita";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(126, 73);
            label5.Name = "label5";
            label5.Size = new Size(147, 35);
            label5.TabIndex = 7;
            label5.Text = "Activitats econòmiques i font pròpies";
            // 
            // activitiesTextBox
            // 
            activitiesTextBox.Location = new Point(126, 115);
            activitiesTextBox.Name = "activitiesTextBox";
            activitiesTextBox.Size = new Size(100, 23);
            activitiesTextBox.TabIndex = 6;
            // 
            // domesticXarxaTextBox
            // 
            domesticXarxaTextBox.Location = new Point(6, 115);
            domesticXarxaTextBox.Name = "domesticXarxaTextBox";
            domesticXarxaTextBox.Size = new Size(100, 23);
            domesticXarxaTextBox.TabIndex = 5;
            // 
            // poblationTextBox
            // 
            poblationTextBox.Location = new Point(173, 37);
            poblationTextBox.Name = "poblationTextBox";
            poblationTextBox.Size = new Size(100, 23);
            poblationTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(6, 73);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 2;
            label4.Text = "Domèstic xarxa";
            // 
            // comarcaComboBox
            // 
            comarcaComboBox.FormattingEnabled = true;
            comarcaComboBox.Location = new Point(74, 37);
            comarcaComboBox.Name = "comarcaComboBox";
            comarcaComboBox.Size = new Size(81, 23);
            comarcaComboBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(173, 19);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Població";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(74, 19);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Comarca";
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(6, 37);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(50, 23);
            yearComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Any";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(468, 171);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Guardar";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(378, 171);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "Netejar";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lowestConsumShowValue);
            groupBox2.Controls.Add(biggestConsumShowValue);
            groupBox2.Controls.Add(domesticAverageShowValue);
            groupBox2.Controls.Add(biggerPoblationShowValue);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(564, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 126);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            // 
            // lowestConsumShowValue
            // 
            lowestConsumShowValue.AutoSize = true;
            lowestConsumShowValue.ForeColor = Color.Blue;
            lowestConsumShowValue.Location = new Point(252, 103);
            lowestConsumShowValue.Name = "lowestConsumShowValue";
            lowestConsumShowValue.Size = new Size(13, 15);
            lowestConsumShowValue.TabIndex = 9;
            lowestConsumShowValue.Text = "0";
            lowestConsumShowValue.Visible = false;
            // 
            // biggestConsumShowValue
            // 
            biggestConsumShowValue.AutoSize = true;
            biggestConsumShowValue.ForeColor = Color.Blue;
            biggestConsumShowValue.Location = new Point(252, 78);
            biggestConsumShowValue.Name = "biggestConsumShowValue";
            biggestConsumShowValue.Size = new Size(13, 15);
            biggestConsumShowValue.TabIndex = 8;
            biggestConsumShowValue.Text = "0";
            biggestConsumShowValue.Visible = false;
            // 
            // domesticAverageShowValue
            // 
            domesticAverageShowValue.AutoSize = true;
            domesticAverageShowValue.ForeColor = Color.Blue;
            domesticAverageShowValue.Location = new Point(151, 54);
            domesticAverageShowValue.Name = "domesticAverageShowValue";
            domesticAverageShowValue.Size = new Size(13, 15);
            domesticAverageShowValue.TabIndex = 7;
            domesticAverageShowValue.Text = "0";
            domesticAverageShowValue.Visible = false;
            // 
            // biggerPoblationShowValue
            // 
            biggerPoblationShowValue.AutoSize = true;
            biggerPoblationShowValue.ForeColor = Color.Blue;
            biggerPoblationShowValue.Location = new Point(151, 28);
            biggerPoblationShowValue.Name = "biggerPoblationShowValue";
            biggerPoblationShowValue.Size = new Size(13, 15);
            biggerPoblationShowValue.TabIndex = 4;
            biggerPoblationShowValue.Text = "0";
            biggerPoblationShowValue.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(6, 103);
            label10.Name = "label10";
            label10.Size = new Size(240, 15);
            label10.TabIndex = 6;
            label10.Text = "Consum domèstic mitjà per càpita més alt:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(6, 78);
            label11.Name = "label11";
            label11.Size = new Size(240, 15);
            label11.TabIndex = 5;
            label11.Text = "Consum domèstic mitjà per càpita més alt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(6, 54);
            label8.Name = "label8";
            label8.Size = new Size(139, 15);
            label8.TabIndex = 5;
            label8.Text = "Consum domèstic mitjà:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(6, 28);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 4;
            label7.Text = "Població > 20000 hab.:";
            // 
            // comarquesDataGrid
            // 
            comarquesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comarquesDataGrid.Location = new Point(67, 237);
            comarquesDataGrid.Name = "comarquesDataGrid";
            comarquesDataGrid.Size = new Size(743, 130);
            comarquesDataGrid.TabIndex = 4;
            comarquesDataGrid.CellContentClick += comarquesDataGrid_CellContentClick;
            // 
            // consumBindingSource1
            // 
            consumBindingSource1.DataSource = typeof(Consum);
            // 
            // consumBindingSource
            // 
            consumBindingSource.DataSource = typeof(Consum);
            // 
            // poblationErrorProvider
            // 
            poblationErrorProvider.ContainerControl = this;
            // 
            // domesticXarxaErrorProvider
            // 
            domesticXarxaErrorProvider.ContainerControl = this;
            // 
            // AEErrorProvider
            // 
            AEErrorProvider.ContainerControl = this;
            // 
            // PerCapitaErrorProvider
            // 
            PerCapitaErrorProvider.ContainerControl = this;
            // 
            // TotalErrorProvider
            // 
            TotalErrorProvider.ContainerControl = this;
            // 
            // yearErrorProvider
            // 
            yearErrorProvider.ContainerControl = this;
            // 
            // comarcaErrorProvider
            // 
            comarcaErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 379);
            Controls.Add(comarquesDataGrid);
            Controls.Add(groupBox2);
            Controls.Add(clearBtn);
            Controls.Add(saveBtn);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comarquesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)consumBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)consumBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)poblationErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)domesticXarxaErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)AEErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)PerCapitaErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)comarcaErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private TextBox activitiesTextBox;
        private TextBox domesticXarxaTextBox;
        private TextBox poblationTextBox;
        private Label label4;
        private ComboBox comarcaComboBox;
        private Label label3;
        private Label label2;
        private ComboBox yearComboBox;
        private TextBox domesticCapitaTextBox;
        private Label label6;
        private TextBox textBox3;
        private Label totalTextBox;
        private Button saveBtn;
        private Button clearBtn;
        private GroupBox groupBox2;
        private Label label7;
        private Label label8;
        private Label lowestConsumShowValue;
        private Label biggestConsumShowValue;
        private Label domesticAverageShowValue;
        private Label biggerPoblationShowValue;
        private Label label10;
        private Label label11;
        private DataGridView comarquesDataGrid;
        private BindingSource consumBindingSource1;
        private BindingSource consumBindingSource;
        private ErrorProvider poblationErrorProvider;
        private ErrorProvider domesticXarxaErrorProvider;
        private ErrorProvider AEErrorProvider;
        private ErrorProvider PerCapitaErrorProvider;
        private ErrorProvider TotalErrorProvider;
        private ErrorProvider yearErrorProvider;
        private ErrorProvider comarcaErrorProvider;
    }
}
