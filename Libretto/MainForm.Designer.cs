namespace Libretto
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addAuctionButton = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.auctionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.auctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.myOrders = new System.Windows.Forms.TabPage();
            this.ordersRefreshButton = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.Auction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPanelButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionBindingSource)).BeginInit();
            this.myOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "label1";
            // 
            // addAuctionButton
            // 
            this.addAuctionButton.Location = new System.Drawing.Point(1104, 12);
            this.addAuctionButton.Name = "addAuctionButton";
            this.addAuctionButton.Size = new System.Drawing.Size(87, 24);
            this.addAuctionButton.TabIndex = 1;
            this.addAuctionButton.Text = "Dodaj aukcje";
            this.addAuctionButton.UseVisualStyleBackColor = true;
            this.addAuctionButton.Click += new System.EventHandler(this.addAuctionButton_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainPage);
            this.mainTabControl.Controls.Add(this.myOrders);
            this.mainTabControl.Location = new System.Drawing.Point(12, 38);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1179, 572);
            this.mainTabControl.TabIndex = 2;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.refreshButton);
            this.mainPage.Controls.Add(this.auctionDataGridView);
            this.mainPage.Controls.Add(this.searchButton);
            this.mainPage.Controls.Add(this.searchTextBox);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(1171, 546);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Przeglądaj aukcje";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(289, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Odśwież";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // auctionDataGridView
            // 
            this.auctionDataGridView.AllowUserToAddRows = false;
            this.auctionDataGridView.AllowUserToDeleteRows = false;
            this.auctionDataGridView.AutoGenerateColumns = false;
            this.auctionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auctionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.openColumn});
            this.auctionDataGridView.DataSource = this.auctionBindingSource;
            this.auctionDataGridView.Location = new System.Drawing.Point(6, 33);
            this.auctionDataGridView.Name = "auctionDataGridView";
            this.auctionDataGridView.ReadOnly = true;
            this.auctionDataGridView.Size = new System.Drawing.Size(1104, 385);
            this.auctionDataGridView.TabIndex = 2;
            this.auctionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.auctionDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PricePerUnit";
            this.dataGridViewTextBoxColumn6.HeaderText = "PricePerUnit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Creator";
            this.dataGridViewTextBoxColumn3.HeaderText = "Creator";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemQuantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "ItemQuantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // openColumn
            // 
            this.openColumn.HeaderText = "Przeglądaj";
            this.openColumn.Name = "openColumn";
            this.openColumn.ReadOnly = true;
            this.openColumn.Text = "Otwórz";
            // 
            // auctionBindingSource
            // 
            this.auctionBindingSource.DataSource = typeof(Libretto.Model.Entity.Auction);
            this.auctionBindingSource.CurrentChanged += new System.EventHandler(this.auctionBindingSource_CurrentChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(208, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(196, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // myOrders
            // 
            this.myOrders.Controls.Add(this.ordersRefreshButton);
            this.myOrders.Controls.Add(this.orderDataGridView);
            this.myOrders.Location = new System.Drawing.Point(4, 22);
            this.myOrders.Name = "myOrders";
            this.myOrders.Padding = new System.Windows.Forms.Padding(3);
            this.myOrders.Size = new System.Drawing.Size(1171, 546);
            this.myOrders.TabIndex = 1;
            this.myOrders.Text = "Moje zamówienia";
            this.myOrders.UseVisualStyleBackColor = true;
            // 
            // ordersRefreshButton
            // 
            this.ordersRefreshButton.Location = new System.Drawing.Point(7, 6);
            this.ordersRefreshButton.Name = "ordersRefreshButton";
            this.ordersRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.ordersRefreshButton.TabIndex = 1;
            this.ordersRefreshButton.Text = "Odśwież";
            this.ordersRefreshButton.UseVisualStyleBackColor = true;
            this.ordersRefreshButton.Click += new System.EventHandler(this.ordersRefreshButton_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Auction,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(6, 35);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.Size = new System.Drawing.Size(1144, 420);
            this.orderDataGridView.TabIndex = 0;
            // 
            // Auction
            // 
            this.Auction.DataPropertyName = "Auction";
            this.Auction.HeaderText = "Auction";
            this.Auction.Name = "Auction";
            this.Auction.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Seller";
            this.dataGridViewTextBoxColumn7.HeaderText = "Seller";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn10.HeaderText = "Date";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn11.HeaderText = "Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Libretto.Model.Entity.Order);
            this.orderBindingSource.CurrentChanged += new System.EventHandler(this.orderBindingSource_CurrentChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Auction";
            this.dataGridViewTextBoxColumn1.HeaderText = "Auction";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // adminPanelButton
            // 
            this.adminPanelButton.Location = new System.Drawing.Point(975, 13);
            this.adminPanelButton.Name = "adminPanelButton";
            this.adminPanelButton.Size = new System.Drawing.Size(123, 23);
            this.adminPanelButton.TabIndex = 3;
            this.adminPanelButton.Text = "Panel administracyjny";
            this.adminPanelButton.UseVisualStyleBackColor = true;
            this.adminPanelButton.Click += new System.EventHandler(this.adminPanelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 622);
            this.Controls.Add(this.adminPanelButton);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.addAuctionButton);
            this.Controls.Add(this.usernameLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainTabControl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionBindingSource)).EndInit();
            this.myOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button addAuctionButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage myOrders;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.BindingSource auctionBindingSource;
        private System.Windows.Forms.DataGridView auctionDataGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn openColumn;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button ordersRefreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button adminPanelButton;
    }
}