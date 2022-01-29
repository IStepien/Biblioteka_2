
namespace Biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGenre = new System.Windows.Forms.Label();
            this.comBGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.comBAuthor = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picBBook = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.comBTitle = new System.Windows.Forms.ComboBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnSBook = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.valueSelection = new RatingControl.ValueSelection();
            this.lBoxTopRated = new System.Windows.Forms.ListBox();
            this.lblTopRated = new System.Windows.Forms.Label();
            this.btnAddRating = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(9, 19);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(146, 31);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "WYBIERZ GATUNEK";
            // 
            // comBGenre
            // 
            this.comBGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBGenre.FormattingEnabled = true;
            this.comBGenre.Location = new System.Drawing.Point(12, 39);
            this.comBGenre.MaxLength = 20;
            this.comBGenre.Name = "comBGenre";
            this.comBGenre.Size = new System.Drawing.Size(121, 21);
            this.comBGenre.TabIndex = 10;
            this.comBGenre.SelectedIndexChanged += new System.EventHandler(this.comBGenre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "WYBIERZ AUTORA";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 145);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 13);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "TYTUŁ";
            // 
            // comBAuthor
            // 
            this.comBAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBAuthor.FormattingEnabled = true;
            this.comBAuthor.Location = new System.Drawing.Point(12, 107);
            this.comBAuthor.MaxLength = 50;
            this.comBAuthor.Name = "comBAuthor";
            this.comBAuthor.Size = new System.Drawing.Size(239, 21);
            this.comBAuthor.TabIndex = 17;
            this.comBAuthor.SelectedIndexChanged += new System.EventHandler(this.comBAuthor_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picBBook
            // 
            this.picBBook.Location = new System.Drawing.Point(329, 39);
            this.picBBook.Name = "picBBook";
            this.picBBook.Size = new System.Drawing.Size(124, 169);
            this.picBBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBBook.TabIndex = 19;
            this.picBBook.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(119, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "ANULUJ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(329, 229);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(108, 35);
            this.btnAddPicture.TabIndex = 25;
            this.btnAddPicture.Text = "DODAJ/ZMIEŃ OBRAZ";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Visible = false;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(225, 450);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(131, 23);
            this.btnEditBook.TabIndex = 28;
            this.btnEditBook.Text = "EDYTUJ KSIĄŻKĘ";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Visible = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // comBTitle
            // 
            this.comBTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBTitle.FormattingEnabled = true;
            this.comBTitle.Location = new System.Drawing.Point(15, 174);
            this.comBTitle.MaxLength = 50;
            this.comBTitle.Name = "comBTitle";
            this.comBTitle.Size = new System.Drawing.Size(236, 21);
            this.comBTitle.TabIndex = 29;
            this.comBTitle.SelectedIndexChanged += new System.EventHandler(this.comBTitle_SelectedIndexChanged);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(225, 448);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(131, 25);
            this.btnUpdateBook.TabIndex = 31;
            this.btnUpdateBook.Text = "ZAPISZ KSIĄŻKĘ";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Visible = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnSBook
            // 
            this.btnSBook.Location = new System.Drawing.Point(15, 421);
            this.btnSBook.Name = "btnSBook";
            this.btnSBook.Size = new System.Drawing.Size(75, 23);
            this.btnSBook.TabIndex = 32;
            this.btnSBook.Text = "ZAPISZ";
            this.btnSBook.UseVisualStyleBackColor = true;
            this.btnSBook.Visible = false;
            this.btnSBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(378, 506);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = "WYLOGUJ";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // valueSelection
            // 
            this.valueSelection.Location = new System.Drawing.Point(12, 201);
            this.valueSelection.Name = "valueSelection";
            this.valueSelection.RatingValue = 0;
            this.valueSelection.Size = new System.Drawing.Size(216, 85);
            this.valueSelection.TabIndex = 34;
            this.valueSelection.Visible = false;
            this.valueSelection.valueChanged += new System.EventHandler(this.valueSelection_valueChanged);
            // 
            // lBoxTopRated
            // 
            this.lBoxTopRated.FormattingEnabled = true;
            this.lBoxTopRated.Location = new System.Drawing.Point(15, 293);
            this.lBoxTopRated.Name = "lBoxTopRated";
            this.lBoxTopRated.Size = new System.Drawing.Size(236, 56);
            this.lBoxTopRated.TabIndex = 35;
            // 
            // lblTopRated
            // 
            this.lblTopRated.AutoSize = true;
            this.lblTopRated.Location = new System.Drawing.Point(15, 272);
            this.lblTopRated.Name = "lblTopRated";
            this.lblTopRated.Size = new System.Drawing.Size(122, 13);
            this.lblTopRated.TabIndex = 36;
            this.lblTopRated.Text = "NAJWYŻEJ OCENIANE";
            // 
            // btnAddRating
            // 
            this.btnAddRating.Location = new System.Drawing.Point(221, 235);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(102, 23);
            this.btnAddRating.TabIndex = 37;
            this.btnAddRating.Text = "DODAJ OCENĘ";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Visible = false;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 541);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.lblTopRated);
            this.Controls.Add(this.lBoxTopRated);
            this.Controls.Add(this.valueSelection);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.comBTitle);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.picBBook);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comBAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBGenre);
            this.Controls.Add(this.lblGenre);
            this.Name = "Form1";
            this.Text = "BIBLIOTEKA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox comBGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comBAuthor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picBBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.ComboBox comBTitle;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnSBook;
        private System.Windows.Forms.Button btnLogout;
        private RatingControl.ValueSelection valueSelection;
        private System.Windows.Forms.ListBox lBoxTopRated;
        private System.Windows.Forms.Label lblTopRated;
        private System.Windows.Forms.Button btnAddRating;
    }
}

