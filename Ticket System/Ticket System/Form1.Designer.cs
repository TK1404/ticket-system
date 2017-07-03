namespace Ticket_System
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.innerhalbEinerWocheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.späterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vergangeneTermineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketSystemDBDataSet = new Ticket_System.TicketSystemDBDataSet();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new Ticket_System.TicketSystemDBDataSetTableAdapters.TicketsTableAdapter();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bearbeiterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansprechpartnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beschreibungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Stubert",
            "Renner",
            "Giebeler",
            "Akbayin",
            "Nickelsen",
            "Kirchmann"});
            this.comboBox1.Location = new System.Drawing.Point(12, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.comboBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 784);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 1);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 809);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(37, 382);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(71, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termineToolStripMenuItem
            // 
            this.termineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heuteToolStripMenuItem,
            this.innerhalbEinerWocheToolStripMenuItem,
            this.späterToolStripMenuItem,
            this.vergangeneTermineToolStripMenuItem});
            this.termineToolStripMenuItem.Name = "termineToolStripMenuItem";
            this.termineToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.termineToolStripMenuItem.Text = "Termine";
            // 
            // heuteToolStripMenuItem
            // 
            this.heuteToolStripMenuItem.Name = "heuteToolStripMenuItem";
            this.heuteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.heuteToolStripMenuItem.Text = "Heute";
            // 
            // innerhalbEinerWocheToolStripMenuItem
            // 
            this.innerhalbEinerWocheToolStripMenuItem.Name = "innerhalbEinerWocheToolStripMenuItem";
            this.innerhalbEinerWocheToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.innerhalbEinerWocheToolStripMenuItem.Text = "Innerhalb einer Woche";
            // 
            // späterToolStripMenuItem
            // 
            this.späterToolStripMenuItem.Name = "späterToolStripMenuItem";
            this.späterToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.späterToolStripMenuItem.Text = "Später";
            // 
            // vergangeneTermineToolStripMenuItem
            // 
            this.vergangeneTermineToolStripMenuItem.Name = "vergangeneTermineToolStripMenuItem";
            this.vergangeneTermineToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.vergangeneTermineToolStripMenuItem.Text = "Vergangene Termine";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Supportfall",
            "Anpassung",
            "Anfrage"});
            this.comboBox2.Location = new System.Drawing.Point(1211, 159);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1086, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Typ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1089, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bearbeiter";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Stubert",
            "Renner",
            "Giebeler",
            "Akbayin",
            "Nickelsen",
            "Kirchmann"});
            this.comboBox3.Location = new System.Drawing.Point(1211, 218);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1089, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Firma";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1211, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1089, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ansprechparter";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1211, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1089, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Titel";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1211, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1089, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Beschreibung";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1211, 385);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 20);
            this.textBox4.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.titelDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.bearbeiterDataGridViewTextBoxColumn,
            this.firmaDataGridViewTextBoxColumn,
            this.ansprechpartnerDataGridViewTextBoxColumn,
            this.beschreibungDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(150, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(894, 809);
            this.dataGridView1.TabIndex = 16;
            // 
            // ticketSystemDBDataSet
            // 
            this.ticketSystemDBDataSet.DataSetName = "TicketSystemDBDataSet";
            this.ticketSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.ticketSystemDBDataSet;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titelDataGridViewTextBoxColumn
            // 
            this.titelDataGridViewTextBoxColumn.DataPropertyName = "Titel";
            this.titelDataGridViewTextBoxColumn.HeaderText = "Titel";
            this.titelDataGridViewTextBoxColumn.Name = "titelDataGridViewTextBoxColumn";
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            // 
            // bearbeiterDataGridViewTextBoxColumn
            // 
            this.bearbeiterDataGridViewTextBoxColumn.DataPropertyName = "Bearbeiter";
            this.bearbeiterDataGridViewTextBoxColumn.HeaderText = "Bearbeiter";
            this.bearbeiterDataGridViewTextBoxColumn.Name = "bearbeiterDataGridViewTextBoxColumn";
            // 
            // firmaDataGridViewTextBoxColumn
            // 
            this.firmaDataGridViewTextBoxColumn.DataPropertyName = "Firma";
            this.firmaDataGridViewTextBoxColumn.HeaderText = "Firma";
            this.firmaDataGridViewTextBoxColumn.Name = "firmaDataGridViewTextBoxColumn";
            // 
            // ansprechpartnerDataGridViewTextBoxColumn
            // 
            this.ansprechpartnerDataGridViewTextBoxColumn.DataPropertyName = "Ansprechpartner";
            this.ansprechpartnerDataGridViewTextBoxColumn.HeaderText = "Ansprechpartner";
            this.ansprechpartnerDataGridViewTextBoxColumn.Name = "ansprechpartnerDataGridViewTextBoxColumn";
            // 
            // beschreibungDataGridViewTextBoxColumn
            // 
            this.beschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung";
            this.beschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung";
            this.beschreibungDataGridViewTextBoxColumn.Name = "beschreibungDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 811);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem innerhalbEinerWocheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem späterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vergangeneTermineToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TicketSystemDBDataSet ticketSystemDBDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private TicketSystemDBDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bearbeiterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansprechpartnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beschreibungDataGridViewTextBoxColumn;

    }
}

