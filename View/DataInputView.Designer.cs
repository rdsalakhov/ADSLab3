namespace View
{
    partial class DataInputView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tasksNumberTextField = new System.Windows.Forms.TextBox();
            this.empNumberTextField = new System.Windows.Forms.TextBox();
            this.leftNodeBox = new System.Windows.Forms.ComboBox();
            this.rightNodeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addDependencyButton = new System.Windows.Forms.Button();
            this.dependenciesList = new System.Windows.Forms.ListBox();
            this.removeDependencyButton = new System.Windows.Forms.Button();
            this.computeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(115, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of tasks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(115, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of employees:";
            // 
            // tasksNumberTextField
            // 
            this.tasksNumberTextField.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksNumberTextField.Location = new System.Drawing.Point(581, 114);
            this.tasksNumberTextField.Name = "tasksNumberTextField";
            this.tasksNumberTextField.Size = new System.Drawing.Size(164, 50);
            this.tasksNumberTextField.TabIndex = 2;
            this.tasksNumberTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitTextToNumbers);
            this.tasksNumberTextField.Leave += new System.EventHandler(this.TasksNumberFilled);
            // 
            // empNumberTextField
            // 
            this.empNumberTextField.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNumberTextField.Location = new System.Drawing.Point(581, 209);
            this.empNumberTextField.Name = "empNumberTextField";
            this.empNumberTextField.Size = new System.Drawing.Size(164, 50);
            this.empNumberTextField.TabIndex = 3;
            this.empNumberTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitTextToNumbers);
            // 
            // leftNodeBox
            // 
            this.leftNodeBox.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftNodeBox.FormattingEnabled = true;
            this.leftNodeBox.Location = new System.Drawing.Point(188, 374);
            this.leftNodeBox.Name = "leftNodeBox";
            this.leftNodeBox.Size = new System.Drawing.Size(145, 50);
            this.leftNodeBox.TabIndex = 4;
            // 
            // rightNodeBox
            // 
            this.rightNodeBox.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightNodeBox.FormattingEnabled = true;
            this.rightNodeBox.Location = new System.Drawing.Point(548, 374);
            this.rightNodeBox.Name = "rightNodeBox";
            this.rightNodeBox.Size = new System.Drawing.Size(145, 50);
            this.rightNodeBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(412, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "=>";
            // 
            // addDependencyButton
            // 
            this.addDependencyButton.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDependencyButton.Location = new System.Drawing.Point(264, 448);
            this.addDependencyButton.Name = "addDependencyButton";
            this.addDependencyButton.Size = new System.Drawing.Size(339, 55);
            this.addDependencyButton.TabIndex = 7;
            this.addDependencyButton.Text = "Add dependency";
            this.addDependencyButton.UseVisualStyleBackColor = true;
            this.addDependencyButton.Click += new System.EventHandler(this.addConnectionButton_Click);
            // 
            // dependenciesList
            // 
            this.dependenciesList.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dependenciesList.FormattingEnabled = true;
            this.dependenciesList.ItemHeight = 42;
            this.dependenciesList.Location = new System.Drawing.Point(77, 560);
            this.dependenciesList.Name = "dependenciesList";
            this.dependenciesList.Size = new System.Drawing.Size(397, 298);
            this.dependenciesList.TabIndex = 8;
            // 
            // removeDependencyButton
            // 
            this.removeDependencyButton.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDependencyButton.Location = new System.Drawing.Point(523, 601);
            this.removeDependencyButton.Name = "removeDependencyButton";
            this.removeDependencyButton.Size = new System.Drawing.Size(259, 103);
            this.removeDependencyButton.TabIndex = 9;
            this.removeDependencyButton.Text = "Remove dependency";
            this.removeDependencyButton.UseVisualStyleBackColor = true;
            this.removeDependencyButton.Click += new System.EventHandler(this.removeDependencyButton_Click);
            // 
            // computeButton
            // 
            this.computeButton.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeButton.Location = new System.Drawing.Point(252, 907);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(361, 103);
            this.computeButton.TabIndex = 10;
            this.computeButton.Text = "Compute!";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(274, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 43);
            this.label4.TabIndex = 11;
            this.label4.Text = "Input dependency:";
            // 
            // ClearListButton
            // 
            this.ClearListButton.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearListButton.Location = new System.Drawing.Point(523, 728);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(259, 103);
            this.ClearListButton.TabIndex = 12;
            this.ClearListButton.Text = "Clear list";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // DataInputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 1047);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.removeDependencyButton);
            this.Controls.Add(this.dependenciesList);
            this.Controls.Add(this.addDependencyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rightNodeBox);
            this.Controls.Add(this.leftNodeBox);
            this.Controls.Add(this.empNumberTextField);
            this.Controls.Add(this.tasksNumberTextField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DataInputView";
            this.Text = "н";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tasksNumberTextField;
        private System.Windows.Forms.TextBox empNumberTextField;
        private System.Windows.Forms.ComboBox leftNodeBox;
        private System.Windows.Forms.ComboBox rightNodeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addDependencyButton;
        private System.Windows.Forms.ListBox dependenciesList;
        private System.Windows.Forms.Button removeDependencyButton;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearListButton;
    }
}

