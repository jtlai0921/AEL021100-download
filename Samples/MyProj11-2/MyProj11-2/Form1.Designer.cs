namespace MyProj11_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataSet11 = new MyProj11_2.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT  成績單.*\r\nFROM     成績單";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [成績單] ([學號], [姓名], [國文], [數學], [英文]) VALUES (@學號, @姓名, @國文, @數學, @英文)" +
    ";\r\nSELECT 學號, 姓名, 國文, 數學, 英文 FROM 成績單 WHERE (學號 = @學號)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@學號", System.Data.SqlDbType.NVarChar, 0, "學號"),
            new System.Data.SqlClient.SqlParameter("@姓名", System.Data.SqlDbType.NVarChar, 0, "姓名"),
            new System.Data.SqlClient.SqlParameter("@國文", System.Data.SqlDbType.Int, 0, "國文"),
            new System.Data.SqlClient.SqlParameter("@數學", System.Data.SqlDbType.Int, 0, "數學"),
            new System.Data.SqlClient.SqlParameter("@英文", System.Data.SqlDbType.Int, 0, "英文")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@學號", System.Data.SqlDbType.NVarChar, 0, "學號"),
            new System.Data.SqlClient.SqlParameter("@姓名", System.Data.SqlDbType.NVarChar, 0, "姓名"),
            new System.Data.SqlClient.SqlParameter("@國文", System.Data.SqlDbType.Int, 0, "國文"),
            new System.Data.SqlClient.SqlParameter("@數學", System.Data.SqlDbType.Int, 0, "數學"),
            new System.Data.SqlClient.SqlParameter("@英文", System.Data.SqlDbType.Int, 0, "英文"),
            new System.Data.SqlClient.SqlParameter("@Original_學號", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "學號", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_姓名", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "姓名", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_國文", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "國文", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_數學", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "數學", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_英文", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "英文", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [成績單] WHERE (([學號] = @Original_學號) AND ([姓名] = @Original_姓名) AND ([國文" +
    "] = @Original_國文) AND ([數學] = @Original_數學) AND ([英文] = @Original_英文))";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_學號", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "學號", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_姓名", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "姓名", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_國文", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "國文", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_數學", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "數學", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_英文", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "英文", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "成績單", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("學號", "學號"),
                        new System.Data.Common.DataColumnMapping("姓名", "姓名"),
                        new System.Data.Common.DataColumnMapping("國文", "國文"),
                        new System.Data.Common.DataColumnMapping("數學", "數學"),
                        new System.Data.Common.DataColumnMapping("英文", "英文")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jean\\Documents\\Grade" +
    "s.mdf;Integrated Security=True;Connect Timeout=30";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "請選擇學生姓名：";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataSet11;
            this.comboBox1.DisplayMember = "成績單.姓名";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "成績單.學號";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 244);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

